namespace CourseWorkWF
{
    public class Product: IProduct
    {
        private string _productName;
        private decimal _price;
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
        public Product( string name, decimal price )
        {
            Name = name;
            Price = price;
        }
    }
}
