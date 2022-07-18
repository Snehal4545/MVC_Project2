using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Project2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> plist = new List<Product>
            {
                new Product {Id=1,Name="Dell",Price=40000},
                 new Product {Id=2,Name="HP",Price=30000},
                  new Product {Id=3,Name="Mac",Price=60000},
                   new Product {Id=4,Name="Lenovo",Price=35000},
            };
            ViewBag.ProductList = plist;

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {
            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];
            return View("Details");

        }

    }
}
