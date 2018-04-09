using System.Linq;
using System.Threading.Tasks;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;

namespace final_project_cmpickle.Repositories
{
    public interface IVendorRepository<Vendor>
    {
        IQueryable Get();

        Task<Vendor> FindByNameAsync(string name);

        Result Create(RegisterVendorViewModel registerVendorViewModel);
    }

}