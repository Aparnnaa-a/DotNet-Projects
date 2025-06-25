using Microsoft.AspNetCore.Mvc;
using MVCSelectionInsertion.Models;
using System.Diagnostics;

namespace MVCSelectionInsertion.Controllers
{
    public class HomeController : Controller
    {
        TocHtraineeContext tocHtraineesContext = new TocHtraineeContext();


        public IActionResult Index()
        {
            return View(tocHtraineesContext.TocHtrainees.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string str)
        {
            TocHtrainee tocHtrainee = new TocHtrainee()
            {
                Name = Request.Form["Name"],
                Location = Request.Form["Location"],

            };
            tocHtraineesContext.Add(tocHtrainee);
            tocHtraineesContext.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}
