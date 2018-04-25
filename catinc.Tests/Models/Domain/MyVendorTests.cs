using NUnit.Framework;
using catinc.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class MyVendorTests
    {
        private Vendor vendor;

        [SetUp]
        public void SetUp()
        {
            vendor = new Vendor();
        }

        [Test]
        public void SetVendorId()
        {
            vendor.VendorID = 31;

            Assert.That(vendor.VendorID == 31);
        }

        [Test]
        public void SetVendorName()
        {
            vendor.VendorName = "Cantina";

            Assert.That(vendor.VendorName.Equals("Cantina"));
        }

        [Test]
        public void SetVendorAddress()
        {
            vendor.VendorAddress = "Mos Eisley";

            Assert.That(vendor.VendorAddress.Equals("Mos Eisley"));
        }

        [Test]
        public void SetVendorTelephoneNo()
        {
            vendor.VendorTelephoneNo = "555-555-5555";

            Assert.That(vendor.VendorTelephoneNo.Equals("555-555-5555"));
        }

        [Test]
        public void SetVendorEmail()
        {
            vendor.VendorEmail = "cantina@tatooine.rim";

            Assert.That(vendor.VendorEmail.Equals("cantina@tatooine.rim"));
        }

        [Test]
        public void SetVendorPaymentAmount()
        {
            vendor.VendorPaymentAmount = 345.56m;

            Assert.That(vendor.VendorPaymentAmount == 345.56m);
        }

        [Test]
        public void SetVendorCreditcardNo()
        {
            vendor.VendorCreditcardNo = 123456789;

            Assert.That(vendor.VendorCreditcardNo == 123456789);
        }

        [Test]
        public void SetVendorIsActive()
        {
            vendor.IsVendorActive = true;

            Assert.That(vendor.IsVendorActive == true);
        }

        [Test]
        public void SetVendorIsSuspended()
        {
            vendor.IsVendorSuspended = true;

            Assert.That(vendor.IsVendorSuspended == true);
        }

        [Test]
        public void setVendorIsDeleted()
        {
            vendor.IsVendorDeleted = true;

            Assert.That(vendor.IsVendorDeleted);
        }
    }
}