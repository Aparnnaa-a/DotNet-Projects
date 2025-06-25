using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TraineeManagement.Models;

namespace TraineeManagement.Controllers
{
    public class HomeController : Controller
    {
       TocHContext tocHContext= new TocHContext();
        public IActionResult Index()
        {
            return View(tocHContext.Trainees.ToList());
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
