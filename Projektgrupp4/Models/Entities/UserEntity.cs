using Microsoft.AspNetCore.Identity;
using Projektgrupp4.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projektgrupp4.Models.Entities;

public class UserEntity : IdentityUser
{
    [Required]
    [MaxLength(256)]
    public string Name { get; set; } = null!;

//    public PasswordEntity Password { get; set; } = null!;

    public ICollection<AddressEntity> UserAddress { get; set; } = new HashSet<AddressEntity>();
//    public ICollection<PasswordEntity> Users { get; set; } = new HashSet<PasswordEntity>();
}