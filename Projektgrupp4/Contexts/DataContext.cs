using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // Users
        public DbSet<AddressEntity> Adresses { get; set; } = null!;
        public DbSet<UserEntity> Users { get; set; }

        // Products
        public DbSet<ProductEntity> Product { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity {
                    ArticleNumber = 1, ProductTitle = "T-shirt",
                    ProductPrice = 399,
                    ProductOfferPrice = 150,
                    ProductPriceOrOffer = true,
                    ProductDescription = "This is a T-shirt",
                    ProductColor = Enum.Color.Green,
                    ProductLabel = Enum.Label.Sport,
                    ProductSize = Enum.Size.m },
                new ProductEntity
                {
                    ArticleNumber = 2,
                    ProductTitle = "Jeans",
                    ProductPrice = 399,
                    ProductOfferPrice = 150,
                    ProductPriceOrOffer = true,
                    ProductDescription = "This is a pair of jeans",
                    ProductColor = Enum.Color.Blue,
                    ProductLabel = Enum.Label.Pants,
                    ProductSize = Enum.Size.l
                }
                );
        }
    }
}
