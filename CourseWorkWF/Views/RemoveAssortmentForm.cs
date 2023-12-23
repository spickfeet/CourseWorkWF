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
        }
        int IRemoveAssortmentFormView.ProductID
        {
            get { return int.Parse(textBoxProductID.Text); }
        }
        private void TextBoxNumerical_KeyPressNotNumber(object sender, KeyPressEventArgs e) // Запрет на все кроме цифр
        {
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {
                if (e.KeyChar == 48)
                {
                    e.KeyChar = '\0';
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.KeyChar = '\0';
            }
        }
        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            errorProviderProductID.Clear();
            if (_presenter.RemoveProduct() == true)
                Close();
            else errorProviderProductID.SetError(textBoxProductID, "Нет продукта с таким ID");
        }
    }
}
