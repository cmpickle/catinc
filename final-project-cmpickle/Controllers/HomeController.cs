using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using final_project_cmpickle.Models;
using final_project_cmpickle.Repositories;
using final_project_cmpickle.Models.Domain;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using final_project_cmpickle.Models.ViewModels.BaseViewModels;

namespace final_project_cmpickle.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IVendorRepository<Vendor> vendorRepository)
        {
        }

        public IActionResult Index()
        {
            return View();
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
