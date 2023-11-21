namespace CourseWorkWF
{
    public class Refund : ProductsMove
    {
        private string _reasonRefound;
        public string ReasonRefound { get { return _reasonRefound; } set { _reasonRefound = value; } }
        public Refund(string transactionMetod, decimal moneyAmount, string cashierrName, string reasonRefound)
         : base(transactionMetod, moneyAmount, cashierrName)
        {
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierName = cashierrName;
            ReasonRefound = reasonRefound;
        }
        override public decimal ChangeRevenue(decimal revenue)
        {
            return revenue - MoneyAmount;
        }
    }

}
