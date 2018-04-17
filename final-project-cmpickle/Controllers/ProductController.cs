using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Models.MemberSystem;
using final_project_cmpickle.Models.ViewModels.ProductViewModels;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;
using final_project_cmpickle.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace final_project_cmpickle.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        private ILogger _logger;
        private IProductRepository<Product> _productRepository;
        private IVendorRepository<Vendor> _vendorRepository;

        public ProductController(IProductRepository<Product> productRepository, IVendorRepository<Vendor> vendorRepository, ILogger<VendorController> logger)
        {
            _productRepository = productRepository;
            _vendorRepository = vendorRepository;
            _logger = logger;
        }

        [HttpGet]
        // [AllowAnonymous]
        public IActionResult CreateProduct(string returnURL = null)
        {
            ViewData["ReturnURL"] = returnURL;
            return View();
        }

        [HttpPost]
        // [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public Task<IActionResult> CreateProduct(CreateProductViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
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
                // model.UserName = User.Identity.Name;
                var result = _vendorRepository.FindByUserID(userIdValue).Result;
                if (result != null)
                {
                    _productRepository.Create(model, result);
                    _logger.LogInformation("Product created.");

                    return Task.Run(() => RedirectToLocal("/home/index"));
                }
                // AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            // return Task.Run(() => View(model));
            return null;
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