using BusManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BusManagement.Controllers
{
    public class HomeController : Controller
    {
        
        TravelManagementContext Context = new TravelManagementContext();
        public IActionResult Index()
        {
            return View(Context.Buses.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string str)
        {
                
            Bus bus = new Bus()
            {
                BusNo = Convert.ToInt32(Request.Form["BusNo"]),
                BusRoute = Request.Form["BusRoute"],
                Description = Request.Form["Description"]
            };
            Context.Buses.Add(bus);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
            
        


        
    }
}
