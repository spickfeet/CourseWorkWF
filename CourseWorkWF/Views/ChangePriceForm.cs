using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Views
{
    public partial class ChangePriceForm : Form, IChangePriceFormView
    {
        private ChangePricePresenter _presenter;
        long IChangePriceFormView.ProductID => long.Parse(textBoxProductID.Text);

        decimal IChangePriceFormView.Price => numericUpDownPrice.Value;
        public ChangePriceForm(ViewsController viewsController, ChangePricePresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
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
        private void ButtonChangePrice_Click(object sender, EventArgs e)
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
            if (_presenter.ChangePrice() == false)
            {
                errorProviderProductID.SetError(textBoxProductID, "Нет продукта с таким ID");
                return;
            }
            textBoxProductID.Clear();
            numericUpDownPrice.Value = 0;
            Close();
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
