using HelloMVCRevision.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloMVCRevision.Controllers
{
    public class HomeController : Controller
    {

        List<Trainee> trainees = new List<Trainee>
        {
            new Trainee { Name = "Alice", Location = "Kollam" , Branch = "CS" },
            new Trainee { Name = "Bob", Location = "Kollam", Branch = "CS" },
            new Trainee { Name = "Charlie", Location = "Kollam", Branch = "CS" }
        };
        public IActionResult Index()
        {
            return View(trainees);
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
