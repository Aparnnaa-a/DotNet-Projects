using CollectionOfClassMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CollectionOfClassMVC.Controllers
{
    public class HomeController : Controller
    {
        List<Technology> technologyList = new List<Technology>()
     {
       new Technology {Name="C#",Vendor="Microsoft"},
       new Technology {Name="C#",Vendor="Oracle"},
       new Technology { Name = "C#", Vendor = "Python Software Foundation" }
     };





        public IActionResult Index()
        {
            ViewBag.TechnologyList = technologyList;
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
