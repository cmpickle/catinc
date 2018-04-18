using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using final_project_cmpickle.Models.Database;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace final_project_cmpickle.Controllers.API
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
        public string getVendor()
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
            if (!string.IsNullOrEmpty(userIdValue))
            {
                vendorName = _vendorRepository.FindByUserID(userIdValue).Result.VendorName;
            }
            else{
                vendorName = "Cat Inc";
            }
            return vendorName;
        }
    }
}