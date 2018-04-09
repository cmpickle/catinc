using NUnit.Framework;
using final_project_cmpickle.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class VendorUserPermissionTests
    {
        private VendorUserPermission permission;

        [SetUp]
        public void SetUp()
        {
            permission = new VendorUserPermission();
        }

        [Test]
        public void SetVendorUserPermissionId()
        {
            permission.VendorUserPermissionID = 28;

            Assert.That(permission.VendorUserPermissionID == 28);
        }

        [Test]
        public void SetVendorUserID()
        {
            permission.VendorUserID = 29;

            Assert.That(permission.VendorUserID == 29);
        }

        [Test]
        public void SetPermissionLevel()
        {
            permission.PermissionLevel = 30;

            Assert.That(permission.PermissionLevel == 30);
        }
    }
}