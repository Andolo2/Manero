using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels
{
    public class ProfileEditViewModel
    {
        [Display(Name = "NAME")]
        public string Name { get; set; } = null!;

        [Display (Name = "EMAIL")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [Display (Name = "PHONENUMBER")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = null!;

        [Display (Name = "LOCATION")]
        public string Location { get; set; } = null!;
       
    }
}
