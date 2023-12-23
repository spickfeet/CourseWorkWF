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
    public partial class AddAssortmentForm : Form, IAddAssortmentFormView
    {
        private AddAssortmentPresenter _presenter;
        public AddAssortmentForm()
        {
            InitializeComponent();
            _presenter = new AddAssortmentPresenter(this);
        }

        int IAddAssortmentFormView.ProductID
        {
            get { return int.Parse(textBoxProductID.Text); }
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

        public event EventHandler? AddProductEvent; // событие добавление продукта
        public event EventHandler? AutocompleteEvent; // событие автозаполнение

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
            if (SetErrorLength())
            {
                textBoxProductName.Clear();
                numericUpDownAmount.Value = 0;
                numericUpDownProductPrice.Value = 0;
                return;
            }
            AddProductEvent?.Invoke(this, EventArgs.Empty);
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
            errorProviderProductIDLength.Clear();
            if (textBoxProductID.Text.Length > 9)
            {
                errorProviderProductIDLength.SetError(textBoxProductID, "ID продукта не может быть такой длинны");
                return true;
            }
            return false;
        }

        private void CheckBoxWeightProduct_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxWeightProduct.Checked == true)
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
