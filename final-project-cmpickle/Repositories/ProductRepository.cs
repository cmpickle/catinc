using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_project_cmpickle.Models.Database;
using final_project_cmpickle.Models.Domain;
using final_project_cmpickle.Models.ViewModels.ProductViewModels;

namespace final_project_cmpickle.Repositories
{
    public class ProductRepository : IProductRepository<Product>
    {
        List<Product> products;
        private MySqlDbContext _mySqlDbContext;

        public ProductRepository(MySqlDbContext mySqlDbContext)
        {
            _mySqlDbContext = mySqlDbContext;

            using(MySqlDbContext context = _mySqlDbContext)
            {
                products = context.Product.ToList();
            }
        }

        public Result Create(CreateProductViewModel createProductViewModel, Vendor vendor)
        {
            var product = new Product();
            product.ProductName = createProductViewModel.ProductName;
            product.ProductPrice = createProductViewModel.ProductPrice;
            product.ProductInventory = createProductViewModel.ProductInventory;
            product.ProductImageURL = createProductViewModel.ProductImageURL;
            product.ProductExpirationDate = createProductViewModel.ProductExpirationDate;
            product.ProductShortDescription = createProductViewModel.ProductShortDescription;
            product.ProductLongDescription = createProductViewModel.ProductLongDescription;
            product.VendorID = vendor.VendorID;
            
            using(MySqlDbContext context = _mySqlDbContext)
            {
                context.Product.Add(product);
                context.SaveChanges();
            }

            return Result.Success;
        }

        public Task<Product> FindByNameAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> FindByProductIDAsync(string productID)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable Get()
        {
            throw new System.NotImplementedException();
        }
    }
}