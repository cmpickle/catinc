using System.Collections.Generic;
using System.Linq;
using catinc.Models.Database;
using catinc.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WingtipToys.Logic;

namespace catinc.Controllers.API
{
    /// <summary>
    /// The API is used to interact with products
    /// </summary>
    [Route("api/[controller]/[action]")]
    public class ProductAPI : Controller
    {
        private MySqlDbContext _mySqlDbContext;

        /// <summary>
        /// Creates the product API
        /// </summary>
        /// <param name="mySqlDbContext"></param>
        public ProductAPI(MySqlDbContext mySqlDbContext)
        {
            _mySqlDbContext = mySqlDbContext;
        }

        /// <summary>
        /// Gets all products in DB
        /// </summary>
        /// <returns>Product</returns>
        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _mySqlDbContext.Products.Include(p => p.Vendor).ToList();
        }

        /// <summary>
        /// Gets a product by Id from the Db
        /// </summary>
        /// <param name="Id"></param>
        /// /// <returns></returns>
        [HttpGet]
        // [Route("api/[controller]/{Id}")]
        public Product Get(int Id)
        {
            return _mySqlDbContext.Products.Include(p => p.Vendor).Where(p => p.ProductID == Id).SingleOrDefault();
        }

        [HttpPost]
        public void AddToCart()
        {
            HttpContextAccessor accessor = new HttpContextAccessor();
            ShoppingCartActions actions = new ShoppingCartActions(_mySqlDbContext);
            actions.AddToCart(accessor.HttpContext, 1);
        }
    }
}