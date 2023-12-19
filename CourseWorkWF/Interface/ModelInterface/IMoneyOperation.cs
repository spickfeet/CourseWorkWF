using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IMoneyOperation
    {
        public decimal MoneyAmount { get; set; }
        public OperationMethod Method { get; set; }
        
    }
}
