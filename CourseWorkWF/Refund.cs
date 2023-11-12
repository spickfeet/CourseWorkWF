using CourseWorkWF;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF
{
    public class Refund : ProductsMove
    {
        private string _reasonRefound;
        public string ReasonRefound { get { return _reasonRefound; } set { _reasonRefound = value; } }
        public Refund(string transactionMetod, double moneyAmount, string cashierrName, string reasonRefound)
         : base(transactionMetod, moneyAmount, cashierrName)
        {
            TransactionMethod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierrName = cashierrName;
            ReasonRefound = reasonRefound;
        }
        override public double ChangeRevenue(double revenue)
        {
            return revenue - MoneyAmount;
        }
    }

}
