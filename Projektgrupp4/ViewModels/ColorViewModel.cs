using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels
{
    public class ColorViewModel
    {
        [Display(Name = "Color")]
        [Required(ErrorMessage = "You must enter a color")]
        public string ColorName { get; set; } = null!;

        public List<string> Colors { get; set; } = new List<string>();
        public List<string> SelectedColors { get; set; } = new List<string>();

    }
}