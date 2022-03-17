using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ThiWAD.Models;

namespace ThiWAD.Data
{
    public class MyDbConText : DbContext
    {
        public MyDbConText() : base("ConnectionString")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
