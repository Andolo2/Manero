using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class ReviewEntity
{
    [Key]
    public int ReviewId { get; set; }
    public string Name { get; set; } = null!;
    public DateTime Created { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; } = null!;
    public int ProductId { get; set; }
    public ProductEntity Product { get; set; } = null!;
}
