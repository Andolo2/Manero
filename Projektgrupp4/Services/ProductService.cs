using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Services
{
    public class ProductService
    {
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

      

        public bool CreateProduct(ProductEntity product)
        {
            try
            {
                _dataContext.Products.Add(product);
                _dataContext.SaveChanges();
                return true;
            }
            catch
            {
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

    }
}
