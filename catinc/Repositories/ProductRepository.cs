using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catinc.Models.Database;
using catinc.Models.Domain;
using catinc.Models.ViewModels.ProductViewModels;
using catinc.Models.Util;

namespace catinc.Repositories
{
    /// <summary>
    /// product repository for accessing products from the DB
    /// </summary>
    public class ProductRepository : IProductRepository<Product>
    {
        List<Product> products;
        private MySqlDbContext _mySqlDbContext;

        /// <summary>
        /// Creates a product repository
        /// </summary>
        /// <param name="mySqlDbContext"></param>
        public ProductRepository(MySqlDbContext mySqlDbContext)
        {
            _mySqlDbContext = mySqlDbContext;

            products = _mySqlDbContext.Products.ToList();
        }

        /// <summary>
        /// Create a product in the DB
        /// </summary>
        /// <param name="createProductViewModel"></param>
        /// <param name="vendor"></param>
        /// <returns></returns>
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
            
            _mySqlDbContext.Products.Add(product);
            _mySqlDbContext.SaveChanges();

            return Result.Success;
        }

        /// <summary>
        /// Finds a product by name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<Product> FindByNameAsync(string name)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Finds a product by id
        /// </summary>
        /// <param name="productID"></param>
        /// <returns></returns>
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