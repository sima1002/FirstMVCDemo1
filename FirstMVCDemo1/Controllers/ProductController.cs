using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstMVCDemo1.Models;
using System.Collections.Generic;

namespace FirstMVCDemo1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Dell Laptop",Price=34000},
                new Product{Id=2,Name="Lenovo Laptop",Price=38000},
                new Product{Id=3,Name="HP Laptop",Price=39000},
                new Product{Id=4,Name="Dell Mouse",Price=340},
                new Product{Id=5,Name="Dell Keyboard",Price=400},
            };
            ViewData["productlist"] = products;

            ViewBag.Products = products;
            return View();

            return View();
        }
    }
}
