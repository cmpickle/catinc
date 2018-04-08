using System.Threading.Tasks;
using final_project_cmpickle.Models.Domain;
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
        [AllowAnonymous]
        public IActionResult RegisterVendor(string returnURL = null)
        {
            ViewData["ReturnURL"] = returnURL;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVendorViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result = _vendorRepository.Create(model);
                if (result == Result.Success)
                {
                    _logger.LogInformation("User created a new account with password.");
                    var user = _vendorRepository.FindByName(model.VendorName);

                    var code = await _userRepository.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.EmailConfirmationLink(user.Id, code, Request.Scheme);
                    await _emailSender.SendEmailConfirmationAsync(model.Email, callbackUrl);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    _logger.LogInformation("User created a new account with password.");
                    return RedirectToLocal(returnUrl);
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
    }
}