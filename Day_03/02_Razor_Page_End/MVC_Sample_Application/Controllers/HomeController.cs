using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Sample_Application.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Sample_Application.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public string WelcomeMessage()
        {
            return "Hello to Asp.Net Core MVC Framework...";
        }

    }
}
