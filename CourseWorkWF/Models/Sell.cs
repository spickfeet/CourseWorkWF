using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Models
{
    public class Sell : ISell, IRevenueChanger
    {
        private IList<IProductsCollectionItem> _products;
        public IList<IProductsCollectionItem> Products 
        { 
            get { return _products; }
            set { if (value == null) throw new ArgumentNullException("Коллекция продуктов не может быть null"); _products = value; }
        }

        public IMoneyOperation MoneyOperation { get; set; }

        public Sell(IList<IProductsCollectionItem> products, IMoneyOperation moneyOperation)
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
