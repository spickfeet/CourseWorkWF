using CourseWorkWF.Interface.ModelInterface;

namespace CourseWorkWF.Models
{
    public class Product: IProduct
    {
        private string _productName;
        private decimal _price;
        private int _productID;
        public string Name 
        {
            get { return _productName; } 
            set { if (value == null || value == "") throw new ArgumentException("Имя продукта не может быть пустое"); _productName = value; } 
        }
        public decimal Price 
        { 
            get { return _price; } 
            set { if (value < 0) throw new AccessViolationException("Цена продукта не может быть отрицательна"); _price = value; } 
        }
        public int ProductID
        {
            get { return _productID; }
            set { if (value < 0) throw new AccessViolationException("ID продукта не может быть отрицательным"); _productID = value; }
        }
        public Product( string name, decimal price, int productID )
        {
            Name = name;
            Price = price;
            ProductID = productID;
        }
    }
}
