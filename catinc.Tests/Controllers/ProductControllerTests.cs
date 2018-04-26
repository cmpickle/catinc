using NUnit.Framework;
using catinc.Controllers;
using catinc.Models.MemberSystem;
using catinc.Models.Domain;
using catinc.Tests.Mocks;
using Microsoft.AspNetCore.Mvc;
using catinc.Models.ViewModels.AccountViewModels;

namespace catinc.Tests.Controllers
{
    [TestFixture]
    public class ProductControllerTests
    {
        private ProductController productController;

        [SetUp]
        public void SetUp()
        {
            productController = new ProductController(new MockProductRepository(), new MockVendorRepository(), new MockLogger<VendorController>());
        }

        [Test]
        public void RouteToCreateProduct()
        {
            Assert.That(typeof(ViewResult).IsInstanceOfType(productController.CreateProduct()));
        }
    }
}