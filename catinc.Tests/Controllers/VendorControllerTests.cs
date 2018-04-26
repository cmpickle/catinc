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
    public class VendorControllerTests
    {
        private VendorController vendorController;

        [SetUp]
        public void SetUp()
        {
            vendorController = new VendorController(new MockVendorRepository(), new MockLogger<VendorController>());
        }

        [Test]
        public void RouteToRegisterVendor()
        {
            Assert.That(typeof(ViewResult).IsInstanceOfType(vendorController.RegisterVendor()));
        }
    }
}