using Microsoft.AspNetCore.Mvc;
using MVC_Sample_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Sample_Application.Controllers
{
    public class Day4Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HtmlHelper()
        {
            return View();
        }
    }
}
