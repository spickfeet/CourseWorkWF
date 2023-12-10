using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IMoneyOperation
    {
        decimal MoneyAmount { get; set; }
        OperationMethod Method { get; set; }
        
    }
}
