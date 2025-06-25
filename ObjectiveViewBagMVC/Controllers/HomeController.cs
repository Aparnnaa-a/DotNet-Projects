using Microsoft.AspNetCore.Mvc;
using ObjectiveViewBagMVC.Models;
using System.Diagnostics;
using System.Xml.Linq;

namespace ObjectiveViewBagMVC.Controllers
{
    public class HomeController : Controller
    {




        public IActionResult Index()
        {
            Contact Aparna = new Contact()
            {
                Name = "Aparna",
                Location = "Kochi"

            };


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
