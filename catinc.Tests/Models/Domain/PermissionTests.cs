using NUnit.Framework;
using catinc.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class PermissionTests
    {
        private Permission permission;

        [SetUp]
        public void SetUp()
        {
            permission = new Permission();
        }

        [Test]
        public void SetPermissionId()
        {
            permission.PermissionID = 28;

            Assert.That(permission.PermissionID == 28);
        }

        [Test]
        public void SetUserId()
        {
            permission.User = new MyIdentityUser {
                Id = "29"
            };

            Assert.That(permission.User.Id.Equals("29"));
        }

        [Test]
        public void SetPermissionLevel()
        {
            permission.PermissionLevel = 30;

            Assert.That(permission.PermissionLevel == 30);
        }
    }
}