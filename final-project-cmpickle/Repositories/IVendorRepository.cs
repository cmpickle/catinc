using System.Linq;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;

namespace final_project_cmpickle.Repositories
{
    public interface IVendorRepository<Vendor>
    {
        IQueryable Get();

        Vendor FindByName(string name);

        Result Create(RegisterVendorViewModel registerVendorViewModel);
    }

}