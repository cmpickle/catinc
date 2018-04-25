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
    public class VendorRepository : IVendorRepository<Vendor>
    {
        int Count { get {return vendors.Count;} }
        List<Vendor> vendors;
        List<VendorUser> vendorUsers;
        private MySqlDbContext _mySqlDbContext;
        private IUserManager<MyIdentityUser> _identityUserManager;

        public VendorRepository(MySqlDbContext mySqlDbContext, IUserManager<MyIdentityUser> userManager)
        {
            _mySqlDbContext = mySqlDbContext;
            _identityUserManager = userManager;

            // using(MySqlDbContext context = _mySqlDbContext)
            // {
                vendors = _mySqlDbContext.Vendors.ToList();
                vendorUsers = _mySqlDbContext.VendorUsers.Include(vu => vu.Vendor).Include(vu => vu.User).ToList();
            // }
        }

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

            // using(MySqlDbContext context = _mySqlDbContext)
            // {
                _mySqlDbContext.Vendors.Add(vendor);
                _mySqlDbContext.VendorUsers.Add(vendorUser);
                _mySqlDbContext.SaveChanges();
            // }

            return Result.Success;
        }

        public Task<Vendor> FindByNameAsync(string name)
        {
            return Task.Run(() => vendors.FirstOrDefault(v => v.VendorName == name));
        }

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

        public IQueryable Get()
        {
            return vendors.AsQueryable();
        }

        public int GetCount()
        {
            return Count;
        }
    }
}