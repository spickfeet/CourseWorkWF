namespace CourseWorkWF
{
    public interface IRemoveAssortmentFormView
    {
        int Amount { get; set; }
        int ProductID { get; set; }
        event EventHandler? RemoveProductEvent;
    }
}
