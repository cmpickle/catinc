using System.Collections.Generic;
using System.Linq;
using catinc.Models.Database;
using catinc.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace catinc.Controllers.API
{
    [Route("api/[controller]")]
    public class ProductAPI : Controller
    {
        private MySqlDbContext _mySqlDbContext;

        public ProductAPI(MySqlDbContext mySqlDbContext)
        {
            _mySqlDbContext = mySqlDbContext;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _mySqlDbContext.Products.Include(p => p.Vendor).ToList();
        }
    }
}