using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Models.ViewModels.ProductViewModels;
using catinc.Models.Util;

namespace catinc.Repositories
{
    public class ProductRepository : IProductRepository<Product>
    {
        List<Product> products;
        private MySqlDbContext _mySqlDbContext;

        public ProductRepository(MySqlDbContext mySqlDbContext)
        {
            _mySqlDbContext = mySqlDbContext;

            // using(MySqlDbContext context = _mySqlDbContext)
            // {
                products = _mySqlDbContext.Products.ToList();
            // }
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
            product.Vendor = vendor;
            
            // using(MySqlDbContext context = _mySqlDbContext)
            // {
                _mySqlDbContext.Products.Add(product);
                _mySqlDbContext.SaveChanges();
            // }

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