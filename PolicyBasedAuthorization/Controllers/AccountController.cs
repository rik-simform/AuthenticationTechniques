﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PolicyBasedAuthorization.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password, string salary)
        {
            if (username == "admin" && password == "admin123")
            {
                var identity = new ClaimsIdentity(new[] { new Claim ("Salary", salary) ,
                               new Claim(ClaimTypes.Name,username)},
                               CookieAuthenticationDefaults.AuthenticationScheme);
                var principle = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
                return RedirectToAction("Index", "Home");
            }
            if (username == "raj" && password == "raj")
            {
                var identity = new ClaimsIdentity(new[] { new Claim("Salary", salary),
                               new Claim(ClaimTypes.Name,username) },
                               CookieAuthenticationDefaults.AuthenticationScheme);
                var principle = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);

                return RedirectToAction("Index", "Home");
            }
            if (username == "rashi" && password == "rashi")
            {
                var identity = new ClaimsIdentity(new[] { new Claim("Salary", salary) ,
                               new Claim(ClaimTypes.Name,username)},
                               CookieAuthenticationDefaults.AuthenticationScheme);
                var principle = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}
