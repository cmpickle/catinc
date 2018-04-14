using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using final_project_cmpickle.Models;
using final_project_cmpickle.Models.ViewModels.HomeViewModels;

namespace final_project_cmpickle.Controllers
{
    public class HomeController : Controller
    {
        // private 
        public IActionResult Index()
        {
            // User.Identity.Name
            return View(new HomeViewModel());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
