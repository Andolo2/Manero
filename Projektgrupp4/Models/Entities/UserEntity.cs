using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projektgrupp4.Models.Entities;

public class UserEntity : IdentityUser
{
    [Required]
    [MaxLength(256)]
    public string Name { get; set; } = null!;

    [ForeignKey("ShoppingCartId")]
    public ShoppingCartEntity ShoppingCart { get; set; } = null!;
    public ICollection<AddressEntity> UserAddress { get; set; } = new HashSet<AddressEntity>();
}