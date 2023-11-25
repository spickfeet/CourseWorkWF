namespace CourseWorkWF
{
    public interface ISell
    {
        decimal Revenue { get; set; }
        int Discount { get; set; }
        string TransactionMethod { get; set; }
        decimal Cash { get; set; }
        decimal MoneyChangeBuyer { get; set; }
        string CashierName { get; set; }
        int ProductID { get; set; }
        decimal Amount { get; set; }
        decimal Price { get; set; }
        event EventHandler? AddProductEvent;
        event EventHandler? SellEvent;
        event EventHandler? DiscountEvent;
        event EventHandler? CancelDiscountEvent;
        event EventHandler? CancelBuyProductsEvent;
        event EventHandler? CashEvent;
    }
}
