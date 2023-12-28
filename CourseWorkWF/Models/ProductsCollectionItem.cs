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
            private set { if (value == null) throw new ArgumentNullException("Product не может быть null"); _product = value; }
        }
        public decimal Amount
        {
            get { return _amount; }
            set { if (value < 0) throw new ArgumentOutOfRangeException("Amount не может быть отрицательным"); _amount = value; }
        }
        public ProductsCollectionItem(IProduct product, decimal amount)
        {
            Product = product;
            Amount = amount;
        }
    }
}
