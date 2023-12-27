using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface ISellFormView : IView
    {
        public int Discount { get; }
        public OperationMethod OperationMethod { get; }
        public decimal Cash { get; }
        public decimal MoneyChangeBuyer { get; set; }
        public long ProductID { get; }
        public decimal Amount { get; }
        public decimal Price { get; set; }
    }
}
