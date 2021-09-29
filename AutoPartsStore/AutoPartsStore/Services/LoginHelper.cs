using AutoPartsStore.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AutoPartsStore.Services
{
    //public class LoginHelper
    //{
    //    private readonly UserManager<User> userManager;
    //    private readonly SignInManager<User> signInManager;
    //    public LoginHelper(UserManager<User> userManager, SignInManager<User> signInManager)
    //    {
    //        this.userManager = userManager;
    //        this.signInManager = signInManager;
    //    }

    //    public async LoginViewModel Register(LoginViewModel model)
    //    {

    //            User user = new User { UserName = model.Email };
    //            IdentityResult result = await userManager.CreateAsync(user, model.Password);

    //            if (result.Succeeded)
    //            {
    //                await signInManager.SignInAsync(user, false);
    //                //return Redirect(model.ReturnUrl);
    //                return RedirectToAction("Home", "Index");
    //            }
    //            else
    //            {
    //                foreach (var error in result.Errors)
    //                {
    //                    ModelState.AddModelError("", error.Description);
    //                }

    //            }

    //        return model;
    //    }
    //}
}
