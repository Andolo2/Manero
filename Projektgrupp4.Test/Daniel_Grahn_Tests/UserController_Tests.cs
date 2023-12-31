﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using Projektgrupp4.Controllers;
using Projektgrupp4.Enum;
using Projektgrupp4.Models;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.Services;
using Projektgrupp4.ViewModels;
using System.Linq.Expressions;
using Xunit;

public class SignUpController_Tests
{
    [Fact]
    public async Task SignUpAsync_SuccessfulRegistration_ReturnsCreatedStatusCode()
    {
        // Arrange
        var viewModel = new SignUpViewModel();

        var authenticationServiceMock = new Mock<IAuthenticationService>();
        var viewModelMock = new Mock<SignUpViewModel>();
        authenticationServiceMock.Setup(authService => authService.SignUpAsync(viewModel))
            .ReturnsAsync(new ServiceResponse<UserEntity>
            {
                StatusCode = StatusCode.Created,
                Content = null
            });

        var signUpController = new SignUpController(authenticationServiceMock.Object);

        // Act
        var result = await signUpController.Index(viewModel);

        // Assert
        var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
        Assert.Equal("AccountCreated", redirectToActionResult.ActionName);
    }

    [Fact]
    public async Task SignUpAsync_UserAlreadyExists_ReturnModelStateError()
    {
        // Arrange
        var authenticationServiceMock = new Mock<IAuthenticationService>();
        var controller = new SignUpController(authenticationServiceMock.Object);

        authenticationServiceMock.Setup(x => x.UserAlreadyExistsAsync(It.IsAny<Expression<Func<UserEntity, bool>>>())).ReturnsAsync(true);

        // Act
        var result = await controller.Index(new SignUpViewModel());

        // Assert
        var viewResult = Assert.IsType<ViewResult>(result);
        Assert.False(viewResult.ViewData.ModelState.ContainsKey("Email"));
        
    }
}


