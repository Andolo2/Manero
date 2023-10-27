using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Repositories
{
    public class ProductRepository : Repo<ProductEntity>
    {

        private readonly DataContext _context;

        public ProductRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
