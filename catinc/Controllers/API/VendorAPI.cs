using System.Collections.Generic;
using System.Linq;
using catinc.Models.Database;
using catinc.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace catinc.Controllers.API
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
            return _mySqlDbContext.Vendors.ToList();
        }

        [HttpGet("{id:int}")]
        public Vendor GetById(int id)
        {
            return _mySqlDbContext.Vendors.FirstOrDefault(v => v.VendorID == id);
        }
    }
}