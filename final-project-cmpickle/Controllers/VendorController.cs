using System.Threading.Tasks;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;
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

        public VendorController(ILogger<VendorController> logger)
        {
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
                var result = 
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");
                    var user = _userRepository.FindByEmailAsync(model.Email).Result;

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