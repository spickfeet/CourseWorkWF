using CourseWorkWF.Interface.ModelInterface;

namespace CourseWorkWF.Models
{
    public class Product: IProduct
    {
        private string _productName;
        private decimal _price;
        private long _productID;
        public string ProductName
        {
            get { return _productName; } 
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("ProductName продукта не может быть пустое"); _productName = value; } 
        }
        public decimal Price 
        { 
            get { return _price; } 
            set { if (value < 0) throw new ArgumentOutOfRangeException("Price не может быть отрицательным"); _price = value; } 
        }
        public long ProductID
        {
            get { return _productID; }
            set { if (value < 0 ) throw new ArgumentOutOfRangeException("ProductID не может быть отрицательным"); _productID = value; }
        }
        public Product( string productName, decimal price, long productID )
        {
            ProductName = productName;
            Price = price;
            ProductID = productID;
        }

        public IProduct Clone()
        {
            return new Product(ProductName, Price, ProductID);
        }
    }
}
