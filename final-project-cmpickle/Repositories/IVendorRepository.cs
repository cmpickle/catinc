using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using final_project_cmpickle.Models.MemberSystem;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;

namespace final_project_cmpickle.Repositories
{
    public interface IVendorRepository<Vendor>
    {
        IQueryable Get();

        Task<Vendor> FindByNameAsync(string name);

        Task<Vendor> FindByUserID(string userID);

        Result Create(RegisterVendorViewModel registerVendorViewModel, ClaimsPrincipal user);
    }

}