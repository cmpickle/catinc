using System.Collections.Generic;
using System.Linq;
using final_project_cmpickle.Models.Database;
using final_project_cmpickle.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace final_project_cmpickle.Controllers.API
{
    [Route("api/[controller]")]
    public class VendorAPI : Controller
    {
        private MySqlDbContext _mySqlDbContext;

        public VendorAPI(MySqlDbContext mySqlDbContext)
        {
            _mySqlDbContext = mySqlDbContext;
        }

        [HttpGet]
        public IEnumerable<Vendor> GetAll()
        {
            return _mySqlDbContext.Vendor.ToList();
        }

        [HttpGet("{id:int}")]
        public Vendor GetById(int id)
        {
            return _mySqlDbContext.Vendor.FirstOrDefault(v => v.VendorID == id);
        }
    }
}