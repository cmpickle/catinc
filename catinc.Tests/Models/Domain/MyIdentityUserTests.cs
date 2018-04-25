using NUnit.Framework;
using catinc.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class MyIdentityUserTests
    {
        MyIdentityUser user;

        [SetUp]
        public void Setup()
        {
            user = new MyIdentityUser();
        }

        [Test]
        public void SetUserIdTest()
        {
            user.Id = "11";

            Assert.That(user.Id.Equals("11"));
        }
    }
}