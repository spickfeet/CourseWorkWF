using CourseWorkWF.Interface.ModelInterface;

namespace CourseWorkWF.Models
{
    public class ProductsCollectionItem : IProductsCollectionItem
    {
        private IProduct _product;
        private decimal _amount;
        public IProduct Product
        {
            get { return _product; }
            set { if (value == null) throw new ArgumentNullException("Попытка присвоить значение null в _product"); _product = value; }
        }
        public decimal Amount
        {
            get { return _amount; }
            set { if (value < 0) throw new AccessViolationException("Количество продукта не может быть отрицательным"); _amount = value; }
        }
        public ProductsCollectionItem(string productName, decimal price, int productID, decimal amount)
        {
            Product = new Product(productName, price, productID);
            Amount = amount;
        }
    }
}
