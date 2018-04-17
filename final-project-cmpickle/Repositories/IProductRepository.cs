using System.Linq;
using System.Threading.Tasks;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Models.ViewModels.ProductViewModels;

namespace final_project_cmpickle.Repositories
{
    public interface IProductRepository<Product>
    {
        IQueryable Get();

        Task<Product> FindByNameAsync(string name);

        Task<Product> FindByProductIDAsync(string productID);

        Result Create(CreateProductViewModel registerVendorViewModel, Vendor vendor);
    }

}