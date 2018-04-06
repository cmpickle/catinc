using NUnit.Framework;
using final_project_cmpickle.Models.Domain;

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
            vendorUser.VendorUserID = 32;

            Assert.That(vendorUser.VendorUserID == 32);
        }

        [Test]
        public void SetVendorId()
        {
            vendorUser.VendorID = 33;

            Assert.That(vendorUser.VendorID == 33);
        }

        [Test]
        public void SetUserId()
        {
            vendorUser.UserID = 34;

            Assert.That(vendorUser.UserID == 34);
        }
    }
}