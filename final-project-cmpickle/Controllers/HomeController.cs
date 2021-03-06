﻿using System;
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

namespace final_project_cmpickle.Controllers
{
    public class HomeController : Controller
    {
        private IVendorRepository<Vendor> _vendorRepository;
        public HomeController(IVendorRepository<Vendor> vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

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
