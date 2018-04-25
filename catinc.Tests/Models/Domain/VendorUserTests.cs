using NUnit.Framework;
using catinc.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class VendorUserTests
    {
        private VendorUser vendorUser;

        [SetUp]
        public void SetUp()
        {
            vendorUser = new VendorUser();
        }

        [Test]
        public void SetVendorUserId()
        {
            vendorUser.VendorUserId = 32;

            Assert.That(vendorUser.VendorUserId == 32);
        }

        [Test]
        public void SetVendorId()
        {
            vendorUser.Vendor = new Vendor {
                VendorID = 33
            };

            Assert.That(vendorUser.Vendor.VendorID == 33);
        }

        [Test]
        public void SetUserId()
        {
            vendorUser.User = new MyIdentityUser {
                Id = "34"
            };

            Assert.That(vendorUser.User.Id.Equals("34"));
        }
    }
}