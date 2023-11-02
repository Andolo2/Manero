using Projektgrupp4.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels
{
    public class BackofficeProductViewModel
    {
       
            public int ArticleNumber { get; set; }

            [DataType(DataType.Upload)]
            [Display(Name = "Product Image")]
            public IFormFile ProductImage { get; set; }

             public string? ProductImageBase64 { get; set; }



        [Display(Name = "Product Title")]
            [Required(ErrorMessage = "Product Title is required")]
            public string ProductTitle { get; set; }



            [Display(Name = "Product Price")]
            public decimal ProductPrice { get; set; }

            [Display(Name = "Product Offer Price")]
            public decimal? ProductOfferPrice { get; set; }

            [Display(Name = "Product Price or Offer")]
            public bool ProductPriceOrOffer { get; set; }

            [Display(Name = "Product Description")]
            [Required(ErrorMessage = "Product Description is required")]
            public string ProductDescription { get; set; }

            [Display(Name = "Size")]
            public List<string> Size { get; set; } = new List<string>();
            public List<string>? SelectedSize { get; set; }

            [Display(Name = "Colors")]
            public List<string> Colors { get; set; } = new List<string>();
            public List <string>? selectedColors { get; set; }

            [Display(Name = "Categories")]
            public List<string> Categories { get; set; } = new List<string>();
            public List <string>? selectedCategories { get; set; }

            [Display(Name = "Available Sizes")]
            public List<string> AvailableSizes { get; set; }

            [Display(Name = "Selected Sizes")]
            public List<string> SelectedSizes { get; set; }


        //public static implicit operator ProductEntity(BackofficeProductViewModel viewModel)
        //{
        //    var entity = new ProductEntity
        //    {
        //        ProductTitle = viewModel.ProductTitle,
        //        ProductPrice = viewModel.ProductPrice,
        //        ProductOfferPrice = viewModel.ProductOfferPrice,
        //        ProductPriceOrOffer = viewModel.ProductPriceOrOffer,
        //        ProductDescription = viewModel.ProductDescription,
        //    };

        //    if (viewModel.ProductImage != null)
        //    {
        //        using (var stream = new MemoryStream())
        //        {
        //            viewModel.ProductImage.CopyTo(stream);
        //            entity.ProductImage = stream.ToArray();
        //        }
        //    }

        //    return entity;
        //}




    }


}
