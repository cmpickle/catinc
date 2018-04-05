using NUnit.Framework;
using final_project_cmpickle.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class MyUsersTests
    {
        MyUsers user;

        [SetUp]
        public void Setup()
        {
            user = new MyUsers();
        }

        [Test]
        public void SetUserIdTest()
        {
            user.UserID = 11;

            Assert.That(user.UserID == 11);
        }

        [Test]
        public void SetIdentityUserIdTest()
        {
            user.IdentityUserId = 12;

            Assert.That(user.IdentityUserId == 12);
        }

        [Test]
        public void SetIsUserDeletedTest()
        {
            user.IsUserDeleted = true;

            Assert.That(user.IsUserDeleted == true);
        }
    }
}