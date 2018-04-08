using System.Linq;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;

public interface IVendorRepository<Vendor>
{
    IQueryable Get();

    Vendor FindByNameAsync(string name);

    Vendor Create(RegisterVendorViewModel registerVendorViewModel);
}