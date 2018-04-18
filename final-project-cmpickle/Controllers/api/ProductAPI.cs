using System.Collections.Generic;
using System.Linq;
using final_project_cmpickle.Models.Database;
using final_project_cmpickle.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace final_project_cmpickle.Controllers.API
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
            return _mySqlDbContext.Product.ToList();
        }
    }
}