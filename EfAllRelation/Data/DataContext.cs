using EfAllRelation.Models;
using Microsoft.EntityFrameworkCore;

namespace EfAllRelation.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SqlExpress; Database=TestXX; Trusted_Connection=True; TrustServerCertificate=True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ProductDetails>  ProductDetails { get; set; }
        public DbSet<Component> Components { get; set; }
    }
}
