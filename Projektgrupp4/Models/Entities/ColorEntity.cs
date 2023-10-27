using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class ColorEntity
{
    [Key]
    public int ColorId { get; set; }
    public string ColorName { get; set; } = null!;
}
