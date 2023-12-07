namespace CourseWorkWF.Models
{
    public class Sell : ProductsMoveOperation
    {        
        private static int _sellID = 0;
        private int _discountPercent;
        public int SellID 
        { 
            get { return _sellID; }
            set { if (value < 0) throw new AccessViolationException("Попытка задать отрицательное ID покупки"); _sellID = value; } 
        }
        public int Discount 
        {
            get { return _discountPercent; }
            set { if (value < 0 || value > 100) throw new AccessViolationException("Попытка задать скидку выходящую за рамки от 0 до 100"); _discountPercent = value; } 
        }
        public Sell(Dictionary<int, ProductCollectionItem> productsList, string transactionMetod, decimal moneyAmount, string cashierrName, int discount)
            : base(productsList, transactionMetod, moneyAmount, cashierrName)
        {
            ProductsList = productsList;
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierName = cashierrName;
            SellID += 1;
            Discount = discount;
        }
        override public decimal ChangeRevenue(decimal revenue)
        {
            return revenue + MoneyAmount;
        }

    }
}
