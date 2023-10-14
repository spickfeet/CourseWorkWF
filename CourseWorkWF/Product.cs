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
        private double _price;
        private DateTime _exDate;
        public int ProductID { get { return _productID; } set { if (value < 0) throw new AccessViolationException("ID продукта отрицательно"); _productID = value; } }
        public string Name { get { return _productName; } set { if (value == null) throw new ArgumentNullException("Имя продукта пустое"); _productName = value; } }
        public double Price { get { return _price; } set { if (value < 0) throw new AccessViolationException("Цена продукта отрицательна"); _price = value; } }
        public DateTime Exdate { get { return _exDate; } set { _exDate = value; } }
        public Product(int productID, string name, double price, DateTime exDate)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            Exdate = exDate;
        }
    }
}
