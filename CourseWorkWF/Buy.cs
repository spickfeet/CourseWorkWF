using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CourseWorkWF
{
    public class Buy : Transaction
    {
        private int _buyID;
        private int _discount;
        public int BuyID { get { return _buyID; } set { _buyID = value; } }
        public int Discount { get { return _discount; } set { _discount = value; } }
        public Buy(TransactionMetod transactionMetod, double moneyAmount, string cashierrName, List<Product> productsList, int buyID, int discount)
            : base(transactionMetod, moneyAmount, cashierrName, productsList)
        {
            TransactionMetod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierrName = cashierrName;
            ProductsList = productsList;
            BuyID = buyID;
            Discount = discount;
        }
        public void DiscountHave()
        {
            Calculator.DiscountUse(MoneyAmount, Discount);
        }
        public void RemuveProductsInAssortment(List<Product> productInAssortment)
        {
            foreach (Product productInList in ProductsList)
            {
                productInAssortment.Remove(productInList);

            }
        }

        public double addIncome(double income)
        {
            Calculator.Addition(income, MoneyAmount);
            return income;
        }
    }
}
