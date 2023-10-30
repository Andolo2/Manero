using Projektgrupp4.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.ViewModels
{
    public class BackofficeProductViewModel
    {
       
            public int ArticleNumber { get; set; }

            [Display(Name = "Product Image URL")]
            [Required(ErrorMessage = "Product Image URL is required")]
            public string ProductImageUrl { get; set; }



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

        [Display(Name = "Product Color")]
            public Enum.Color ProductColor { get; set; }

            [Display(Name = "Product Label")]
            public Enum.Label ProductLabel { get; set; }

            [Display(Name = "Product Size")]
            public Enum.Size ProductSize { get; set; }


        //public static implicit operator BackofficeProductViewModel(ProductEntity entity)
        //{
        //    return new BackofficeProductViewModel
        //    {
        //        ProductTitle = entity.ProductTitle,
        //        ProductPrice = entity.ProductPrice,
        //        ProductImageUrl = entity.ProductImageUrl,
        //        ProductOfferPrice = entity.ProductOfferPrice,
        //        ProductPriceOrOffer = entity.ProductPriceOrOffer,
        //        ProductDescription = entity.ProductDescription,
        //        // Map other properties as needed
        //    };
        //}


    }


}
