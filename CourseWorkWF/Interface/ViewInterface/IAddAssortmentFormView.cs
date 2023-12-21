namespace CourseWorkWF.Interface.ViewInterface
{
    public interface IAddAssortmentFormView
    {
        public int ProductID { get; }
        public decimal Price { get; set; }
        public int Amount { get; }
        public string ProductName { get; set; }
        public event EventHandler? AddProductEvent;
        public event EventHandler? AutocompleteEvent;
    }
}
