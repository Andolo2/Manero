using Projektgrupp4.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels;

public class LeaveAReviewViewModel
{
    public int ArticleNumber { get; set; }

    [Display(Name = "COMMENT")]
    public string Comment { get; set; } = null!;
    public int Rating { get; set; }
    public DateTime Created {  get; set; } = DateTime.Now;

}
