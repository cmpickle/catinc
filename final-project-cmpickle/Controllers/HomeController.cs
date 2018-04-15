using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using final_project_cmpickle.Models;
using final_project_cmpickle.Models.ViewModels.HomeViewModels;
using final_project_cmpickle.Repositories;
using final_project_cmpickle.Models.Domain;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace final_project_cmpickle.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(IVendorRepository<Vendor> vendorRepository) : base(vendorRepository)
        {
            ViewBag.Scrap = "Cat Inc";
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
