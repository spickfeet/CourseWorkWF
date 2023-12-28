using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Models
{
    public class Sell : ISell, IRevenueChanger
    {
        private IMoneyOperation _moneyOperation;
        private IDictionary<long, IProductsCollectionItem> _products;
        private IDiscount _discount;
        public IMoneyOperation MoneyOperation 
        {
            get { return _moneyOperation; }
            private set { if (value == null) throw new ArgumentNullException("MoneyOperation не может быть null"); _moneyOperation = value; }
        }
        public IDictionary<long, IProductsCollectionItem> Products 
        { 
            get { return _products; }
            private set { if (value == null) throw new ArgumentNullException("Products не может быть null"); _products = value; }
        }

        public IDiscount Discount
        {
            get { return _discount; }
            private set { if (value == null) throw new ArgumentNullException("Discount не может быть null"); _discount = value; }
        }

        public Sell(IDictionary<long, IProductsCollectionItem> products, IMoneyOperation moneyOperation, IDiscount discount)
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
