namespace CourseWorkWF
{
    public class Product: IProduct
    {
        private int _productID;
        private string _productName;
        private decimal _price;
        public int ProductID { 
            get { return _productID; } 
            set { if (value < 0) throw new AccessViolationException("ID продукта не может быть отрицательным"); _productID = value; 
            } }
        public string Name 
        {
            get { return _productName; } 
            set { if (value == null) throw new ArgumentNullException("Имя продукта не может быть пустое"); _productName = value; } 
        }
        public decimal Price 
        { 
            get { return _price; } 
            set { if (value < 0) throw new AccessViolationException("Цена продукта не может быть отрицательна"); _price = value; } 
        }
        public Product(int productID, string name, decimal price )
        {
            ProductID = productID;
            Name = name;
            Price = price;
        }
    }
}
