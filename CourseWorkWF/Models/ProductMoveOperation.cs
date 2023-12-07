using CourseWorkWF.Interface;

namespace CourseWorkWF.Models
{
    public abstract class ProductsMoveOperation: IRevenueChanger
    {
        private Dictionary<int, ProductCollectionItem> _productsList;
        private string _transactionMethod;
        private decimal _moneyAmount;
        private string _cashierName;
        public Dictionary<int, ProductCollectionItem> ProductsList
        {
            get { return _productsList; }
            set { if (value == null) throw new ArgumentNullException("Попытка сделать список пустым"); _productsList = value; }
        }
        public string TransactionMethod 
        {
            get { return _transactionMethod; } 
            set { _transactionMethod = value; } 
        }
        public decimal MoneyAmount 
        {
            get { return _moneyAmount; } 
            set { _moneyAmount = value; } 
        }
        public string СashierName 
        {
            get { return _cashierName; } 
            set { _cashierName = value; } 
        }
        public ProductsMoveOperation(Dictionary<int, ProductCollectionItem> _productsList, string transactionMetod, decimal moneyAmount, string cashierrName)
        {
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierName = cashierrName;
        }
        public abstract decimal ChangeRevenue(decimal revenue);
    }
}
