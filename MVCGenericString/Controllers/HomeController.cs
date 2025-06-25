using Microsoft.AspNetCore.Mvc;
using MVCGenericString.Models;
using System.Diagnostics;

namespace MVCGenericString.Controllers
{
    public class HomeController : Controller
    {
        List<string> touristLocations = new List<string>()
        { 
        "Kochaikkal Caves","Arikkal WaterFalls"
      };


        public IActionResult Index()
        {
            ViewBag.Locations = touristLocations;
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
