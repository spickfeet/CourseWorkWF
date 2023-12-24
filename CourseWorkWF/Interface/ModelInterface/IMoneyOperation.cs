using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IMoneyOperation
    {
        public decimal MoneyAmount { get; }
        public OperationMethod Method { get; }
        
    }
}
