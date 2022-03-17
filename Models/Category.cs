using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThiWAD.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CateName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public virtual IEnumerable<Product> products { get; set; }
        public string CategoryName { get; internal set; }
    }
}