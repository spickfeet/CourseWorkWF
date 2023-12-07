namespace CourseWorkWF.Interface.ViewInterface
{
    public interface IAddAssortmentFormView
    {
        int ProductID { get; set; }
        decimal Price { get; set; }
        int Amount { get; set; }
        string ProductName { get; set; }
        event EventHandler? AddProductEvent;
        event EventHandler? AutocompleteEvent;
    }
}
