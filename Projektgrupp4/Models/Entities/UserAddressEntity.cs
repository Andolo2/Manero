using Microsoft.EntityFrameworkCore;

namespace Projektgrupp4.Models.Entities;

[PrimaryKey(nameof(UserId), nameof(AddressId))]
public class UserAddressEntity
{
    public Guid UserId { get; set; }
    public UserEntity User { get; set; } = null!;
    public Guid AddressId { get; set; }
    public AddressEntity Address { get; set; } = null!;
}
