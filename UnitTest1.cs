using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cart = new ShoppingCart();
            cart.AddProduct(new Product() { Name = "Product 1", Price = 10 });
            cart.AddProduct(new Product() { Name = "Product 2", Price = 20 });
            cart.AddProduct(new Product() { Name = "Product 3", Price = 30 });
            cart.AddProduct(new Product() { Name = "Product 4", Price = 40 });
            cart.AddProduct(new Product() { Name = "Product 5", Price = 50 });

            decimal totalPrice = cart.GetTotalPrice();

            Assert.AreEqual(155, totalPrice);
        }
        [TestMethod]
       
        public void TestPriceIncrease()
        {
            var cart = new ShoppingCart();
            cart.AddProduct(new Product() { Name = "Product 1", Price = 10 });
            cart.AddProduct(new Product() { Name = "Product 2", Price = 20 });
            decimal totalPrice = cart.GetTotalPrice();

            Assert.AreEqual(33, totalPrice); // общая стоимость с добавлением 10% 
        }
    }
}
