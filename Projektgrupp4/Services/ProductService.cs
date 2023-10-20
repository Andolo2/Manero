using Microsoft.EntityFrameworkCore;
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

        public async Task<bool> CreateAsync(ProductRegistrationViewModel productRegistrationViewModel)
        {
            try
            {
                ProductEntity productEntity = productRegistrationViewModel;

                _dataContext.Products.Add(productEntity);
                await _dataContext.SaveChangesAsync();
                return true;


            }
            catch
            {
                return false;
            }
        }
    }
}
