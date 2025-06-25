using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TocHtrainee.Models;

namespace TocHtrainee.Controllers
{
    public class HomeController : Controller
    {
        TocHtraineeContext tocHtraineecontext=new TocHtraineeContext();
        public IActionResult Index()
        {
            return View(tocHtraineecontext.TocHtrainees.ToList);
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
