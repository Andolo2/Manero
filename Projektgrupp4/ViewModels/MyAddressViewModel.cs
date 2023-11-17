using Projektgrupp4.Models.Entities;

namespace Projektgrupp4.ViewModels
{
    public class MyAddressViewModel
    {
        public string Title { get; set; } = null!;

        public string StreetName { get; set; } = null!;

        public static implicit operator AddressEntity(MyAddressViewModel model)
        {
            return new AddressEntity
            {
                Title = model.Title,
                StreetName = model.StreetName
            };
        }


    }
}
