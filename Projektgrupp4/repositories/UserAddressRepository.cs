using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;

namespace Uppgift.Helpers.Repositories;

public class UserAddressRepository : Repo<UserAddressEntity>
{
    public UserAddressRepository(DataContext context) : base(context)
    {
    }
}
