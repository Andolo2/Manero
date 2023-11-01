using Projektgrupp4.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels;

public class SignUpViewModel
{
    [Display(Name = "NAME")]
    [Required(ErrorMessage ="You must provide a name")]
    public string Name { get; set; } = null!;

    [Display (Name = "EMAIL")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "You must provide an e-mail")]
    public string Email { get; set; } = null!;

    [Display (Name = "PASSWORD")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "You must provide a legit password")]
    public string Password { get; set; } = null!;

    [Display (Name = "CONFIRM PASSWORD")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    [Required(ErrorMessage = "You must confirm your password")]
    public string ConfirmPassword { get; set; } = null!;


    public static implicit operator UserEntity(SignUpViewModel model)
    {
        return new UserEntity
        {
            Name = model.Name,
            Email = model.Email,
            UserName = model.Email
        };
    }
}
