using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Entities.Concrete;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test.DataAccess.Concrete
{
    public class TestContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=DESKTOP-4M0OQRD\SQLEXPRESS;Database=TestProductNtier;User Id=pixxaer;Password=453885;Encrypt=false;TrustServerCertificate=true;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
