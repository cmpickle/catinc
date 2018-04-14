using System.Threading.Tasks;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Models.MemberSystem;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;
using final_project_cmpickle.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace final_project_cmpickle.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class VendorController : Controller
    {
        private ILogger _logger;
        private IVendorRepository<Vendor> _vendorRepository;

        public VendorController(IVendorRepository<Vendor> vendorRepository, ILogger<VendorController> logger)
        {
            _vendorRepository = vendorRepository;
            _logger = logger;
        }

        [HttpGet]
        // [AllowAnonymous]
        public IActionResult RegisterVendor(string returnURL = null)
        {
            ViewData["ReturnURL"] = returnURL;
            return View();
        }

        [HttpPost]
        // [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterVendor(RegisterVendorViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                model.UserName = User.Identity.Name;
                var result = _vendorRepository.Create(model, HttpContext.User);
                if (result == Result.Success)
                {
                    _logger.LogInformation("User created a new account with password.");
                    var user = await _vendorRepository.FindByNameAsync(model.VendorName);

                    _logger.LogInformation("User created a new Vendor.");
                    return RedirectToLocal("/home/index");
                }
                // AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        #region Helpers

        // private void AddErrors(Result result)
        // {
        //     foreach (var error in result.Errors)
        //     {
        //         ModelState.AddModelError(string.Empty, error.Description);
        //     }
        // }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}