using AuthN_AuthZ.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AuthN_AuthZ.Controllers
{
    public class AccountController : Controller
    {
        // private readonly SignInManager<ApplicationUser> _signInManager;  //Not Using in This project

        public AccountController() { }
       

        [HttpGet]
        public IActionResult Login() // Not Using This In This Project
        {
            return View();
        }

        // HR Credentials Email = hr@admin.com  pw :  Hr@1234
        // Employee Credentials Email = user@gmail.com  pw:  User@1234

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
        
            if (ModelState.IsValid)
            {
                //var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, lockoutOnFailure: false);
                if(model.Email == "hr@admin.com"  && model.Password == "Hr@1234")
                {
                    return RedirectToAction("Dashboard", "Employee"); 
                }

                else if(model.Email == "user@gmail.com" && model.Password == "User@1234")
                {
                    return RedirectToAction("Dashboard", "Home");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);
            }
            return View(model);
        }

      
    }
}
