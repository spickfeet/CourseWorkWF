using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF
{
    public abstract class ProductsMove
    {
        private string _transactionMethod;
        private double _moneyAmount;
        private string _cashierName;
        public string TransactionMethod { get { return _transactionMethod; } set { _transactionMethod = value; } }
        public double MoneyAmount { get { return _moneyAmount; } set { _moneyAmount = value; } }
        public string СashierName { get { return _cashierName; } set { _cashierName = value; } }
        public ProductsMove(string transactionMetod, double moneyAmount, string cashierrName)
        {
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierName = cashierrName;
        }
        public abstract double ChangeRevenue(double revenue);
    }
}
