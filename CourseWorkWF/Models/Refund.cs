using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Models
{
    public class Refund : IRefund,IRevenueChanger
    {
        private string _reason;
        private IDictionary<long, IProductsCollectionItem> _products;
        private IMoneyOperation _moneyOperation;
        public IMoneyOperation MoneyOperation 
        {
            get { return _moneyOperation; }
            set { if (value == null) throw new ArgumentNullException("MoneyOperation не может быть null"); _moneyOperation = value; }
        }
        public IDictionary<long, IProductsCollectionItem> Products
        {
            get { return _products; }
            set { if (value == null) throw new ArgumentNullException("Products не может быть null"); _products = value; }
        }
        public string Reason 
        {
            get { return _reason; }
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Reason не может быть пустой"); _reason = value; }
        }

        public Refund(IDictionary<long, IProductsCollectionItem> products, IMoneyOperation moneyOperation, string reason)
        {
            Products = products;
            MoneyOperation = moneyOperation;
            Reason = reason;
        }
        public decimal ChangeRevenue(decimal revenue)
        {
            return revenue - MoneyOperation.MoneyAmount;
        }
    }

}
