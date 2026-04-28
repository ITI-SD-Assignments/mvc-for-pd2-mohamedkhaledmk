using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
[AllowAnonymous]
    public class AccountController : Controller
    {
        UserManager<AppUser> userManager { get; }
        SignInManager<AppUser> signInManager { get; }
        public AccountController(UserManager<AppUser> UM,SignInManager<AppUser> sim)
        {
            userManager = UM;
            signInManager = sim;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel UserVM)
        {
            AppUser user = new AppUser()
            {
                UserName = UserVM.UserName,
                FirstName=UserVM.FirstName,
                LastName=UserVM.LastName,
                EducationLevel=UserVM.EducationLevel,
                Nationality=UserVM.Nationality
            };

            IdentityResult identityResult = await userManager.CreateAsync(user,UserVM.Password);
            if(identityResult.Succeeded)
            {
                //Create Cookie for user & redirect to home page

                await signInManager.SignInAsync(user, isPersistent: false); 

                return RedirectToAction("Index", "Customers");
            }else
            {
                foreach(var err in identityResult.Errors)
                {
                    ModelState.AddModelError("Error",err.Description);

                }
            }

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginUserVM loginUser)
        {
            if(ModelState.IsValid)
            {
                AppUser user = await userManager.FindByNameAsync(loginUser.UserName);

                if(user!=null)
                {
                    bool found = await userManager.CheckPasswordAsync(user, loginUser.Password);
                    if(found)
                    {
                        await signInManager.SignInAsync(user, isPersistent: loginUser.RememberMe);

                        return RedirectToAction("AllPrds", "Prds");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid Username or Password");
            return View();
        }


        public async Task<IActionResult> Logout ()
        {
            await signInManager.SignOutAsync(); 
            return RedirectToAction("Register","Account");
        }
    }
}
