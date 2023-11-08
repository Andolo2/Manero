using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Enum;
using Projektgrupp4.Models;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.ViewModels;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Claims;

namespace Projektgrupp4.Services;

public interface IAuthenticationService
{
    Task<ServiceResponse<UserEntity>> SignUpAsync(SignUpViewModel viewModel);
    Task<bool> UserAlreadyExistsAsync(Expression<Func<UserEntity, bool>> expression);

}

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<UserEntity> _userManager;
    private readonly SignInManager<UserEntity> _signInManager;
    private readonly SeedService _seedService;
    private readonly UserEntity viewModel;

    public AuthenticationService(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, SeedService seedService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _seedService = seedService;
    }

    /*public async Task<bool> SignUpAsync(SignUpViewModel viewModel)
    {
        var response = new ServiceResponse<UserEntity>();

        try
        {
            await _seedService.SeedRoles();
            var roleName = "user";

            if (!await _userManager.Users.AnyAsync())
                roleName = "admin";

            UserEntity userEntity = viewModel;

            var result = await _userManager.CreateAsync(userEntity, viewModel.Password);

            await _userManager.AddToRoleAsync(userEntity, roleName);

            if (result.Succeeded)
            {
                response.StatusCode = StatusCode.Created;
                response.Content = userEntity; // Set the created user in the response
            }
            else
            {
                response.StatusCode = StatusCode.BadRequest; // You might want to use a different status code for a failed signup.
                response.Content = null;
                // You can also loop through the errors in `result.Errors` and add them to the response for more details on what went wrong.
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.StatusCode = StatusCode.InternalServerError;
            response.Content = null;
        }

        return response;

    }*/

    public async Task<UserEntity> GetUserAsync(ClaimsPrincipal user)
    {
        try
        {
            var currentUser = await _userManager.GetUserAsync(user);
            if (currentUser != null)
            {
                return currentUser;
            }
            else
            {
                return null!;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return null!;
        }
        
    }

    public async Task<bool> UserAlreadyExistsAsync(Expression<Func<UserEntity, bool>> expression)
    {
        return await _userManager.Users.AnyAsync(expression);
    }

    public async Task<ServiceResponse<UserEntity>> SignUpAsync(SignUpViewModel viewModel)
    {
        var response = new ServiceResponse<UserEntity>();

        try
        {
            await _seedService.SeedRoles();
            var roleName = "user";

            if (!await _userManager.Users.AnyAsync())
                roleName = "admin";

            UserEntity userEntity = viewModel;

            var result = await _userManager.CreateAsync(userEntity, viewModel.Password);

            await _userManager.AddToRoleAsync(userEntity, roleName);

            if (result.Succeeded)
            {
                response.StatusCode = StatusCode.Created;
                response.Content = userEntity; // Set the created user in the response
            }
            else
            {
                response.StatusCode = StatusCode.BadRequest; // You might want to use a different status code for a failed signup.
                response.Content = null;
                // You can also loop through the errors in `result.Errors` and add them to the response for more details on what went wrong.
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            response.StatusCode = StatusCode.InternalServerError;
            response.Content = null;
        }

        return response;
    }
}
