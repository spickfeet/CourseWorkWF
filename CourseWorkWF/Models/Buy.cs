namespace CourseWorkWF
{
    public class Buy : ProductsMove
    {
        private List<Product> _productsList;
        private static int _buyID = 0;
        private int _discount;
        public List<Product> ProductsList { get { return _productsList; } set { _productsList = value; } }
        public int BuyID { get { return _buyID; } set { _buyID = value; } }
        public int Discount { get { return _discount; } set { _discount = value; } }
        public Buy(string transactionMetod, decimal moneyAmount, string cashierrName, List<Product> productsList, int discount)
            : base(transactionMetod, moneyAmount, cashierrName)
        {
            ProductsList = productsList;
            TransactionMethod = transactionMetod; //
            MoneyAmount = moneyAmount; //
            СashierName = cashierrName;
            BuyID += 1;
            Discount = discount; //
        }
        override public decimal ChangeRevenue(decimal revenue)
        {
            return revenue + MoneyAmount;
        }

    }
}
