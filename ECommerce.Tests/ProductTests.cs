using NUnit.Framework;
using ProductApp;
using System;

namespace ECommerce.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void ProductConstructor_ValidValues_ShouldCreateProduct()
        {
            var product = new Product(100, "Laptop", 1500m, 100);

            Assert.Multiple(() =>
            {
                Assert.That(product.ProdID, Is.EqualTo(100));
                Assert.That(product.ProdName, Is.EqualTo("Laptop"));
                Assert.That(product.ItemPrice, Is.EqualTo(1500m));
                Assert.That(product.StockAmount, Is.EqualTo(100));
            });
        }

        [Test]
        public void IncreaseStock_ValidAmount_ShouldIncreaseStock()
        {
            var product = new Product(100, "Laptop", 1500m, 100);
            product.IncreaseStock(50);
            Assert.That(product.StockAmount, Is.EqualTo(150));
        }

        [Test]
        public void DecreaseStock_ValidAmount_ShouldDecreaseStock()
        {
            var product = new Product(100, "Laptop", 1500m, 100);
            product.DecreaseStock(30);
            Assert.That(product.StockAmount, Is.EqualTo(70));
        }

        [Test]
        public void DecreaseStock_MoreThanAvailable_ShouldThrowException()
        {
            var product = new Product(100, "Laptop", 1500m, 10);
            Assert.Throws<InvalidOperationException>(() => product.DecreaseStock(20));
        }
    }
}
