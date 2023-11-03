using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities
{
    public class ProductColorEntity
    {
        [Key]
        public int ProductColorRowId { get; set; }

        public int ColorId { get; set; }
        public ColorEntity Color { get; set; } = null!;

        public int ProductId { get; set; }
        public ProductEntity Product { get; set; } = null!;



    }
}
