using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class UserEntity : IdentityUser
{
    [Required]
    [MaxLength(256)]
    public string Name { get; set; } = null!;

    public ShoppingCartEntity? ShoppingCart { get; set; }

    public ICollection<AddressEntity> UserAddress { get; set; } = new HashSet<AddressEntity>();
}