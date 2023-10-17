using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projektgrupp4.Models.Entities;

public class AddressEntity
{
    [Key]
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string StreetName { get; set; } = null!;
    public int StreetNumber { get; set; }
    public string CityName { get; set; } = null!;
    public int PostalCode { get; set; }
    public string CountryName { get; set; } = null!;

} 
