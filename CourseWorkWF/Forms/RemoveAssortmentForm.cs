namespace CourseWorkWF
{
    public partial class RemoveAssortmentForm : Form, IRemoveAssortmentFormView
    {
        public RemoveAssortmentForm()
        {
            InitializeComponent();
            RemoveAssortmentPresenter presenterRemoveAssortment = new RemoveAssortmentPresenter(this);
            presenterRemoveAssortment.ErrorEvent += Error;
            presenterRemoveAssortment.CloseEvent += Closed;
        }

        int IRemoveAssortmentFormView.Amount
        {
            get { return (int)numericUpDownAmount.Value; }
            set { numericUpDownAmount.Value = value; }
        }
        int IRemoveAssortmentFormView.ProductID
        {
            get { return (int)numericUpDownProductID.Value; }
            set { numericUpDownProductID.Value = value; }
        }


        public event EventHandler? RemoveProductEvent;


        public void Closed(object sender, EventArgs e)
        {
            Close();
        }
        public void Error(object sender, EventArgs e)
        {
            errorProviderProductID.SetError(numericUpDownProductID, "Нет продукта с таким ID");
        }
        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            errorProviderProductID.Clear();
            RemoveProductEvent?.Invoke(sender, e);
        }
    }
}
