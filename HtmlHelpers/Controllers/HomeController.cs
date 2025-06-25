using HtmlHelpers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HtmlHelpers.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(string str)
        {
            var name= Request.Form["Name"];
            var location = Request.Form["Location"];
            ViewBag.Hello=$"Hello {name} located at {location}";
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
