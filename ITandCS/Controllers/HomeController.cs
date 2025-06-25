using ITandCS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITandCS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Aparna";
            return View();
        }

        public IActionResult IT()
        {
            return View();
        }

        public IActionResult CS()
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
