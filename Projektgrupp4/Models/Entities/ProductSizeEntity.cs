using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities
{
    public class ProductSizeEntity
    {
        [Key]
        public int ProductSizeRowId { get; set; }

        public int SizeId { get; set; }
        public SizeEntity Size { get; set; } = null!;

        public int ProductId { get; set; }
        public ProductEntity Product { get; set; } = null!;
    }
}
