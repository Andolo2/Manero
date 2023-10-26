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

        // Products
        public DbSet<ProductEntity> Product { get; set; }


    }
}
