using NUnit.Framework;
using final_project_cmpickle.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class PatronCreditCardTests
    {
        private PatronCreditcard patronCreditcard;

        [SetUp]
        public void SetUp()
        {
            patronCreditcard = new PatronCreditcard();
        }

        [Test]
        public void SetPatronCreditcardID()
        {
            patronCreditcard.PatronCreditcardID = 25;

            Assert.That(patronCreditcard.PatronCreditcardID == 25);
        }

        [Test]
        public void SetPatronId()
        {
            patronCreditcard.PatronID = 26;

            Assert.That(patronCreditcard.PatronID == 26);
        }

        [Test]
        public void SetCreditCardId()
        {
            patronCreditcard.CreditcardID = 27;

            Assert.That(patronCreditcard.CreditcardID == 27);
        }
    }
}