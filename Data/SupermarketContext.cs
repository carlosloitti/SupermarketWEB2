using SupermarketWEB2.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SupermarketWEB2.Data
{
    public class SupermarketContext : DbContext
    {
        public SupermarketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<PayMode> PayModes { get; set; }

        public DbSet<Provider> Providers { get; set; }

    }
}
