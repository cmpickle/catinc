using NUnit.Framework;
using final_project_cmpickle.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class MyVendorTests
    {
        private final_project_cmpickle.Models.Domain.Vendor vendor;

        [SetUp]
        public void SetUp()
        {
            vendor = new final_project_cmpickle.Models.Domain.Vendor();
        }

        [Test]
        public void SetVendorId()
        {
            vendor.VendorID = 31;

            Assert.That(vendor.VendorID == 31);
        }

        [Test]
        public void SetVendor()
        {
            vendor.VendorName = "Cantina";

            Assert.That(vendor.VendorName.Equals("Cantina"));
        }
    }
}