using NUnit.Framework;
using catinc.Models.Domain;

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
            productOrder.Product = new Product {
                ProductID = 28
            };

            Assert.That(productOrder.Product.ProductID == 28);
        }

        [Test]
        public void SetOrderId()
        {
            productOrder.Order = new Orders { 
                OrderID = 29
            };

            Assert.That(productOrder.Order.OrderID == 29);
        }

        [Test]
        public void SetQuantity()
        {
            productOrder.Quantity = 30;

            Assert.That(productOrder.Quantity == 30);
        }
    }
}