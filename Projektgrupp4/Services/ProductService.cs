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





        //public async Task AddProductItemAsync(ProductEntity entity, string[] categories, string[] colors, string[] sizes)
        //{
        //    foreach (var category in categories)
        //    {
        //        foreach (var color in colors)
        //        {
        //            foreach (var size in sizes)
        //            {
        //                await _dataContext.AddAsync(new ProductItemEntity
        //                {
        //                    ArticleNumber = entity.ArticleNumber,
        //                    CategoryId = int.Parse(category),
        //                    ColorId = int.Parse(color),
        //                    SizeId = int.Parse(size)
        //                });
        //            }
        //        }
        //    }


        //}


        public async Task<bool> AddProductItemAsync(ProductEntity entity, string[] categories, string[] colors, string[] sizes)
        {
            foreach (var category in categories)
            {
                foreach (var color in colors)
                {
                    foreach (var size in sizes)
                    {
                        await _dataContext.AddAsync(new ProductItemEntity
                        {
                            ArticleNumber = entity.ArticleNumber,
                            CategoryId = int.Parse(category),
                            ColorId = int.Parse(color),
                            SizeId = int.Parse(size)
                        });
                    }
                }
            }

            try
            {
                // Save the changes to the database
                await _dataContext.SaveChangesAsync();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }





        public async Task<ProductEntity> CreateProductAsync(ProductEntity entity)
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

            return newProduct;
        }



        //    public bool DeleteProduct(int articleNumber)
        //{
        //    var productToDelete = _dataContext.Products.FirstOrDefault(x => x.ArticleNumber == articleNumber);

        //    if (productToDelete != null)
        //    {
        //        _dataContext.Products.Remove(productToDelete);
        //        _dataContext.SaveChanges();
        //        return true;
        //    }

        //    return false;
        //}

    }
    }
