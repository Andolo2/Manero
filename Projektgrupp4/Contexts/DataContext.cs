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
        public DbSet<ProductEntity> Products { get; set; } = null!;
        public DbSet<ProductItemEntity> ProductItem { get; set; } = null!;
        public DbSet<ColorEntity> Colors { get; set; } = null!;
        public DbSet<SizeEntity> Sizes { get; set; } = null!;
        public DbSet<CategoryEntity> Categories { get; set; } = null!;
        public DbSet<ReviewEntity> Reviews { get; set; } = null!;
        public DbSet<ProductCategoriesEntity> ProductCategories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SizeEntity>().HasData(
                new SizeEntity { SizeId = 1, SizeName = "XS" },
                new SizeEntity { SizeId = 2, SizeName = "S" },
                new SizeEntity { SizeId = 3, SizeName = "M" },
                new SizeEntity { SizeId = 4, SizeName = "L" },
                new SizeEntity { SizeId = 5, SizeName = "XL" },
                new SizeEntity { SizeId = 6, SizeName = "XXL" });

            modelBuilder.Entity<ColorEntity>().HasData(
                new ColorEntity { ColorId = 1, ColorName = "White"},
                new ColorEntity { ColorId = 2, ColorName = "Black" },
                new ColorEntity { ColorId = 3, ColorName = "Red" },
                new ColorEntity { ColorId = 4, ColorName = "Green" },
                new ColorEntity { ColorId = 5, ColorName = "Blue" },
                new ColorEntity { ColorId = 6, ColorName = "Beige" },
                new ColorEntity { ColorId = 7, ColorName = "LightBlue" },
                new ColorEntity { ColorId = 8, ColorName = "DarkBlue" },
                new ColorEntity { ColorId = 9, ColorName = "Orange" },
                new ColorEntity { ColorId = 10, ColorName = "Yellow" }
            );


            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = 1, CategoryName = "Men" },
                new CategoryEntity { CategoryId = 2, CategoryName = "Women" },
                new CategoryEntity { CategoryId = 3, CategoryName = "Kids" },
                new CategoryEntity { CategoryId = 4, CategoryName = "Accessories" },
                new CategoryEntity { CategoryId = 5, CategoryName = "Shoes" },
                new CategoryEntity { CategoryId = 6, CategoryName = "Dresses" },
                new CategoryEntity { CategoryId = 7, CategoryName = "Pants" },
                new CategoryEntity { CategoryId = 8, CategoryName = "Bestsellers" },
                new CategoryEntity { CategoryId = 9, CategoryName = "Featured" }
            );

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    ArticleNumber = 1,
                    ProductImageUrl = "#",
                    ProductTitle = "Black sneakers",
                    ProductPrice = 29.80M,
                    ProductOfferPrice = 0,
                    ProductPriceOrOffer = false,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                                         "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                                         "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },
                new ProductEntity
                {
                ArticleNumber = 2,
                ProductImageUrl = "#",
                ProductTitle = "Summer dress",
                ProductPrice = 36.00M,
                ProductOfferPrice = 15.98M,
                ProductPriceOrOffer = true,
                ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                        "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                        "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },

                new ProductEntity
                {
                    ArticleNumber = 3,
                    ProductImageUrl = "#",
                    ProductTitle = "Shoulder bag",
                    ProductPrice = 38.00M,
                    ProductOfferPrice = 30.00M,
                    ProductPriceOrOffer = true,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                        "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                        "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },

                new ProductEntity
                {
                    ArticleNumber = 4,
                    ProductImageUrl = "#",
                    ProductTitle = "Denim shorts",
                    ProductPrice = 54.96M,
                    ProductOfferPrice = 0,
                    ProductPriceOrOffer = false,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                    "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                    "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },

                new ProductEntity
                {
                    ArticleNumber = 5,
                    ProductImageUrl = "#",
                    ProductTitle = "Summer pants",
                    ProductPrice = 31.78M,
                    ProductOfferPrice = 0,
                    ProductPriceOrOffer = false,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                        "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                        "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },


                new ProductEntity
                {
                    ArticleNumber = 6,
                    ProductImageUrl = "#",
                    ProductTitle = "Warm hat",
                    ProductPrice = 6.93M,
                    ProductOfferPrice = 0,
                    ProductPriceOrOffer = false,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                        "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                        "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },

                new ProductEntity
                {
                    ArticleNumber = 7,
                    ProductImageUrl = "#",
                    ProductTitle = "Hand bag",
                    ProductPrice = 24.95M,
                    ProductOfferPrice = 0,
                    ProductPriceOrOffer = false,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                        "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                        "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },

                new ProductEntity
                {
                    ArticleNumber = 8,
                    ProductImageUrl = "#",
                    ProductTitle = "T-shirt",
                    ProductPrice = 12.95M,
                    ProductOfferPrice = 0,
                    ProductPriceOrOffer = false,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                        "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                        "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },

                new ProductEntity
                {
                    ArticleNumber = 9,
                    ProductImageUrl = "#",
                    ProductTitle = "Purple sneakers",
                    ProductPrice = 22.87M,
                    ProductOfferPrice = 0,
                    ProductPriceOrOffer = false,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                        "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                        "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                },

                new ProductEntity
                {
                    ArticleNumber = 10,
                    ProductImageUrl = "#",
                    ProductTitle = "Denim shorts",
                    ProductPrice = 54.96M,
                    ProductOfferPrice = 0,
                    ProductPriceOrOffer = false,
                    ProductDescription = "Amet amet Lorem eu consectetur in deserunt nostrud dolor culpa ad sint amet. " +
                        "Nostrud deserunt consectetur culpa minim mollit veniam aliquip pariatur exercitation " +
                        "ullamco ea voluptate et. Pariatur ipsum mollit magna proident nisi ipsum.",
                }
            );
        }
    
       

     }

}
