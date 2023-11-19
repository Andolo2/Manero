using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projektgrupp4.Models.Entities;
using Projektgrupp4.ViewModels;
using System.Diagnostics;

namespace Projektgrupp4.Services
{
    public class AuthService
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;

        public AuthService()
        {
        }

        public AuthService(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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
}
