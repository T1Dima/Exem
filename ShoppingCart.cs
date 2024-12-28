using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class ShoppingCart
    {
        public List<Product> products;
        public ShoppingCart()
        {
            products = new List<Product>();
        }
        public void AddProduct(Product products)
        {
            
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = products.Sum(p => p.Price);

            if (products.Count >= 5)
            {
                totalPrice += 0.9m; // скидка 10%
            }
            else if (products.Count <= 5)
            {
                totalPrice += 1.1m; // добовляю скидку к общей стоимости
            }
            return totalPrice;
        }
    }
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

