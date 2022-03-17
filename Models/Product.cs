using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThiWAD.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int QuantityPerUnit { get; set; }
        public int SupplierID { get; set; }
        public double UnitPrice { get; set; }
        public string UnitslnStock { get; set; }
        public string UnitOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
        public virtual Category category { get; set; }
    }
}