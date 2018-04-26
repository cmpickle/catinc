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

        /// <summary>
        /// Creates a vendor API object
        /// </summary>
        /// <param name="mySqlDbContext"></param>
        public VendorAPI(MySqlDbContext mySqlDbContext)
        {
            _mySqlDbContext = mySqlDbContext;
        }

        /// <summary>
        /// Returns all vendor objects in DB
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Vendor> GetAll()
        {
            return _mySqlDbContext.Vendors.ToList();
        }

        /// <summary>
        /// Returns a vendor object based on the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}")]
        public Vendor GetById(int id)
        {
            return _mySqlDbContext.Vendors.FirstOrDefault(v => v.VendorID == id);
        }
    }
}