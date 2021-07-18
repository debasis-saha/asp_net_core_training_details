using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Sample_Application.Models
{
    public class Product
    {
        public string ProductName { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public double DiscountRate { get; set; }
    }
}
