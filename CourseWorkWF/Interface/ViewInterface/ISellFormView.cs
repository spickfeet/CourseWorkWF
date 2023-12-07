using CourseWorkWF.Views;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface ISellFormView
    {
        int Discount { get; }
        OperationMethod OperationMethod { get; }
        decimal Cash { get; }
        decimal MoneyChangeBuyer { get; set; }
        string CashierName { get; }
        int ProductID { get; }
        decimal Amount { get; }
        decimal Price { get; set; }
        event EventHandler? AddProductEvent;
        event EventHandler? SellEvent;
        event EventHandler? DiscountEvent;
        event EventHandler? CancelDiscountEvent;
        event EventHandler? CancelBuyProductsEvent;
        event EventHandler? CashEvent;
    }
}
