using System.Collections.Generic;
using System.Linq;
using catinc.Models.Database;
using catinc.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace catinc.Controllers.API
{
    /// <summary>
    /// The API is used to interact with products
    /// </summary>
    [Route("api/[controller]")]
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
    }
}