using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace catinc.Controllers.API
{
    [Route("api/[controller]/[action]")]
    public class UserAPI : Controller
    {
        private MySqlDbContext _mySqlDbContext;
        private IVendorRepository<Vendor> _vendorRepository;

        public UserAPI(MySqlDbContext mySqlDbContext, IVendorRepository<Vendor> vendorRepository)
        {
            _mySqlDbContext = mySqlDbContext;
            _vendorRepository = vendorRepository;
        }

        [HttpGet]
        public ClaimsPrincipal getCurrent()
        {
            return HttpContext.User;
        }

        [HttpGet]
        public string getName()
        {
            return HttpContext.User.Identity.Name;
        }

        [HttpGet]
        public Vendor getVendor()
        {
            string vendorName = "";
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
            Vendor vendor = null;
            if (!string.IsNullOrEmpty(userIdValue))
            {
                vendor = _vendorRepository.FindByUserID(userIdValue).Result;
                if (vendor != null)
                {
                    vendorName = vendor.VendorName;
                }
                else 
                {
                    // vendorName = "Cat Inc";
                    vendor = new Vendor {
                        VendorName = "Cat Inc"
                    };
                }
            }
            else {
                // vendorName = "Cat Inc";
                vendor = new Vendor {
                    VendorName = "Cat Inc"
                };
            }
            // return "{\"vendorName\": \"" + vendorName + "\" }";
            return vendor;
        }
    }
}