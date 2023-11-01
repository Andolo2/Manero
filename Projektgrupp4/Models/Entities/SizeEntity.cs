using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class SizeEntity
{
    [Key]
    public int SizeId { get; set; }

    [Required]
    public string SizeName { get; set; } = null!;

}
