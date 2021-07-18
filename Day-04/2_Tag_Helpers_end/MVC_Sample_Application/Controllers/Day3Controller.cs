using Microsoft.AspNetCore.Mvc;
using MVC_Sample_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Sample_Application.Controllers
{
    public class Day3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BasicPage()
        {
            return View();
        }

        public IActionResult IfConditionPage()
        {
            Product product = new Product();
            product.ProductName = "Samsung Galaxy 10";
            product.Category = "Mobile";
            product.Price = 65000;
            product.DiscountRate = 7.5;
            return View(product);
        }

        public IActionResult ForConditionPage()
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
    }
}
