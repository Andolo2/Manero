using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.Contexts
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString = @"Server=tcp:grupp4-sqlserver.database.windows.net,1433;Initial Catalog=database-1;Persist Security Info=False;User ID=SqlAdmin;Password={Bytmig123!};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AddressEntity> Adresses { get; set; } = null!;
    }
}
