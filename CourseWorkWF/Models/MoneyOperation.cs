using CourseWorkWF.Interface.ModelInterface;
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
            set { if (value < 0) throw new AccessViolationException("Количествое денег не может быть отрицательным"); _moneyAmount = value; }
        }
        public OperationMethod Method { get; set; }
        public MoneyOperation(decimal moneyAmount, OperationMethod method)
        {
            MoneyAmount = moneyAmount;
            Method = method;

        }
    }
}
