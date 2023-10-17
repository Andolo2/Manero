using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace Projektgrupp4.Models.Entities;

public class PasswordEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    public byte[] Password { get; set; } = null!;
    public byte[] SecurityKey { get; set; } = null!;

    public void GenerateSecuredPassword(string password)
    {
        using var hmac = new HMACSHA512();
        SecurityKey = hmac.Key;
        Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    public bool VerifySecurePasswoord(string password)
    {
        using var hmac = new HMACSHA512(SecurityKey);
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        for (int i = 0; i < hash.Length; i++)
        {
            if (hash[i] != Password[i])
            {
                return false;
            }
        }
        return true;
    }

}
