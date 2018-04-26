using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using catinc.Models.Domain;
using catinc.Models.MemberSystem;
using catinc.Models.ViewModels.ProductViewModels;
using catinc.Models.ViewModels.VendorViewModels;
using catinc.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace catinc.Controllers
{
    /// <summary>
    /// Product controller to deal with products
    /// </summary>
    [Authorize]
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        private ILogger _logger;
        private IProductRepository<Product> _productRepository;
        private IVendorRepository<Vendor> _vendorRepository;

        /// <summary>
        /// Creates the product controller
        /// </summary>
        /// <param name="productRepository"></param>
        /// <param name="vendorRepository"></param>
        /// <param name="logger"></param>
        public ProductController(IProductRepository<Product> productRepository, IVendorRepository<Vendor> vendorRepository, ILogger<VendorController> logger)
        {
            _productRepository = productRepository;
            _vendorRepository = vendorRepository;
            _logger = logger;
        }

        /// <summary>
        /// Returens the create product page
        /// </summary>
        /// <param name="returnURL"></param>
        /// <returns></returns>
        [HttpGet]
        // [AllowAnonymous]
        public IActionResult CreateProduct(string returnURL = null)
        {
            ViewData["ReturnURL"] = returnURL;
            return View();
        }

        /// <summary>
        /// Submits the create product model to create a product
        /// </summary>
        /// <param name="model"></param>
        /// <param name="returnUrl"></param>
        /// <returns></returns>
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