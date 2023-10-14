using CourseWorkWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CourseWorkWF
{
    public class Refund : Transaction
    {
        private string _reasonRefound;
        public string ReasonRefound { get { return _reasonRefound; } set { _reasonRefound = value; } }
        public Refund(TransactionMetod transactionMetod, double moneyAmount, int operationID, string cashierrName, List<Product> productsList, string reasonRefound)
         : base(transactionMetod, moneyAmount, cashierrName, productsList)
        {
            TransactionMetod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierrName = cashierrName;
            ProductsList = productsList;
            ReasonRefound = reasonRefound;
        }
        public double DiffBank(double income)
        {
            return Calculator.Difference(income, MoneyAmount);
        }
    }
}
