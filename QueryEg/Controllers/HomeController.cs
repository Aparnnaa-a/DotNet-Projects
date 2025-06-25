using Microsoft.AspNetCore.Mvc;
using QueryEg.Models;
using System.Diagnostics;

namespace QueryEg.Controllers
{
    public class HomeController : Controller
    {
        

        public String Index(string id)
        {
            return $"Hello{ id}";
        }

        public IActionResult Saurav()
        {
            return Content("Saurav");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
