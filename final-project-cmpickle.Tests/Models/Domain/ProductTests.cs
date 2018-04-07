using NUnit.Framework;
using final_project_cmpickle.Models.Domain;
using System;

namespace Tests.Models.Domain
{
    [TestFixture]
    public class ProductTests
    {
        private Product product;

        [SetUp]
        public void SetUp()
        {
            product= new Product();
        }

        [Test]
        public void SetProductId()
        {
            product.ProductID = 31;

            Assert.That(product.ProductID == 31);
        }

        [Test]
        public void SetProductSKU()
        {
            product.ProductSKU = "SKU12345";

            Assert.That(product.ProductSKU.Equals("SKU12345"));
        }

        [Test]
        public void SetProductName()
        {
            product.ProductName = "Lightsaber";

            Assert.That(product.ProductName.Equals("Lightsaber"));
        }

        [Test]
        public void SetProductShortDescription()
        {
            product.ProductShortDescription = "This is a short Description.";

            Assert.That(product.ProductShortDescription.Equals("This is a short Description."));
        }

        [Test]
        public void SetProductLongDescription()
        {
            product.ProductLongDescription = "This is a long description of a product. This description will go on giving details about the product in greater length.";

            Assert.That(product.ProductLongDescription.Equals("This is a long description of a product. This description will go on giving details about the product in greater length."));
        }

        [Test]
        public void SetProductPrice()
        {
            product.ProductPrice = 1000.56m;

            Assert.That(product.ProductPrice==1000.56m);
        }

        [Test]
        public void SetProductInventory()
        {
            product.ProductInventory = 300;

            Assert.That(product.ProductInventory == 300);
        }

        [Test]
        public void SetProductExpirationDate()
        {
            product.ProductExpirationDate = new DateTime(2018, 4, 5);

            Assert.That(product.ProductExpirationDate.Equals(new DateTime(2018, 4, 5)));
        }

        [Test]
        public void SetProductIsDeleted()
        {
            product.IsProductedDeleted = true;

            Assert.That(product.IsProductedDeleted == true);
        }
    }
}