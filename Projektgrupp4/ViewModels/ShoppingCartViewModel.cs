using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.ViewModels;

public class ShoppingCartViewModel
{
    public ICollection<ProductEntity>? Products { get; set; }
    public bool PromocodeApplied { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Discount { get; set; }
    public string DeliveryPrice { get; set; } = null!;
    public decimal Total { get; set; }
}
