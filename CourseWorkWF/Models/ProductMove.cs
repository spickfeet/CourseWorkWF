namespace CourseWorkWF
{
    public abstract class ProductsMove
    {
        private string _transactionMethod;
        private decimal _moneyAmount;
        private string _cashierName;
        public string TransactionMethod { get { return _transactionMethod; } set { _transactionMethod = value; } }
        public decimal MoneyAmount { get { return _moneyAmount; } set { _moneyAmount = value; } }
        public string СashierName { get { return _cashierName; } set { _cashierName = value; } }
        public ProductsMove(string transactionMetod, decimal moneyAmount, string cashierrName)
        {
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierName = cashierrName;
        }
        public abstract decimal ChangeRevenue(decimal revenue);
    }
}
