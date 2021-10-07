using introDotNetCoreWithMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCoreWithMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.Name = "Sena";
            ViewBag.IsRedPill = true;

            ViewBag.Products = new string[] { "Soda", "Cola", "Ayran", "Kahve" };
            
            return View();
        }

        public IActionResult useModel()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink{ Name="Su", Price=1.5},
                new Drink{ Name="Soda", Price=3},
                new Drink{ Name="Cola", Price=7.5},
                new Drink{ Name="Kahve", Price=8}



            };


            return View(drinks);
        }

        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserRegister(User user)
        {
             return View();            
        }

    }
}
