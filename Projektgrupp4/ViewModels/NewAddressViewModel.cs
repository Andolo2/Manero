using Projektgrupp4.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels;

public class NewAddressViewModel
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string Title { get; set; } = null!;
    public string StreetName { get; set; } = null!;

    public bool Checked { get; set; } = false;

    public static implicit operator AddressEntity(NewAddressViewModel model)
    {
        return new AddressEntity
        {
            Title = model.Title,
            StreetName = model.StreetName
        };
    }
}
