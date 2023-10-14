using CourseWorkWF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CourseWorkWF.Program;

namespace CourseWorkWF
{
    public class Transaction
    {
        private TransactionMetod _transactionMetod; 
        private double _moneyAmount;
        private string _cashierrName;
        static private List<Product> _productsList;
        public TransactionMetod TransactionMetod { get { return _transactionMetod; } set { _transactionMetod = value; } }
        public double MoneyAmount { get { return _moneyAmount; } set { _moneyAmount = value; } }
        public string СashierrName { get { return _cashierrName; } set { _cashierrName = value; } }
        static public List<Product> ProductsList { get { return _productsList; } set { _productsList = value; } }
        public Transaction(TransactionMetod transactionMetod, double moneyAmount, string cashierrName, List<Product> productsList)
        {
            TransactionMetod = transactionMetod;
            MoneyAmount = moneyAmount;
            СashierrName = cashierrName;
            ProductsList = productsList;
        }
    }
}
