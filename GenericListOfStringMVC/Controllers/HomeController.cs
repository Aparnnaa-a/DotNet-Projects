using GenericListOfStringMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GenericListOfStringMVC.Controllers
{
    public class HomeController : Controller
    {
       List<string> trainees= new List<string>(){"Aparna","Swetha","Aiswarya"};

        public IActionResult Index()
        {
            ViewBag.Trainees = trainees;
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
