using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.ViewModels;

public class ShoppingCartViewModel
{
    public ICollection<ProductEntity>? Products { get; set; }
    public bool PromocodeApplied { get; set; }
    public int Subtotal { get; set; }
    public int Discount { get; set; }
    public string DeliveryPrice { get; set; } = null!;
    public int Total { get; set; }
}
