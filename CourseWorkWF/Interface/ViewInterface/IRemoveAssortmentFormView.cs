namespace CourseWorkWF.Interface.ViewInterface
{
    public interface IRemoveAssortmentFormView : IView
    {
        public int Amount { get; }
        public long ProductID { get; }
    }
}
