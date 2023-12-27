using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;

namespace CourseWorkWF.Views
{
    public partial class RemoveAssortmentForm : Form, IRemoveAssortmentFormView
    {
        private RemoveAssortmentPresenter _presenter;
        public RemoveAssortmentForm(RemoveAssortmentPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
        }

        int IRemoveAssortmentFormView.Amount
        {
            get { return (int)numericUpDownAmount.Value; }
        }
        long IRemoveAssortmentFormView.ProductID
        {
            get { return long.Parse(textBoxProductID.Text); }
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
            SetErrorLength();
        }
        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            errorProviderProductID.Clear();
            if (SetErrorLength())
            {
                return;
            }
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {
                errorProviderProductID.SetError(textBoxProductID, "Введите ID продукта");
                return;
            }
            if (_presenter.RemoveProduct() == false)
            {
                errorProviderProductID.SetError(textBoxProductID, "Нет продукта с таким ID");
                return;
            }
            textBoxProductID.Clear();
            numericUpDownAmount.Value = 0;
            Close();
        }

        private void CheckBoxWeightProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWeightProduct.Checked == true)
            {
                numericUpDownAmount.DecimalPlaces = 3;
            }
            else
            {
                numericUpDownAmount.DecimalPlaces = 0;
            }
        }
        private bool SetErrorLength()
        {
            errorProviderProductID.Clear();
            if (textBoxProductID.Text.Length > 14)
            {
                errorProviderProductID.SetError(textBoxProductID, "ID продукта не может быть такой длинны");
                return true;
            }
            return false;
        }
    }
}
