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

    public AuthenticationService(UserManager<UserEntity> userManager)
    {
        _userManager = userManager;
    }

    public async Task<bool> SignUpAsync(SignUpViewModel viewModel)
    {
        try
        {
            //UserEntity userEntity = viewModel;

            //var result = await _userManager.CreateAsync(userEntity, viewModel.Password);

            //if (result.Succeeded) {
            //    return true;
            //}
            var user = new UserEntity
            {
                UserName = viewModel.Email,
                Name = viewModel.Name,      // Change 'Name' to 'UserName'
                Email = viewModel.Email,    // Change 'Email' to 'UserEmail'
            };

            var result = await _userManager.CreateAsync(user, viewModel.Password);

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

        //return false;
        //} catch { return false; }
    }

    public async Task<bool> UserAlreadyExistsAsync(Expression<Func<UserEntity, bool>> expression)
    {
        return await _userManager.Users.AnyAsync(expression);
    }
}
