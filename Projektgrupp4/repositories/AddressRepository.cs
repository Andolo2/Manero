using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Uppgift.Helpers.Repositories;

namespace Projektgrupp4.Repositories
{
    public class AddressRepository : Repo<AddressEntity>
    {
        private readonly DataContext _context;
        
        public AddressRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<AddressEntity>> GetAllAsync()
        {
            return await _context.Adresses.ToListAsync();
        }
    }

   
}
