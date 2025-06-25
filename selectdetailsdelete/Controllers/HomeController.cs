using Microsoft.AspNetCore.Mvc;
using selectdetailsdelete.Models;
using System.Diagnostics;

namespace selectdetailsdelete.Controllers
{
    public class HomeController : Controller
    {
        TocHtraineeContext tocHtraineeContext=new TocHtraineeContext();

        public IActionResult Index()
        {
            return View(tocHtraineeContext.Trainees.ToList());
        }

        public IActionResult Delete(int id)
        {
            var trainee = tocHtraineeContext.Trainees.Find(id);
            return View(trainee);
        }

        [HttpPost]
        [ActionName("Delete")]

        public IActionResult DeletePost(int id)
        {
            var trainee = tocHtraineeContext.Trainees.Find(id);
            tocHtraineeContext.Trainees.Remove(trainee);
            tocHtraineeContext.SaveChanges();
            return RedirectToAction("Index");
           
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
