using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels
{
    public class SizeViewModel
    {
        [Display(Name = "Size")]
        //[Required(ErrorMessage = "You must enter a size")]
        public string SizeName { get; set; } = null!;

        public List<string> Sizes { get; set; } = new List<string>();
        public List<string> SelectedSizes { get; set; } = new List<string>();

    }
}