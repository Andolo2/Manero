using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Services
{
    public class ProductService
    {
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext, SizeService sizeService)
        {
            _dataContext = dataContext;
            sizeService = sizeService;
        }



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

        public async Task<List<ProductEntity>> GetAllProductsAsync()
        {
            var products = await _dataContext.Products.ToListAsync();
            if(products != null)
            {
                return products;
            }

            return null!;
        }

        public async Task<ProductEntity> GetProductAsync(int ArticleNumber)
        {
            var product = await _dataContext.Products.Include(x => x.ProductEntries).ThenInclude(x => x.Size).Include(x => x.ProductEntries).ThenInclude(x => x.Color).Include(x => x.ProductReviews).FirstOrDefaultAsync(x => x.ArticleNumber == ArticleNumber);
            if(product != null)
            {
                return product;
            }

            return null!;
        }

    }
}
