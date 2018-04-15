using System.Linq;
using System.Security.Claims;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace final_project_cmpickle.Controllers
{
    public class BaseController : Controller
    {
        private IVendorRepository<Vendor> _vendorRepository;

        public string VendorName 
        {
            get
            {
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
                    return _vendorRepository.FindByUserID(userIdValue).Result.VendorName;
                }
                else{
                    return "Cat Inc";
                }
            }
        }
        
        public BaseController(IVendorRepository<Vendor> vendorRepository)
        {
            _vendorRepository = vendorRepository;
            ViewData.Add("VendorName", VendorName);
            ViewBag.Scrap = VendorName;
        }
    }
}