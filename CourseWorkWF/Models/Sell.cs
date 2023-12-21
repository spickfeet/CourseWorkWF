using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Models
{
    public class Sell : ISell, IRevenueChanger
    {
        private IDictionary<int, IProductsCollectionItem> _products;
        private IDiscount _discount;
        public IMoneyOperation MoneyOperation { get; set; }
        public IDictionary<int, IProductsCollectionItem> Products 
        { 
            get { return _products; }
            set { if (value == null) throw new ArgumentNullException("Products не может быть null"); _products = value; }
        }

        public IDiscount Discount
        {
            get { return _discount; }
            set { if (value == null) throw new ArgumentNullException("Discount не может быть null"); _discount = value; }
        }

        public Sell(IDictionary<int, IProductsCollectionItem> products, IMoneyOperation moneyOperation, IDiscount discount)
        {
            Products = products;
            MoneyOperation = moneyOperation;
            Discount = discount;
        }
        public decimal ChangeRevenue(decimal revenue)
        {   
            return revenue + MoneyOperation.MoneyAmount;
        }
    }
}
