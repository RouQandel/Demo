
using DataAccess_Layer_Database.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

using System.Security.Claims;

namespace presentationLayer_Controller.Controllers.Account
{
    public class AccountController : Controller
    {
        [HttpGet] // get  Request "attribute"
        public IActionResult Register()
        {
            return View("Register");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
       
        public async Task<IActionResult> SignOut()
        {
            if (HttpContext.User.Identity.IsAuthenticated)//remove user remeber
            {
                await HttpContext.SignOutAsync();
            }
            return RedirectToAction("Index", "HOME");

        }
    }
   
   
}
