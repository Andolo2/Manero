using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.ViewModels;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Projektgrupp4.Services;

public class AuthenticationService
{
    private readonly UserManager<UserEntity> _userManager;
    private readonly SignInManager<UserEntity> _signInManager;
    private readonly SeedService _seedService;

    public AuthenticationService(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, SeedService seedService)
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _seedService = seedService;
    }

    public async Task<bool> SignUpAsync(SignUpViewModel viewModel)
    {
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
                return true;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        return false;

    }

    public async Task<bool> UserAlreadyExistsAsync(Expression<Func<UserEntity, bool>> expression)
    {
        return await _userManager.Users.AnyAsync(expression);
    }


    //Function to sign in
    public async Task<bool> SignInAsync(SignInViewModel model)
    {
        try
        {
            var userExists = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == model.Email);

            if (userExists != null)
            {
                var result = await _signInManager.PasswordSignInAsync(userExists, model.Password, model.RememberMe, false);
                return result.Succeeded;
            }

        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }

    //Function to sign out
    public async Task<bool> SignOutAsync()
    {
        try
        {
            await _signInManager.SignOutAsync();
            return true;
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
        return false;
    }
}
