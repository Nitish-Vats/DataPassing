using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataPassing.Models;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace DataPassing.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Username == "user@gmail.com" && model.Password == "123456")
                {
                    string userstr = JsonSerializer.Serialize(model);
                    HttpContext.Session.SetString("User", userstr);


                    TempData["Message"] = "Welcome Back";
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ViewBag.ErrorMessage = "Username or Password doesn't match";

                }
            }
            return View();
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View();
        }



    }
}
