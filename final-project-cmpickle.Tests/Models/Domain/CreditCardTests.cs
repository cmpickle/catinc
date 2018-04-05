using NUnit.Framework;
using final_project_cmpickle.Models.Domain;
using System;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class CreditCardTests
    {
        private Creditcard creditcard;

        [SetUp]
        public void SetUp()
        {
            creditcard = new Creditcard();
        }

        [Test]
        public void SetCreditcardIdTest()
        {
            creditcard.CreditcardID = 13;

            Assert.That(creditcard.CreditcardID == 13);
        }

        [Test]
        public void SetCreditcardNoTest()
        {
            creditcard.CreditcardNo = 14;

            Assert.That(creditcard.CreditcardNo == 14);
        }

        [Test]
        public void SetExpirationDate()
        {
            creditcard.ExpirationDate = new DateTime(2000, 3, 4);

            Assert.NotNull(creditcard.ExpirationDate);
            Assert.That(creditcard.ExpirationDate.CompareTo(new DateTime(2000, 3, 4)) == 0);
        }

        [Test]
        public void SetCCV()
        {
            creditcard.CCV = 15;

            Assert.That(creditcard.CCV == 15);
        }
    }
}