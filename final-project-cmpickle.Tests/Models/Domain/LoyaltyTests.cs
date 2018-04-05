using NUnit.Framework;
using final_project_cmpickle.Models.Domain;

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
            loyalty.UserID = 21;

            Assert.That(loyalty.UserID == 21);
        }

        [Test]
        public void SetLoyaltyPoints()
        {
            loyalty.LoyaltyPoints = 22;

            Assert.That(loyalty.LoyaltyPoints == 22);
        }
    }
}