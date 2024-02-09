using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataPassing.Models;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace DataPassing.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            //string strUser = HttpContext.Session.GetString("User");
            //LoginViewModel user = JsonSerializer.Deserialize<LoginViewModel>(strUser);
            return View();
        }
    }
}
