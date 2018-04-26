using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Repositories;
using catinc.Models.ViewModels.VendorViewModels;
using Microsoft.AspNetCore.Identity;
using catinc.Models.MemberSystem;
using System.Security.Claims;
using catinc.Models.Util;
using Microsoft.EntityFrameworkCore;

namespace catinc.Repositories
{
    /// <summary>
    /// Vendor repository for interacting with vendor objects in the DB
    /// </summary>
    public class VendorRepository : IVendorRepository<Vendor>
    {
        int Count { get {return vendors.Count;} }
        List<Vendor> vendors;
        List<VendorUser> vendorUsers;
        private MySqlDbContext _mySqlDbContext;
        private IUserManager<MyIdentityUser> _identityUserManager;

        /// <summary>
        /// Creates the vendor repository
        /// </summary>
        /// <param name="mySqlDbContext"></param>
        /// <param name="userManager"></param>
        public VendorRepository(MySqlDbContext mySqlDbContext, IUserManager<MyIdentityUser> userManager)
        {
            _mySqlDbContext = mySqlDbContext;
            _identityUserManager = userManager;

            vendors = _mySqlDbContext.Vendors.ToList();
            vendorUsers = _mySqlDbContext.VendorUsers.Include(vu => vu.Vendor).Include(vu => vu.User).ToList();
        }

        /// <summary>
        /// Creates a vendor in the DB
        /// </summary>
        /// <param name="model"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public Result Create(RegisterVendorViewModel model, ClaimsPrincipal user)
        {
            Vendor vendor = new Vendor {
                VendorName = model.VendorName, 
                VendorAddress = model.Address, 
                VendorTelephoneNo = model.TelephoneNo, 
                VendorEmail = model.Email, 
                VendorCreditcardNo = model.CreditcardNo
            };
            var myUser = _identityUserManager.FindByNameAsync(user.Identity.Name).Result;
            VendorUser vendorUser = new VendorUser{Vendor = vendor, User = myUser};
            vendors.Add(vendor);
            vendorUsers.Add(vendorUser);

            _mySqlDbContext.Vendors.Add(vendor);
            _mySqlDbContext.VendorUsers.Add(vendorUser);
            _mySqlDbContext.SaveChanges();

            return Result.Success;
        }

        /// <summary>
        /// Finds a vendor by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<Vendor> FindByNameAsync(string name)
        {
            return Task.Run(() => vendors.FirstOrDefault(v => v.VendorName == name));
        }

        /// <summary>
        /// Finds a vendor by user id
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public Task<Vendor> FindByUserID(string userID)
        {
            var vendorUser = vendorUsers.FirstOrDefault(vu => vu.User != null && vu.User.Id == userID);
            if (vendorUser == null)
            {
                return Task.Run(() => vendors.FirstOrDefault(v => v == null));
            }
            else
            {
                return Task.Run(() => vendors.FirstOrDefault(v => vendorUser.Vendor != null && v.VendorID == vendorUser.Vendor.VendorID));
            }
        }

        /// <summary>
        /// Gets all vendors
        /// </summary>
        /// <returns></returns>
        public IQueryable Get()
        {
            return vendors.AsQueryable();
        }

        /// <summary>
        /// Returns the count of vendors
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return Count;
        }
    }
}