using Npgsql;
using NpgsqlTypes;
using Products.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Repository
{
    class ProductsRepo
    {
        //private string connStr = "Server=localhost;Port=5455;Database=rvbd2176;User Id=rvbd2176;Password=rvbd2176";
        private string connStr = "Server=localhost;Port=5432;Database=cpbd2145;User Id=cpbd2145;Password=cpbd2145";

        public List<StockStatusType> GetAllStockTypes()
        {
            List<StockStatusType> result = new List<StockStatusType>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "select sid, name from stock_status_types";

                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    var sid = dr.GetInt32(0);
                    var name = dr.GetString(1);

                    result.Add(new StockStatusType(sid, name));
                }

                command.Dispose();
            }

            return result;
        }


        public List<Product> GetAllProducts()
        {
            List<Product> result = new List<Product>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT X.name, X.price, Z.sid, Z.name, X.updated_at, X.deleted, X.pid from products as X " +
                    "INNER JOIN (SELECT name, MAX(updated_at) as updated_at FROM products GROUP BY name) Y ON X.updated_at = Y.updated_at AND X.name = Y.name " +
                    "INNER JOIN stock_status_types Z ON X.sid = Z.sid " +
                    "WHERE X.deleted = FALSE";

                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    var name = dr.GetString(0);
                    var price = dr.GetFloat(1);
                    var sid = dr.GetInt32(2);
                    var typeName = dr.GetString(3);
                    var updatedAt = dr.GetDateTime(4);
                    var deleted = dr.GetBoolean(5);
                    var pid = dr.GetInt32(6);

                    result.Add(new Product(pid, name, price, new StockStatusType(sid, typeName), deleted, updatedAt));
                }

                command.Dispose();
            }

            return result;
        }

        public void CreateOrUpdateProduct(string name, float price, int sid)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO products (name, price, sid, deleted, updated_at) VALUES(@name, @price, @sid, FALSE, NOW())";

                command.Parameters.AddWithValue("name", name);
                command.Parameters.AddWithValue("price", price);
                command.Parameters.AddWithValue("sid", sid);

                command.ExecuteNonQuery();

                command.Dispose();
            }
        }

        public void DeleteProduct(Product product)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO products (name, price, sid, deleted, updated_at) VALUES(@name, @price, @sid, TRUE, NOW())";

                command.Parameters.AddWithValue("name", product.Name);
                command.Parameters.AddWithValue("price", product.Price);
                command.Parameters.AddWithValue("sid", product.StockStatusType.SId);

                command.ExecuteNonQuery();

                command.Dispose();
            }
        }

        public Product GetCustomStateProduct(string name, DateTime time)
        {
            Product prod = null;
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT P.pid, P.name, P.price, S.sid, S.name, P.deleted, P.updated_at FROM products as P " +
                    "INNER JOIN(SELECT MAX(updated_at) as time FROM (SELECT * FROM products WHERE updated_at <= @time and name = @productName) X) Y " +
                    "ON Y.time = P.updated_at " +
                    "INNER JOIN stock_status_types as S " +
                    "ON S.sid = P.sid " +
                    "WHERE P.name = @productName";

                command.Parameters.AddWithValue("productName", name);
                command.Parameters.AddWithValue("time", time);

                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var pid = dr.GetInt32(0);
                    var productName = dr.GetString(1);
                    var price = dr.GetFloat(2);
                    var sid = dr.GetInt32(3);
                    var typeName = dr.GetString(4);
                    var deleted = dr.GetBoolean(5);
                    var updatedAt = dr.GetDateTime(6);

                    prod = new Product(pid, productName, price, new StockStatusType(sid, typeName), deleted, updatedAt);
                    break;
                }

                command.Dispose();
            }

            return prod;
        }

        public List<ProductInterval> GetProductsPriceStreak()
        {
            var result = new List<ProductInterval>();
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = @"
WITH partitions as (
SELECT name, price, updated_at,
case
	when lag(price, 1, '-1'::REAL) OVER (PARTITION BY name ORDER BY updated_at) <> price then 1
	else 0
end as start_partition
FROM products
), 
partitions2 as (SELECT *, SUM(start_partition) OVER(PARTITION BY name ORDER BY updated_at) as partition_number FROM partitions),
partitions3 as (SELECT *, first_value(updated_at) OVER(PARTITION BY name, partition_number ORDER BY updated_at) as begin_date, last_value(updated_at) OVER(PARTITION BY name, partition_number ORDER BY updated_at RANGE BETWEEN UNBOUNDED PRECEDING AND UNBOUNDED FOLLOWING) as end_date FROM partitions2),
mins as (SELECT name, min(price) as price from products group by name),
durations as (SELECT DISTINCT P.name, P.price, P.begin_date, P.end_date, P.end_date - P.begin_date as duration from partitions3 P INNER JOIN mins M on M.price = P.price AND M.name = P.name),
durations2 as (SELECT *, MAX(duration) OVER(PARTITION BY name) = duration as keep from durations)
SELECT * FROM durations2 WHERE keep = true
";


                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var name = dr.GetString(0);
                    var price = dr.GetFloat(1);
                    var beginDate = dr.GetDateTime(2);
                    var endDate = dr.GetDateTime(3);
                    var duration = endDate - beginDate;

                    result.Add(new ProductInterval(name, price, beginDate, endDate, duration));
                }

                command.Dispose();
            }

            return result;
        }


        public List<Product> GetProductSimpleHistory(string productName)
        {
            var result = new List<Product>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT pid, name, price, deleted, updated_at FROM products WHERE name=@productName ORDER BY updated_at";

                command.Parameters.AddWithValue("productName", productName);

                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    var pid = dr.GetInt32(0);
                    var name = dr.GetString(1);
                    var price = dr.GetFloat(2);
                    var deleted = dr.GetBoolean(3);
                    var updatedAt = dr.GetDateTime(4);

                    var prod = new Product(pid, name, price, null, deleted, updatedAt);
                    result.Add(prod);
                }

                command.Dispose();
            }

            return result;
        }
        public List<ProductDelta> GetProductDeltaHistory(string productName)
        {
            var result = new List<ProductDelta>();

            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT name, price, price-lag(price, 1, '0'::REAL) OVER(ORDER BY updated_at) as delta_price, updated_at-lag(updated_at, 1, updated_at) OVER(ORDER BY updated_at) as delta_time, updated_at FROM products WHERE name = @productName ORDER BY updated_at  ";

                command.Parameters.AddWithValue("productName", productName);

                NpgsqlDataReader dr = command.ExecuteReader();                
                while (dr.Read())
                {
                    var name = dr.GetString(0);
                    var price = dr.GetFloat(1);
                    var deltaPrice= dr.GetFloat(2);
                    var deltaTime = dr.GetTimeSpan(3);
                    var updatedAt = dr.GetDateTime(4);

                    var prod = new ProductDelta(name, price, updatedAt, deltaTime, deltaPrice);
                    result.Add(prod);
                }

                command.Dispose();
            }

            return result;
        }





    }
}
