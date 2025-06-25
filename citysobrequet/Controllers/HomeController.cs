using citysobrequet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace citysobrequet.Controllers
{
    public class HomeController : Controller
    {
        

        public string Index(string id)
        {
            string sobrequet = "";
            if(id=="kochi")
            {
                sobrequet = "Queen Of Arabian Sea";
            }
            else if(id=="paris")
            {
                sobrequet = "City of Lights";
            }
            else if(id=="london")
            {
               sobrequet = "City of Fog";
            }
            else if(id=="newyork")
            {
                sobrequet = "Big Apple";
            }
          else
            {
                sobrequet = "Unknown City";
            }

            return sobrequet;
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
