using CarWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CarWebApp.Controllers
{
    public class HomeController : Controller
    {
        private CarDAL _carDAL = new CarDAL();

        public IActionResult Index()
        {
            List<Car> cars = _carDAL.allCars();
            return View(cars);
        }

        public IActionResult Results(string category, string search)
        {
            List<Car> cars = _carDAL.GetCars(category, search);
            return View(cars);
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
