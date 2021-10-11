using AutoPartsStore.Models;
using AutoPartsStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AutoPartsStore.Services
{
    public class LoginHelper
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public LoginHelper(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public async Task<LoginViewModel> Register(LoginViewModel model)
        {
            User user = new User { Email = model.Email, UserName = model.Email };
            IdentityResult result = await userManager.CreateAsync(user, model.Password);

            var ifRole = await roleManager.FindByNameAsync("User");
            if (ifRole == null)
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }

            User userFound = await userManager.FindByNameAsync(model.Email);
            await userManager.AddToRoleAsync(userFound, "User");

            if (result.Succeeded)
            {
                await signInManager.SignInAsync(user, false);
            }
            else
            {
                //foreach (var error in result.Errors)
                //{
                //}

            }

            return model;
        }
    }
}
