using BazarMarket.Domein.Entity.Products;
using BazarMarket.Domein.Entity.Workers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazarMarket.DataAcces.BazarMarketDBContexts
{
    public class AppDBContext : DbContext
    {
        public DbSet<UncountableProducts> uncountables { get; set; }

        public DbSet<СountableProducts> countables { get; set; }

        public DbSet<Manager> managers { get; set; }

        public DbSet<SalesManager> salesManager { get; set; }

        public DbSet<Salesman> salesmens { get; set; }

        public DbSet<ProductsSorter> productsSorter { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server = localhost; Username = postgres; Port = 5432; Password = bekzod28072009; Database = BazarMarket");
        }
    }
}
