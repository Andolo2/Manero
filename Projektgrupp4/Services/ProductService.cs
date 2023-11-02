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



        //public bool CreateProduct(ProductEntity product)
        //{
        //    try
        //    {
        //        _dataContext.Products.Add(product);
        //        _dataContext.SaveChanges();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}



        //public async Task<bool> CreateProductAsync(BackofficeProductViewModel productViewModel)
        //{

        //}


            //public async Task AddProductItemAsync(ProductEntity entity, string[] categories, string[] colors, string[] sizes,)
            //{
            //    foreach (var category in categories)
            //    {
            //        await _dataContext.AddAsync(new ProductItemEntity
            //        {
            //            ArticleNumber = entity.ArticleNumber,
            //            CategoryId = int.Parse(tag),

            //        });
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
