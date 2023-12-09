using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Views;

namespace CourseWorkWF.Models
{
    public class Sell : ISell, IRevenueChanger
    {
        private int _sellID;
        private IEnumerable<IProductsCollectionItem> _products;
        public int SellID
        { 
            get { return _sellID; }
            set { if (value < 0) throw new AccessViolationException("Попытка задать отрицательное ID покупки"); _sellID = value; } 
        }

        public IEnumerable<IProductsCollectionItem> Products 
        { 
            get { return _products; }
            set { if (value == null) throw new ArgumentNullException("Колекция продуктов не может быть null"); _products = value; }
        }

        public IMoneyOperation MoneyOperation { get; set; }

        public Sell(int sellID, IList<IProductsCollectionItem> products, decimal price, OperationMethod payMethod)
        {
            SellID = sellID;
            Products = products;
            MoneyOperation = new MoneyOperation(price, payMethod);
        }
        public decimal ChangeRevenue(decimal revenue)
        {
            return revenue + MoneyOperation.MoneyAmount;
        }

    }
}
