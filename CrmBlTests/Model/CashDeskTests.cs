using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrmBl.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            // Arrange
            var customer1 = new Customer()
            {
                Name = "testuser1",
                CustomerId = 1
            };
            var customer2 = new Customer()
            {
                Name = "testuser2",
                CustomerId = 2
            };

            var seller = new Seller()
            {
                Name = "testseller",
                SellerId = 1
            };

            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 1000,
                Count = 50
            };

            var product2 = new Product()
            {
                ProductId = 2,
                Name = "pr2",
                Price = 500,
                Count = 5220
            };

            var cart1 = new Cart(customer1);
            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);

            var cart2 = new Cart(customer1);
            cart2.Add(product2);
            cart2.Add(product1);
            cart2.Add(product2);

            var cashdesk = new CashDesk(1, seller);
            cashdesk.MaxQueueLenght = 10;
            cashdesk.Enqueue(cart1);
            cashdesk.Enqueue(cart2);

            var cart1ExpectedResult = 2500;
            var cart2ExpectedResult = 2000;

            // Act
            var cart1ActualResult = cashdesk.Dequeue();
            var cart2ActualResult = cashdesk.Dequeue();

            // Assert
            Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
            Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
            Assert.AreEqual(47, product1.Count);
            Assert.AreEqual(5217, product2.Count);
        }

    }
}