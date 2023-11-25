namespace CourseWorkWF
{
    public class Buy : ProductsMove
    {
        private BuyProductsDictionary _productsList;
        private static int _buyID = 0;
        private int _discountPercent;
        public BuyProductsDictionary ProductsList 
        { 
            get { return _productsList; }
            set { if (value == null) throw new ArgumentNullException("Попытка сделать список пустым"); _productsList = value; }
        }
        public int BuyID 
        { 
            get { return _buyID; }
            set { if (value < 0) throw new AccessViolationException("Попытка задать отрицательное ID покупки"); _buyID = value; } 
        }
        public int Discount 
        {
            get { return _discountPercent; }
            set { if (value < 0 || value > 100) throw new AccessViolationException("Попытка задать скидку выходящую за рамки от 0 до 100"); _discountPercent = value; } 
        }
        public Buy(string transactionMetod, decimal moneyAmount, string cashierrName, BuyProductsDictionary productsList, int discount)
            : base(transactionMetod, moneyAmount, cashierrName)
        {
            ProductsList = productsList;
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierName = cashierrName;
            BuyID += 1;
            Discount = discount;
        }
        override public decimal ChangeRevenue(decimal revenue)
        {
            return revenue + MoneyAmount;
        }

    }
}
