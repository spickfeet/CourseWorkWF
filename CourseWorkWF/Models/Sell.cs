using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Models
{
    public class Sell : ISell, IRevenueChanger
    {
        private IDictionary<int, IProductsCollectionItem> _products;
        public IMoneyOperation MoneyOperation { get; set; }
        public IDictionary<int, IProductsCollectionItem> Products 
        { 
            get { return _products; }
            set { if (value == null) throw new ArgumentNullException("Products не может быть null"); _products = value; }
        }
        public Sell(IDictionary<int, IProductsCollectionItem> products, IMoneyOperation moneyOperation)
        {
            Products = products;
            MoneyOperation = moneyOperation;
        }
        public decimal ChangeRevenue(decimal revenue)
        {   
            return revenue + MoneyOperation.MoneyAmount;
        }
    }
}
