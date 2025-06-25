using FormssMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormssMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult Index(string str)
        {
            string name = Request.Form["name"];
            string location = Request.Form["location"];
            ViewBag.Hello = $"Hello{name},located at {location}";
            return View();
        }

        public IActionResult Index()
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
