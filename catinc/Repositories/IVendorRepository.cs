using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using catinc.Models.MemberSystem;
using catinc.Models.ViewModels.VendorViewModels;
using catinc.Models.Util;

namespace catinc.Repositories
{
    public interface IVendorRepository<Vendor>
    {
        IQueryable Get();

        Task<Vendor> FindByNameAsync(string name);

        Task<Vendor> FindByUserID(string userID);

        Result Create(RegisterVendorViewModel registerVendorViewModel, ClaimsPrincipal user);

        int GetCount();
    }

}