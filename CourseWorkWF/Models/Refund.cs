namespace CourseWorkWF.Models
{
    public class Refund : ProductsMoveOperation
    {
        private string _reasonRefound;
        public string ReasonRefound { get { return _reasonRefound; } set { _reasonRefound = value; } }
        public Refund(Dictionary<int, ProductCollectionItem> productsList, string transactionMetod, decimal moneyAmount, string cashierrName, string reasonRefound)
         : base(productsList, transactionMetod, moneyAmount, cashierrName)
        {
            ProductsList = productsList;
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
