﻿using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Models
{
    internal class MoneyOperation : IMoneyOperation
    {
        private decimal _moneyAmount;
        public decimal MoneyAmount 
        {
            get { return _moneyAmount; }
            private set { if (value < 0) throw new ArgumentOutOfRangeException("MoneyAmount не может быть отрицательным"); _moneyAmount = value; }
        }
        public OperationMethod Method { get; private set; }
        public MoneyOperation(decimal moneyAmount, OperationMethod method)
        {
            MoneyAmount = moneyAmount;
            Method = method;
        }
    }
}
