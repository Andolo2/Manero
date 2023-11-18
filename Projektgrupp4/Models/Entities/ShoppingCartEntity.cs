using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projektgrupp4.Models.Entities;

[PrimaryKey(nameof(UserId), nameof(ProductId))]
public class ShoppingCartEntity
{
    [Required]
    [ForeignKey("ShoppingCartUser")]
    public string UserId { get; set; } = null!;

    [Required]
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public UserEntity ShoppingCartUser { get; set; } = null!;

    public ProductEntity Product { get; set; } = null!;

}
