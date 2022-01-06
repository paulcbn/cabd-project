using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Models
{
    public class StockStatusType
    {
        public StockStatusType(int sid, string name)
        {
            SId = sid;
            Name = name;
        }

        public int SId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name} ({SId})"; 
        }
    }

    public class Product
    {
        public Product(int pId, string name, float price, StockStatusType stockStatusType, bool deleted, DateTime updatedAt)
        {
            PId = pId;
            Name = name;
            Price = price;
            StockStatusType = stockStatusType;
            Deleted = deleted;
            UpdatedAt = updatedAt;
        }

        public int PId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public StockStatusType StockStatusType { get; set; }

        public bool Deleted { get; set; }
        public DateTime UpdatedAt { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

    }

    public class ProductInterval
    {
        public ProductInterval(string name, float price, DateTime beginDate, DateTime endDate, TimeSpan interval)
        {
            Name = name;
            Price = price;
            BeginDate = beginDate;
            EndDate = endDate;
            Interval = interval;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan Interval { get; set; }
    }

    public class ProductDelta
    {
        public ProductDelta(string name, float price, DateTime updatedAt, TimeSpan deltaTime, float deltaPrice)
        {
            Name = name;
            Price = price;
            UpdatedAt = updatedAt;
            DeltaTime = deltaTime;
            DeltaPrice = deltaPrice;
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public DateTime UpdatedAt { get; set; }
        public TimeSpan DeltaTime { get; set; }
        public float DeltaPrice { get; set; }
    }
}
