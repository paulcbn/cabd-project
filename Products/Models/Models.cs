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
}
