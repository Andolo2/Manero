using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities
{
    public class ProductCategoryEntity
    {
        [Key]
        public int Id { get; set; }

        public string CategoryName { get; set; } = null!;

       // public ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>(); Lägg till den här när produktTabellen är inlagd

    }
}
