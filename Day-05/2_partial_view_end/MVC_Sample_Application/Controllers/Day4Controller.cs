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

        public IActionResult TagHelperDemo()
        {
            IList<Product> products = new List<Product>{
                new Product() { ProductName = "Samsung Galaxy 10", Category="Mobile", Price = 65000, DiscountRate=7.5 } ,
                new Product() { ProductName = "Samsung Note 20", Category="Mobile", Price = 105000, DiscountRate=8.5 } ,
                new Product() { ProductName = "Canon EOS M50 Mark II", Category="Camera", Price = 58990, DiscountRate=11.25 } ,
                new Product() { ProductName = "HP Envy 11th Gen Intel Core i7", Category="Laptop", Price = 11500, DiscountRate=9.25 } ,
                new Product() { ProductName = "Redmi 10T", Category="Mobile", Price = 26500, DiscountRate=7.5 }
            };
            return View(products);
        }

        public IActionResult Submit([FromForm] Student student)
        {            
            return RedirectToAction("ConfirmResult", student);
        }

        public IActionResult ConfirmResult(Student data)
        {
            return View(data);
        }
    }
}
