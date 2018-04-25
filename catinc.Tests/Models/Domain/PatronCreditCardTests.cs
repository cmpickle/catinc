using NUnit.Framework;
using catinc.Models.Domain;

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
            patronCreditcard.Patron = new Patron {
                PatronID = 26
            };

            Assert.That(patronCreditcard.Patron.PatronID == 26);
        }

        [Test]
        public void SetCreditCardId()
        {
            patronCreditcard.Creditcard = new Creditcard {
                CreditcardID = 27
            };

            Assert.That(patronCreditcard.Creditcard.CreditcardID == 27);
        }
    }
}