using CourseWorkWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CourseWorkWF.Program;

namespace CourseWorkWF
{
    public abstract class Transaction
    {
        private TransactionMethod _transactionMethod;
        private double _moneyAmount;
        private string _cashierName;  
        public TransactionMethod TransactionMethod { get { return _transactionMethod; } set { _transactionMethod = value; } }
        public double MoneyAmount { get { return _moneyAmount; } set { _moneyAmount = value; } }
        public string СashierrName { get { return _cashierName; } set { _cashierName = value; } }
        public Transaction(TransactionMethod transactionMetod, double moneyAmount, string cashierrName)
        {
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierrName = cashierrName;
        }
        public abstract double ChangeMoneyInCashRegister(double moneyInCashRegister);
    }
}
