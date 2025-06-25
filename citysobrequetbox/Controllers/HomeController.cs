using citysobrequetbox.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace citysobrequetbox.Controllers
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
            string sobrequet = Request.Form["location"];
            if (sobrequet== "kochi")
            {
                sobrequet = "Queen Of Arabian Sea";
            }
            else if (sobrequet == "paris")
            {
                sobrequet = "City of Lights";
            }
            else if (sobrequet == "london")
            {
                sobrequet = "City of Fog";
            }
            else if (sobrequet == "newyork")
            {
                sobrequet = "Big Apple";
            }
            else
            {
                sobrequet = "Unknown City";
            }

            ViewBag.name = sobrequet;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
