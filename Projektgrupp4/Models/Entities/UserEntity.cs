using Microsoft.AspNetCore.Identity;

using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class UserEntity : IdentityUser
{
    [Key]
    public Guid Id { get; set; }

    public string UserName { get; set; } = null!;
    public string UserEmail { get; set; } = null!;

    public PasswordEntity UserPassword { get; set; }

    public ICollection<AddressEntity> UserAddress { get; set; } = new HashSet<AddressEntity>();
}
