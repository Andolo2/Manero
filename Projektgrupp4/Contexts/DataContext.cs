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
                new SizeEntity { SizeId = 6, SizeName = "XXL" },
                new SizeEntity { SizeId = 7, SizeName = "37"},
                new SizeEntity { SizeId = 8, SizeName = "38" },
                new SizeEntity { SizeId = 9, SizeName = "39" },
                new SizeEntity { SizeId = 10, SizeName = "40" },
                new SizeEntity { SizeId = 11, SizeName = "41" },
                new SizeEntity { SizeId = 12, SizeName = "42" },
                new SizeEntity { SizeId = 13, SizeName = "43" },
                new SizeEntity { SizeId = 14, SizeName = "44" }
                );

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
                new ColorEntity { ColorId = 10, ColorName = "Yellow" },
                new ColorEntity { ColorId = 11, ColorName = "Purple" }
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

            modelBuilder.Entity<ProductItemEntity>().HasData(
                //Product "Black Shoes"
                new ProductItemEntity { ProductEntryId = 1, ProductId = 1, SizeId = 7, ColorId = 2},
                new ProductItemEntity { ProductEntryId = 2, ProductId = 1, SizeId = 8, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 3, ProductId = 1, SizeId = 9, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 4, ProductId = 1, SizeId = 10, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 5, ProductId = 1, SizeId = 11, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 6, ProductId = 1, SizeId = 12, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 7, ProductId = 1, SizeId = 13, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 8, ProductId = 1, SizeId = 14, ColorId = 2 },

                //Product "Summer Dress" White
                new ProductItemEntity { ProductEntryId = 9, ProductId = 2, SizeId = 1, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 10, ProductId = 2, SizeId = 2, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 11, ProductId = 2, SizeId = 3, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 12, ProductId = 2, SizeId = 4, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 13, ProductId = 2, SizeId = 5, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 14, ProductId = 2, SizeId = 6, ColorId = 1 },

                //Product "Summer Dress" Beige
                new ProductItemEntity { ProductEntryId = 15, ProductId = 2, SizeId = 1, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 16, ProductId = 2, SizeId = 2, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 17, ProductId = 2, SizeId = 3, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 18, ProductId = 2, SizeId = 4, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 19, ProductId = 2, SizeId = 5, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 20, ProductId = 2, SizeId = 6, ColorId = 6 },

                //Product "Summer Dress" LightBlue
                new ProductItemEntity { ProductEntryId = 21, ProductId = 2, SizeId = 1, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 22, ProductId = 2, SizeId = 2, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 23, ProductId = 2, SizeId = 3, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 24, ProductId = 2, SizeId = 4, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 25, ProductId = 2, SizeId = 5, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 26, ProductId = 2, SizeId = 6, ColorId = 7 },

                //Product "Summer Dress" Yellow
                new ProductItemEntity { ProductEntryId = 27, ProductId = 2, SizeId = 1, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 28, ProductId = 2, SizeId = 2, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 29, ProductId = 2, SizeId = 3, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 30, ProductId = 2, SizeId = 4, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 31, ProductId = 2, SizeId = 5, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 32, ProductId = 2, SizeId = 6, ColorId = 10 },

                //Product "Denim Shorts" LightBlue
                new ProductItemEntity { ProductEntryId = 33, ProductId = 4, SizeId = 1, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 34, ProductId = 4, SizeId = 2, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 35, ProductId = 4, SizeId = 3, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 36, ProductId = 4, SizeId = 4, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 37, ProductId = 4, SizeId = 5, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 38, ProductId = 4, SizeId = 6, ColorId = 7 },

                //Product "Denim Shorts" Darkblue
                new ProductItemEntity { ProductEntryId = 39, ProductId = 4, SizeId = 1, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 40, ProductId = 4, SizeId = 2, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 41, ProductId = 4, SizeId = 3, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 42, ProductId = 4, SizeId = 4, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 43, ProductId = 4, SizeId = 5, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 44, ProductId = 4, SizeId = 6, ColorId = 8 },

                //Product "Denim Shorts" Black
                new ProductItemEntity { ProductEntryId = 45, ProductId = 4, SizeId = 1, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 46, ProductId = 4, SizeId = 2, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 47, ProductId = 4, SizeId = 3, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 48, ProductId = 4, SizeId = 4, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 49, ProductId = 4, SizeId = 5, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 50, ProductId = 4, SizeId = 6, ColorId = 2 },

                //Product "Denim Shorts" Blue
                new ProductItemEntity { ProductEntryId = 51, ProductId = 4, SizeId = 1, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 52, ProductId = 4, SizeId = 2, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 53, ProductId = 4, SizeId = 3, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 54, ProductId = 4, SizeId = 4, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 55, ProductId = 4, SizeId = 5, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 56, ProductId = 4, SizeId = 6, ColorId = 5 },

                //Product "Summer Pants" LightBlue
                new ProductItemEntity { ProductEntryId = 57, ProductId = 5, SizeId = 1, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 58, ProductId = 5, SizeId = 2, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 59, ProductId = 5, SizeId = 3, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 60, ProductId = 5, SizeId = 4, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 61, ProductId = 5, SizeId = 5, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 62, ProductId = 5, SizeId = 6, ColorId = 7 },

                //Product "Summer Pants" White
                new ProductItemEntity { ProductEntryId = 63, ProductId = 5, SizeId = 1, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 64, ProductId = 5, SizeId = 2, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 65, ProductId = 5, SizeId = 3, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 66, ProductId = 5, SizeId = 4, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 67, ProductId = 5, SizeId = 5, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 68, ProductId = 5, SizeId = 6, ColorId = 1 },

                //Product "Summer Pants" Beige
                new ProductItemEntity { ProductEntryId = 69, ProductId = 5, SizeId = 1, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 70, ProductId = 5, SizeId = 2, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 71, ProductId = 5, SizeId = 3, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 72, ProductId = 5, SizeId = 4, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 73, ProductId = 5, SizeId = 5, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 74, ProductId = 5, SizeId = 6, ColorId = 6 },

                //Product "T-Shirt" White
                new ProductItemEntity { ProductEntryId = 75, ProductId = 8, SizeId = 1, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 76, ProductId = 8, SizeId = 2, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 77, ProductId = 8, SizeId = 3, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 78, ProductId = 8, SizeId = 4, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 79, ProductId = 8, SizeId = 5, ColorId = 1 },
                new ProductItemEntity { ProductEntryId = 80, ProductId = 8, SizeId = 6, ColorId = 1 },

                //Product "T-Shirt" Black
                new ProductItemEntity { ProductEntryId = 81, ProductId = 8, SizeId = 1, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 82, ProductId = 8, SizeId = 2, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 83, ProductId = 8, SizeId = 3, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 84, ProductId = 8, SizeId = 4, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 85, ProductId = 8, SizeId = 5, ColorId = 2 },
                new ProductItemEntity { ProductEntryId = 86, ProductId = 8, SizeId = 6, ColorId = 2 },

                //Product "T-Shirt" Red
                new ProductItemEntity { ProductEntryId = 87, ProductId = 8, SizeId = 1, ColorId = 3 },
                new ProductItemEntity { ProductEntryId = 88, ProductId = 8, SizeId = 2, ColorId = 3 },
                new ProductItemEntity { ProductEntryId = 89, ProductId = 8, SizeId = 3, ColorId = 3 },
                new ProductItemEntity { ProductEntryId = 90, ProductId = 8, SizeId = 4, ColorId = 3 },
                new ProductItemEntity { ProductEntryId = 91, ProductId = 8, SizeId = 5, ColorId = 3 },
                new ProductItemEntity { ProductEntryId = 92, ProductId = 8, SizeId = 6, ColorId = 3 },

                //Product "T-Shirt" Green
                new ProductItemEntity { ProductEntryId = 93, ProductId = 8, SizeId = 1, ColorId = 4 },
                new ProductItemEntity { ProductEntryId = 94, ProductId = 8, SizeId = 2, ColorId = 4 },
                new ProductItemEntity { ProductEntryId = 95, ProductId = 8, SizeId = 3, ColorId = 4 },
                new ProductItemEntity { ProductEntryId = 96, ProductId = 8, SizeId = 4, ColorId = 4 },
                new ProductItemEntity { ProductEntryId = 97, ProductId = 8, SizeId = 5, ColorId = 4 },
                new ProductItemEntity { ProductEntryId = 98, ProductId = 8, SizeId = 6, ColorId = 4 },

                //Product "T-Shirt" Blue
                new ProductItemEntity { ProductEntryId = 99, ProductId = 8, SizeId = 1, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 100, ProductId = 8, SizeId = 2, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 101, ProductId = 8, SizeId = 3, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 102, ProductId = 8, SizeId = 4, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 103, ProductId = 8, SizeId = 5, ColorId = 5 },
                new ProductItemEntity { ProductEntryId = 104, ProductId = 8, SizeId = 6, ColorId = 5 },

                //Product "T-Shirt" Beige
                new ProductItemEntity { ProductEntryId = 105, ProductId = 8, SizeId = 1, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 106, ProductId = 8, SizeId = 2, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 107, ProductId = 8, SizeId = 3, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 108, ProductId = 8, SizeId = 4, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 109, ProductId = 8, SizeId = 5, ColorId = 6 },
                new ProductItemEntity { ProductEntryId = 110, ProductId = 8, SizeId = 6, ColorId = 6 },

                //Product "T-Shirt" LightBlue
                new ProductItemEntity { ProductEntryId = 111, ProductId = 8, SizeId = 1, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 112, ProductId = 8, SizeId = 2, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 113, ProductId = 8, SizeId = 3, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 114, ProductId = 8, SizeId = 4, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 115, ProductId = 8, SizeId = 5, ColorId = 7 },
                new ProductItemEntity { ProductEntryId = 116, ProductId = 8, SizeId = 6, ColorId = 7 },

                //Product "T-Shirt" DarkBlue
                new ProductItemEntity { ProductEntryId = 117, ProductId = 8, SizeId = 1, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 118, ProductId = 8, SizeId = 2, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 119, ProductId = 8, SizeId = 3, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 120, ProductId = 8, SizeId = 4, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 121, ProductId = 8, SizeId = 5, ColorId = 8 },
                new ProductItemEntity { ProductEntryId = 122, ProductId = 8, SizeId = 6, ColorId = 8 },

                //Product "T-Shirt" Orange
                new ProductItemEntity { ProductEntryId = 123, ProductId = 8, SizeId = 1, ColorId = 9 },
                new ProductItemEntity { ProductEntryId = 124, ProductId = 8, SizeId = 2, ColorId = 9 },
                new ProductItemEntity { ProductEntryId = 125, ProductId = 8, SizeId = 3, ColorId = 9 },
                new ProductItemEntity { ProductEntryId = 126, ProductId = 8, SizeId = 4, ColorId = 9 },
                new ProductItemEntity { ProductEntryId = 127, ProductId = 8, SizeId = 5, ColorId = 9 },
                new ProductItemEntity { ProductEntryId = 128, ProductId = 8, SizeId = 6, ColorId = 9 },

                //Product "T-Shirt" Yellow
                new ProductItemEntity { ProductEntryId = 129, ProductId = 8, SizeId = 1, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 130, ProductId = 8, SizeId = 2, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 131, ProductId = 8, SizeId = 3, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 132, ProductId = 8, SizeId = 4, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 133, ProductId = 8, SizeId = 5, ColorId = 10 },
                new ProductItemEntity { ProductEntryId = 134, ProductId = 8, SizeId = 6, ColorId = 10 },

                //Product "T-Shirt" Purple
                new ProductItemEntity { ProductEntryId = 135, ProductId = 8, SizeId = 1, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 136, ProductId = 8, SizeId = 2, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 137, ProductId = 8, SizeId = 3, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 138, ProductId = 8, SizeId = 4, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 139, ProductId = 8, SizeId = 5, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 140, ProductId = 8, SizeId = 6, ColorId = 11 },

                //Product "Purple Sneakers"
                new ProductItemEntity { ProductEntryId = 141, ProductId = 9, SizeId = 7, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 142, ProductId = 9, SizeId = 8, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 143, ProductId = 9, SizeId = 9, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 144, ProductId = 9, SizeId = 10, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 145, ProductId = 9, SizeId = 11, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 146, ProductId = 9, SizeId = 12, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 147, ProductId = 9, SizeId = 13, ColorId = 11 },
                new ProductItemEntity { ProductEntryId = 148, ProductId = 9, SizeId = 14, ColorId = 11 }

                );

        }
    
       

     }

}
