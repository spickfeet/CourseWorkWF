using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF
{
    public class Product
    {
        private int _productID;
        private string _productName;
        private decimal _price;
        private int _amount;
        public int ProductID { get { return _productID; } set { if (value < 0) throw new AccessViolationException("ID продукта отрицательно"); _productID = value; } }
        public string Name { get { return _productName; } set { if (value == null) throw new ArgumentNullException("Имя продукта пустое"); _productName = value; } }
        public decimal Price { get { return _price; } set { if (value < 0) throw new AccessViolationException("Цена продукта отрицательна"); _price = value; } }
        public int Amount { get { return _amount; } set { if (value < 0) throw new AccessViolationException("Число продуктов отрицательно"); _amount = value; } }
        public Product(int productID, string name, decimal price, int _amount)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Amount = _amount;
        }
        public Product(Product product)
        {
            ProductID = product.ProductID;
            Name = product.Name;
            Price = product.Price;
            Amount = product.Amount;
        }
    }
}
