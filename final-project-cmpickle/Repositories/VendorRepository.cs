using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_project_cmpickle.Models.Database;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Models.ViewModels.VendorViewModels;

public class VendorRepository : IVendorRepository<Vendor>
{
    List<Vendor> vendors;
    private MySqlDbContext _mySqlDbContext;

    public VendorRepository(MySqlDbContext mySqlDbContext)
    {
        _mySqlDbContext = mySqlDbContext;
    }

    public Vendor Create(RegisterVendorViewModel model)
    {
        Vendor vendor = new Vendor(model.VendorName, model.Address, model.TelephoneNo, model.Email, model.CreditcardNo);

        using(MySqlDbContext context = _mySqlDbContext)
        {
            context.Vendor.Add(vendor);
            context.SaveChanges();
        }

        return vendor;
    }

    public Vendor FindByNameAsync(string name)
    {
        return vendors.FirstOrDefault(v => v.VendorName == name)
    }

    public IQueryable Get()
    {
        return vendors.AsQueryable();
    }
}
