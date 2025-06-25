using HtmlTextBoxHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HtmlTextBoxHelper.Controllers
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
            ViewBag.Hello = $"Hello{Request.Form["Name"]}";
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
