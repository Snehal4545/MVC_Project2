using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Project2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MVC_Project2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "This is my mvc Project";
            string[] names = { "Snehal", "Pooja", "Neha", "Priyanka" };
            ViewData["namesList"] = names;

            List<Employee> emplist = new List<Employee>
            {
                new Employee { Id = 1, Name = "Snehal", Department = "IT", Salary = 30000 },
                 new Employee { Id = 2, Name = "Pooja", Department = "IT", Salary = 40000 },
                  new Employee { Id = 3, Name = "Neha", Department = "IT", Salary = 35000 },
                   new Employee { Id = 4, Name = "Priyanka", Department = "IT", Salary = 50000 },
            };
            ViewData["emplist"] = emplist;
            return View();
        }
        public IActionResult ContacUs()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
