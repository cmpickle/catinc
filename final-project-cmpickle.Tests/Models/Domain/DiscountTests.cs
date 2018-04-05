using NUnit.Framework;
using final_project_cmpickle.Models.Domain;
using System;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class DiscountTests
    {
        private Discount discount;

        [SetUp]
        public void SetUp()
        {
            discount = new Discount();
        }

        [Test]
        public void SetDiscountIdTest()
        {
            discount.DiscountID = 16;

            Assert.That(discount.DiscountID == 16);
        }

        [Test]
        public void SetDiscountStartTest()
        {
            discount.DiscountStart = new DateTime(2018, 4, 5);

            Assert.That(discount.DiscountStart.CompareTo(new DateTime(2018, 4, 5)) == 0);
        }

        [Test]
        public void SetDiscountEndTest()
        {
            discount.DiscountEnd = new DateTime(2018, 5, 5);

            Assert.That(discount.DiscountEnd.CompareTo(new DateTime(2018, 5, 5)) == 0);
        }

        [Test]
        public void SetDiscountIsDeleted()
        {
            discount.IsDiscountDeleted = true;

            Assert.That(discount.IsDiscountDeleted = true);
        }
    }
}