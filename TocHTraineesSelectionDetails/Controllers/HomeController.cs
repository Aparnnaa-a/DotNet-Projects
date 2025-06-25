using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TocHTraineesSelectionDetails.Models;

namespace TocHTraineesSelectionDetails.Controllers
{
    public class HomeController : Controller
    {
        TocHContext tocHContext = new TocHContext();    

        public IActionResult Index()
        {
            return View(tocHContext.Trainees.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Trainee trainee)
        {
            tocHContext.Trainees.Add(trainee);
            tocHContext.SaveChanges();
            return RedirectToAction("Index");
            return View(trainee);  
            
        }

        public IActionResult Details(int id)
        {
            var trainee = tocHContext.Trainees.Find(id);
            return View(trainee);
        }

        public IActionResult Delete(int id)
        {
            var trainee = tocHContext.Trainees.Find(id);
           
            return View(trainee);
        }

        [HttpPost]
        [ActionName("Delete")]

        public IActionResult DeletePost(int id)
        {
            var trainee = tocHContext.Trainees.Find(id);
            tocHContext.Trainees.Remove(trainee);
            tocHContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var trainee = tocHContext.Trainees.Find(id);
            return View(trainee);
        }

        [HttpPost]

        public IActionResult Edit(Trainee trainee)
        {
            var tr = tocHContext.Trainees.Find(trainee.id);
            tr.name = trainee.name;
            tr.location = trainee.location;
            tocHContext.SaveChanges();
            return RedirectToAction("Index");
          
        }

        public IActionResult Privacy()
        {
            
            return View();
        }







        //public IActionResult Hello()
        //{
        //return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
