using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using catinc.Models;
using catinc.Repositories;
using catinc.Models.Domain;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using catinc.Models.ViewModels;

namespace catinc.Controllers
{
    /// <summary>
    /// A controller for the home page
    /// </summary>
    public class HomeController : Controller
    {
        private IVendorRepository<Vendor> _vendorRepository;

        /// <summary>
        /// Creates the home controller
        /// </summary>
        /// <param name="vendorRepository"></param>
        public HomeController(IVendorRepository<Vendor> vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        /// <summary>
        /// Returns the index page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            string VendorName = "";
            string userIdValue = "";
            if (User != null)
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;
                if (claimsIdentity != null)
                {
                    var userIdClaim = claimsIdentity.Claims
                        .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                    if (userIdClaim != null)
                    {
                        userIdValue = userIdClaim.Value;
                    }
                }
            }
            if (!string.IsNullOrEmpty(userIdValue) && _vendorRepository.GetCount() < 0)
            {
                    VendorName = _vendorRepository.FindByUserID(userIdValue).Result.VendorName;
            }
            else
            {
                VendorName = "Cat Inc";
            }
            ViewData.Add("VendorName", VendorName);
            return View();
        }

        /// <summary>
        /// Returns the about page
        /// </summary>
        /// <returns></returns>
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        /// <summary>
        /// Returns the contact page
        /// </summary>
        /// <returns></returns>
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
