using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_project_cmpickle.Models.Database;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Repositories;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;
using Microsoft.AspNetCore.Identity;
using final_project_cmpickle.Models.MemberSystem;
using System.Security.Claims;

namespace final_project_cmpickle.Repositories
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

            using(MySqlDbContext context = _mySqlDbContext)
            {
                vendors = context.Vendor.ToList();
                vendorUsers = context.VendorUser.ToList();
            }
        }

        public Result Create(RegisterVendorViewModel model, ClaimsPrincipal user)
        {
            Vendor vendor = new Vendor(model.VendorName, model.Address, model.TelephoneNo, model.Email, model.CreditcardNo);
            var myUser = _identityUserManager.FindByNameAsync(user.Identity.Name).Result;
            VendorUser vendorUser = new VendorUser{Vendor = vendor, User = myUser};
            vendors.Add(vendor);
            vendorUsers.Add(vendorUser);

            using(MySqlDbContext context = _mySqlDbContext)
            {
                context.Vendor.Add(vendor);
                context.VendorUser.Add(vendorUser);
                context.SaveChanges();
            }

            return Result.Success;
        }

        public Task<Vendor> FindByNameAsync(string name)
        {
            return Task.Run(() => vendors.FirstOrDefault(v => v.VendorName == name));
        }

        public Task<Vendor> FindByUserID(string userID)
        {
            var vendorUser = vendorUsers.FirstOrDefault(vu => vu.UserID == userID);
            return Task.Run(() => vendors.FirstOrDefault(v => v.VendorID == vendorUser.VendorID));
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