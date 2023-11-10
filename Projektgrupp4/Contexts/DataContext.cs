
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Contexts
{
    public class DataContext : IdentityDbContext<UserEntity>
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }



        // Users
        public DbSet<AddressEntity> Adresses { get; set; } = null!;

        public DbSet<ProductEntity> ShoppingCart { get; set; } = null!;
        

        // Products
        public DbSet<ProductEntity> Products { get; set; } = null!;
        public DbSet<ProductItemEntity> ProductItem { get; set; } = null!;
        public DbSet<ColorEntity> Colors { get; set; } = null!;
        public DbSet<SizeEntity> Sizes { get; set; } = null!;
        public DbSet<CategoryEntity> Categories { get; set; } = null!;
        public DbSet<ReviewEntity> Reviews { get; set; } = null!;
        public DbSet<ProductCategoriesEntity> ProductCategories { get; set; } = null!;

       
    
       

     }

}
