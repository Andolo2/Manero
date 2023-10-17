using Microsoft.EntityFrameworkCore;

namespace Projektgrupp4.Models.Entities;

[PrimaryKey(nameof(UserId), nameof(PasswordId))]
public class UserPasswordEntity
{
    public Guid UserId { get; set; }
    public UserEntity User { get; set; } = null!;
    public Guid PasswordId { get; set; }
    public PasswordEntity Password { get; set; } = null!;
}
