using NUnit.Framework;
using catinc.Models.Domain;

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
            permission.VendorUser = new VendorUser {
                VendorUserId = 29
            };

            Assert.That(permission.VendorUser.VendorUserId == 29);
        }

        [Test]
        public void SetPermissionLevel()
        {
            permission.PermissionLevel = 30;

            Assert.That(permission.PermissionLevel == 30);
        }
    }
}