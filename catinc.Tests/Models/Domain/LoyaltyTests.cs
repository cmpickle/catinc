using NUnit.Framework;
using catinc.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class LoyaltyTests
    {
        private Loyalty loyalty;

        [SetUp]
        public void SetUp()
        {
            loyalty = new Loyalty();
        }

        [Test]
        public void SetLoyaltyId()
        {
            loyalty.LoyaltyID = 20;

            Assert.That(loyalty.LoyaltyID == 20);
        }

        [Test]
        public void SetUserId()
        {
            loyalty.User = new MyIdentityUser {
                Id = "21"
            };

            Assert.That(loyalty.User.Id.Equals("21"));
        }

        [Test]
        public void SetLoyaltyPoints()
        {
            loyalty.LoyaltyPoints = 22;

            Assert.That(loyalty.LoyaltyPoints == 22);
        }
    }
}