using NUnit.Framework;
using final_project_cmpickle.Models.Domain;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class ProductOrderTests
    {
        private ProductOrder productOrder;

        [SetUp]
        public void SetUp()
        {
            productOrder = new ProductOrder();
        }

        [Test]
        public void SetProductOrderId()
        {
            productOrder.ProductOrderID = 27;

            Assert.That(productOrder.ProductOrderID == 27);
        }

        [Test]
        public void setProductId()
        {
            productOrder.ProductID = 28;

            Assert.That(productOrder.ProductID == 28);
        }

        [Test]
        public void SetOrderId()
        {
            productOrder.OrderID = 29;

            Assert.That(productOrder.OrderID == 29);
        }

        [Test]
        public void SetQuantity()
        {
            productOrder.Quantity = 30;

            Assert.That(productOrder.Quantity == 30);
        }
    }
}