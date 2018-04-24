using System.Linq;
using System.Threading.Tasks;
using catinc.Models.Domain;
using catinc.Models.ViewModels.ProductViewModels;
using catinc.Models.Util;

namespace catinc.Repositories
{
    public interface IProductRepository<Product>
    {
        IQueryable Get();

        Task<Product> FindByNameAsync(string name);

        Task<Product> FindByProductIDAsync(string productID);

        Result Create(CreateProductViewModel registerVendorViewModel, Vendor vendor);
    }

}