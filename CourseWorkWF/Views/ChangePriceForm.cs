using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;
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
        int IChangePriceFormView.ProductID => int.Parse(textBoxProductID.Text);

        decimal IChangePriceFormView.Price => numericUpDownPrice.Value;
        public ChangePriceForm()
        {
            _presenter = new ChangePricePresenter(this);
            _presenter.IDNotFoundErrorEvent += SetProductIDError;
            InitializeComponent();
        }

        private void SetProductIDError(object? sender, string error)
        {
            errorProviderProductID.SetError(textBoxProductID, error);
        }

        private void TextBoxNumerical_KeyPressNotNumber(object sender, KeyPressEventArgs e) // Запрет на все кроме цифр
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void ButtonChangePrice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {
                errorProviderProductID.SetError(textBoxProductID, "Введите ID продукта");
                return;
            }
            _presenter.ChangePrice();
        }
    }
}
