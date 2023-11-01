using Projektgrupp4.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels;

public class SignInViewModel
{

    [Display(Name = "EMAIL")]
    [DataType(DataType.EmailAddress)]
    [Required(ErrorMessage = "You must provide an e-mail")]
    public string Email { get; set; } = null!;

    [Display(Name = "PASSWORD")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "You must provide a legit password")]
    public string Password { get; set; } = null!;

    public bool RememberMe { get; set; } = false;

}