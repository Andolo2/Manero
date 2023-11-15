using Microsoft.AspNetCore.Mvc;
using Moq;
using Projektgrupp4.Contexts;
using Projektgrupp4.Controllers;
using Projektgrupp4.Interfaces;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;


namespace Projektgrupp4.Test.Linus_Lund_Tester
{
    public class CategoryViewControllerTests
    {
        [Fact]
        public async Task Index_ReturnsCategoryViewModel()
        {
            // Arrange
            // Skapa en mock för ICategoryService
            var categoryServiceMock = new Mock<ICategoryService>();

            // Skapa en instans av CategoryViewController och använd mocken som service
            var controller = new CategoryViewController(categoryServiceMock.Object);

            // Förväntade kategorier som ska returneras av mocktjänsten
            var expectedCategories = new List<CategoryEntity>
            {
            new CategoryEntity { CategoryName = "Category1" },
            new CategoryEntity { CategoryName = "Category2" },
            };

            // Konfigurera mocktjänsten att returnera förväntade kategorier vid anrop på GetAllCategoriesAsync
            categoryServiceMock.Setup(x => x.GetAllCategoriesAsync())
                .ReturnsAsync(expectedCategories);

            // Act
            // Anropa Index-metoden på controller för att få resultatet
            var result = await controller.Index();

            // Assert
            // Kontrollera att resultatet är av typen ViewResult
            var viewResult = Assert.IsType<ViewResult>(result);

            // Kontrollera att modellen i resultatet är av typen CategoryViewModel
            var model = Assert.IsType<CategoryViewModel>(viewResult.Model);

            // Kontrollera att modellen inte är null
            Assert.NotNull(model);

            // Kontrollera att kategorierna i modellen matchar de förväntade kategorierna
            Assert.Equal(expectedCategories.Select(c => c.CategoryName).ToList(), model.Categories);
        }
    }
}
