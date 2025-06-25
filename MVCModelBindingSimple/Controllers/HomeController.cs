using Microsoft.AspNetCore.Mvc;
using MVCModelBindingSimple.Models;
using System.Diagnostics;

namespace MVCModelBindingSimple.Controllers
{
    public class HomeController : Controller
    {
        Trainee alan=new Trainee(){Name="Alan",Location="Kaloor"};

        public IActionResult Index()
        {
            return View(alan);
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
