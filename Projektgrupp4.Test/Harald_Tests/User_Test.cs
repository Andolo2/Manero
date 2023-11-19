using Moq;
using Projektgrupp4.Enum;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Models;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektgrupp4.Test.Harald_Tests;

public class User_Test
{
    readonly AuthService authService = new();
    [Fact]
    public async Task ShouldReturnFalse_If_EmailIsIncorrectlyFormatted()
    {
        //Arrange
        var viewModel = new SignInViewModel(){
            Email = "ThisIsNotAValidEmail",
            Password = "password123"
        };

        //Act
        var result = await authService.SignInAsync(viewModel);

        //Assert
        Assert.Equivalent(false, result);
    }
}
