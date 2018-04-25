using NUnit.Framework;
using catinc.Models.Domain;
using System;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class OrdersTests
    {
        private Orders order = new Orders();

        [SetUp]
        public void SetUp()
        {
            order = new Orders();
        }

        [Test]
        public void SetOrderId()
        {
            order.OrderID = 23;

            Assert.That(order.OrderID == 23);
        }

        [Test]
        public void SetUserId()
        {
            order.User = new MyIdentityUser {
                Id = "24"
            };

            Assert.That(order.User.Id.Equals("24"));
        }

        [Test]
        public void SetOrderTimestamp()
        {
            order.OrderTimestamp = new DateTime(2018, 4, 5);

            Assert.That(order.OrderTimestamp.Equals(new DateTime(2018, 4, 5)));
        }

        [Test]
        public void SetDiscountId()
        {
            order.Discount = new Discount {
                DiscountID = 25
            };

            Assert.That(order.Discount.DiscountID == 25);
        }
    }
}