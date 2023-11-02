﻿using System.ComponentModel.DataAnnotations;

namespace Projektgrupp4.Models.Entities;

public class ProductItemEntity
{
    [Key]
    public int ProductEntryId { get; set; }
    
    public int ArticleNumber { get; set; }
    public ProductEntity Product { get; set; } = null!;

    public int SizeId { get; set; }
    public SizeEntity Size { get; set; } = null!;

    public int ColorId { get; set; }
    public ColorEntity Color { get; set; } = null!;

    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;  
}
