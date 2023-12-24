using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface ISellFormView
    {
        public int Discount { get; }
        public OperationMethod OperationMethod { get; }
        public decimal Cash { get; }
        public decimal MoneyChangeBuyer { get; set; }
        public long ProductID { get; }
        public decimal Amount { get; }
        public decimal Price { get; set; }
        public string EmployeeFullName { set; }
        public event EventHandler? AddProductEvent;
        public event EventHandler? SellEvent;
        public event EventHandler? DiscountEvent;
        public event EventHandler? CancelDiscountEvent;
        public event EventHandler? CancelBuyProductsEvent;
        public event EventHandler? CashEvent;
    }
}
