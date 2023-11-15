using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moq;
using Projektgrupp4.Contexts;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using Xunit;

namespace Projektgrupp4.Test.Linus_Lund_Tester
{ 
    public class CategoryServiceTests
    {
        [Fact] //Kollar så att en kategori har skapats
        public async Task CreateCategoryAsync_ShouldCreateCategory()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: "InMemoryDb")
                .Options;

            using (var dataContext = new DataContext(dbContextOptions))
            {
                var categoryService = new CategoryService(dataContext);

                // Act
                var categoryName = "TestCategory";
                var createdCategory = await categoryService.CreateCategoryAsync(categoryName);

                // Assert
                Assert.NotNull(createdCategory);
                Assert.Equal(categoryName, createdCategory.CategoryName);

            }
        }
    }
}