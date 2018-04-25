using NUnit.Framework;
using catinc.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class PatronTests
    {
        private Patron patron;

        [SetUp]
        public void SetUp()
        {
            patron = new Patron();
        }

        [Test]
        public void SetPatronId()
        {
            patron.PatronID = 26;

            Assert.That(patron.PatronID == 26);
        }

        [Test]
        public void SetPatronFirst()
        {
            patron.PatronFirst = "Luke";

            Assert.That(patron.PatronFirst.Equals("Luke"));
        }

        [Test]
        public void SetPatronLast()
        {
            patron.PatronLast = "Skywalker";

            Assert.That(patron.PatronLast.Equals("Skywalker"));
        }

        [Test]
        public void SetPatronAddress()
        {
            patron.PatronAddress = "145 Tatooine";

            Assert.That(patron.PatronAddress.Equals("145 Tatooine"));
        }

        [Test]
        public void SetPatronEmail()
        {
            patron.PatronEmail = "last.jedi@yavin4.rbl";

            Assert.That(patron.PatronEmail.Equals("last.jedi@yavin4.rbl"));
        }

        [Test]
        public void SetPatronTelephoneNo()
        {
            patron.PatronTelephoneNo = "801-555-5555";

            Assert.That(patron.PatronTelephoneNo.Equals("801-555-5555"));
        }

        [Test]
        public void SetPatronIsSuspended()
        {
            patron.IsPatronSuspended = true;

            Assert.That(patron.IsPatronSuspended == true);
        }

        [Test]
        public void SetPatronIsDeleted()
        {
            patron.IsPatronDeleted = true;

            Assert.That(patron.IsPatronDeleted == true);
        }

        [Test]
        public void SetPatronUserId()
        {
            patron.User = new MyIdentityUser {
                Id = "24"
            };

            Assert.That(patron.User.Id.Equals("24"));
        }
    }
}