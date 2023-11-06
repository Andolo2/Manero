using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels
{
    public class CategoryViewModel
    {
        [Display(Name = "Category")]
        [Required(ErrorMessage = "You must enter a category")]
        public string CategoryName { get; set; } = null!;

        public List<string> Categories { get; set; } = new List<string>();
        public List<string> SelectedCategories { get; set; } = new List<string>();

    }
}