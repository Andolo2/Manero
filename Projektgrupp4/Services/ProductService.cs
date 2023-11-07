using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models;
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
