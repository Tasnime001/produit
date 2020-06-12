using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Data
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=machaine")
        {

        }
        //les dbsets
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Produit> Produits { get; set; }
        public DbSet<Publicité> Publicités  { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //config + conventions
            //modelBuilder.Configurations.Add(...);
            //modelBuilder.Conventions.Add(...);
        }
    }
}
