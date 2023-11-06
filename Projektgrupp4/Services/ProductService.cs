using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.ViewModels;

namespace Projektgrupp4.Services
{
    public class ProductService
    {
        private readonly DataContext _dataContext;
        private readonly SizeService _sizeService;
       

        public ProductService(DataContext dataContext, SizeService sizeService)
        {
            _dataContext = dataContext;
            _sizeService = sizeService;
        }


        //public async Task<ProductEntity> CreateProductAsync(ProductEntity entity)
        //{
        //    var newProduct = new ProductEntity
        //    {
        //        ProductImage = entity.ProductImage,
        //        ProductTitle = entity.ProductTitle,
        //        ProductPrice = entity.ProductPrice,
        //        ProductOfferPrice = entity.ProductOfferPrice,
        //        ProductPriceOrOffer = entity.ProductPriceOrOffer,
        //        ProductDescription = entity.ProductDescription,
        //    };

        //    _dataContext.Products.Add(newProduct);

        //    await _dataContext.SaveChangesAsync();

        //    return newProduct;
        //}
        public async Task<ProductEntity> CreateProductAsync(ProductEntity entity, string[] categories, string[] colors, string[] sizes)
        {
            var newProduct = new ProductEntity
            {
                ProductImage = entity.ProductImage,
                ProductTitle = entity.ProductTitle,
                ProductPrice = entity.ProductPrice,
                ProductOfferPrice = entity.ProductOfferPrice,
                ProductPriceOrOffer = entity.ProductPriceOrOffer,
                ProductDescription = entity.ProductDescription,
            };

            _dataContext.Products.Add(newProduct);

            await _dataContext.SaveChangesAsync();

            foreach (var categoryId in categories)
            {
                foreach (var colorId in colors)
                {
                    foreach (var sizeId in sizes)
                    {
                        var productItem = new ProductItemEntity
                        {
                            Product = newProduct,
                            SizeId = int.Parse(sizeId),
                            CategoryId = int.Parse(categoryId),
                            ColorId = int.Parse(colorId),
                        };
                        _dataContext.ProductItem.Add(productItem);
                    }
                }
            }

            await _dataContext.SaveChangesAsync();

            return newProduct;
        }




        public async Task<bool> AddProductItemAsync(ProductEntity entity, string[] categories, string[] colors, string[] sizes)
        {
            var product = await _dataContext.Products.FirstOrDefaultAsync(x => x.ArticleNumber == entity.ArticleNumber);

            if (product == null)
            {
                return false;
            }

            foreach (var category in categories)
            {
                foreach (var color in colors)
                {
                    foreach (var size in sizes)
                    {
                        var productItem = new ProductItemEntity
                        {
                            ProductId = product.ArticleNumber,
                            CategoryId = int.Parse(category),
                            ColorId = int.Parse(color),
                            SizeId = int.Parse(size)
                        };

                        await _dataContext.AddAsync(productItem);
                    }
                }
            }

            try
            {
                await _dataContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Handle the exception as needed, e.g., log it
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }



        //}


        //public async Task<ProductItemEntity> AddProductItemAsync(ProductEntity entity, string[] categories, string[] colors, string[] sizes)
        //{
        //    var product = await _dataContext.Products.FirstOrDefaultAsync(x => x.ArticleNumber == entity.ArticleNumber);

        //    if (product == null)
        //    {
        //        return null;
        //    }

        //    ProductItemEntity productItem = null; // Declare productItem here

        //    foreach (var category in categories)
        //    {
        //        foreach (var color in colors)
        //        {
        //            foreach (var size in sizes)
        //            {
        //                int categoryId;
        //                int colorId;
        //                int sizeId;

        //                if (!int.TryParse(category, out categoryId) || !int.TryParse(color, out colorId) || !int.TryParse(size, out sizeId))
        //                {
        //                    // Log invalid category, color, or size IDs
        //                    Console.WriteLine($"Invalid category, color, or size ID: Category={category}, Color={color}, Size={size}");
        //                    continue; // Skip this iteration if there's an invalid ID
        //                }

        //                // Check if the category, color, and size IDs exist in their respective tables
        //                if (await _dataContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == categoryId) == null ||
        //                    await _dataContext.Colors.FirstOrDefaultAsync(c => c.ColorId == colorId) == null ||
        //                    await _dataContext.Sizes.FirstOrDefaultAsync(s => s.SizeId == sizeId) == null)
        //                {
        //                    // Log the case where an ID doesn't exist in the respective table
        //                    Console.WriteLine($"ID doesn't exist in the database: CategoryID={categoryId}, ColorID={colorId}, SizeID={sizeId}");
        //                    continue; // Skip this iteration if there's a missing ID
        //                }

        //                productItem = new ProductItemEntity
        //                {
        //                    ProductId = product.ArticleNumber,
        //                    CategoryId = categoryId,
        //                    ColorId = colorId,
        //                    SizeId = sizeId
        //                };

        //                await _dataContext.AddAsync(productItem);
        //            }
        //        }
        //    }

        //    try
        //    {
        //        // Save the changes to the database
        //        await _dataContext.SaveChangesAsync();
        //        return productItem; // Return the added ProductItemEntity
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle the exception as needed, e.g., log it
        //        Console.WriteLine("Error: " + ex.Message);
        //        return null;
        //    }
        //}







        public bool DeleteProduct(int articleNumber)
        {
            var productToDelete = _dataContext.Products.FirstOrDefault(x => x.ArticleNumber == articleNumber);

            if (productToDelete != null)
            {
                _dataContext.Products.Remove(productToDelete);
                _dataContext.SaveChanges();
                return true;
            }

            return false;
        }

    }
}
