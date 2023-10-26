using CourseWorkWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWTest
{
    public class Buy : Transaction
    {
        private List<Product> _productsList;
        private int _buyID;
        private int _discount;
        public List<Product> ProductsList { get { return _productsList; } set { _productsList = value; } }
        public int BuyID { get { return _buyID; } set { _buyID = value; } }
        public int Discount { get { return _discount; } set { _discount = value; } }
        public Buy(TransactionMethod transactionMetod, double moneyAmount, string cashierrName, List<Product> productsList, int buyID, int discount)
            : base(transactionMetod, moneyAmount, cashierrName)
        {
            ProductsList = productsList;
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierrName = cashierrName;
            BuyID = buyID;
            Discount = discount;
        }
        public void DiscountHave()
        {
            Calculator.DiscountUse(MoneyAmount, Discount);
        }
        override public double ChangeMoneyInCashRegister(double moneyInCashRegister)
        {
            return Calculator.Addition(moneyInCashRegister, MoneyAmount);
        }

    }
}
