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
        private string connStr = "Server=localhost;Port=5455;Database=rvbd2176;User Id=rvbd2176;Password=rvbd2176";
        
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
                    var updatedAt= dr.GetDateTime(4);
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
                while(dr.Read())
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

        void debug()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connStr))
            {
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from produse";

                NpgsqlDataReader dr = command.ExecuteReader();
              
                command.Dispose();
            }
        }


    }
}
