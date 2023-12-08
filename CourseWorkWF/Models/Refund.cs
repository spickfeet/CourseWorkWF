using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Views;

namespace CourseWorkWF.Models
{
    public class Refund : IRefund,IRevenueChanger
    {
        private string _reason;
        private int _refundID;
        private IEnumerable<IProductsCollectionItem> _products;
        public IMoneyOperation MoneyOperation { get; set; }
        public int RefundID
        {
            get { return _refundID; }
            set { if (value < 0) throw new AccessViolationException("Попытка задать отрицательное ID возврата"); _refundID = value; }
        }
        public IEnumerable<IProductsCollectionItem> Products
        {
            get { return _products; }
            set { if (value == null) throw new ArgumentNullException("Колекция продуктов не может быть null"); _products = value; }
        }
        public string Reason 
        {
            get { return _reason; }
            set { if (value == null || value == "") throw new ArgumentNullException("Причина возврата не может быть пустой"); _reason = value; }
        }

        public Refund(int refundID, IEnumerable<ProductsCollectionItem> products, decimal moneyAmount, OperationMethod payMethod, string reason)
        {
            RefundID = refundID;
            Products = products;
            MoneyOperation = new MoneyOperation(moneyAmount, payMethod);
            Reason = reason;
        }
        public decimal ChangeRevenue(decimal revenue)
        {
            return revenue - MoneyOperation.MoneyAmount;
        }
    }

}
