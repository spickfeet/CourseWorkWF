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
    public partial class AddAssortmentForm : Form, IAddAssortmentFormView
    {
        private AddAssortmentPresenter _presenter;
        long IAddAssortmentFormView.ProductID
        {
            get { return long.Parse(textBoxProductID.Text); }
        }
        decimal IAddAssortmentFormView.Price
        {
            get { return numericUpDownProductPrice.Value; }
            set { numericUpDownProductPrice.Value = value; }
        }
        int IAddAssortmentFormView.Amount
        {
            get { return (int)numericUpDownAmount.Value; }
        }
        string IAddAssortmentFormView.ProductName
        {
            get { return textBoxProductName.Text; }
            set { textBoxProductName.Text = value; }
        }
        public AddAssortmentForm(AddAssortmentPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            FormClosed += OnClosed;
        }

        private void OnClosed(object sender, EventArgs e)
        {
            checkBoxWeightProduct.Checked = false;
            errorProviderPrductName.Clear();
            errorProviderProductID.Clear();
            textBoxProductID.Clear();
            textBoxProductName.Clear();
            numericUpDownAmount.Value = 0;
            numericUpDownProductPrice.Value = 0;
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

        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            bool haveError = false;
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {
                errorProviderProductID.SetError(textBoxProductID, "Введите ID продукта");
                haveError = true;
            }
            if (string.IsNullOrEmpty(textBoxProductName.Text))
            {
                errorProviderPrductName.SetError(textBoxProductName, "Введите название продукта");
                haveError = true;
            }
            if (haveError == true)
            {
                return;
            }
            if (SetErrorLength())
            {
                textBoxProductName.Clear();
                numericUpDownAmount.Value = 0;
                numericUpDownProductPrice.Value = 0;
                return;
            }
            _presenter.AddProductInAssortment();
            textBoxProductID.Clear();
            textBoxProductName.Clear();
            numericUpDownAmount.Value = 0;
            numericUpDownProductPrice.Value = 0;
            checkBoxWeightProduct.Checked = false;
            Close();
        }

        private void TextBoxProductID_TextChanged(object sender, EventArgs e)
        {
            if (SetErrorLength())
            {
                return;
            }
            if (!string.IsNullOrEmpty(textBoxProductID.Text))
            {

                if (_presenter.Autocomplete() == true)
                {
                    textBoxProductName.Enabled = false;
                    numericUpDownProductPrice.Enabled = false;
                }
                else
                {
                    textBoxProductName.Clear();
                    numericUpDownProductPrice.Value = 0;
                    textBoxProductName.Enabled = true;
                    numericUpDownProductPrice.Enabled = true;
                }
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
    }
}
