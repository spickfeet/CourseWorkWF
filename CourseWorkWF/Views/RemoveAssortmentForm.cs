using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;

namespace CourseWorkWF.Views
{
    public partial class RemoveAssortmentForm : Form, IRemoveAssortmentFormView
    {
        private RemoveAssortmentPresenter _presenter;
        public RemoveAssortmentForm()
        {
            InitializeComponent();
            _presenter = new RemoveAssortmentPresenter(this);
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
        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            errorProviderProductID.Clear();
            if (_presenter.RemoveProduct() == true)
                Close();
            else errorProviderProductID.SetError(numericUpDownProductID, "Нет продукта с таким ID");
        }
    }
}
