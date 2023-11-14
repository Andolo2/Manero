using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projektgrupp4.Models.Entities;

public class ShoppingCartEntity
{
    [Key]
    [ForeignKey("UserId")]
    public int UserId { get; set; }
    public UserEntity ShoppingCartUser { get; set; } = null!;

    public ICollection<ProductEntity> ShoppingCartProducts { get; set; } = new HashSet<ProductEntity>();

}
