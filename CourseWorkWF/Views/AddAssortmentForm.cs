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
        public AddAssortmentForm()
        {
            InitializeComponent();
            _ = new AddAssortmentPresenter(this);
        }

        int IAddAssortmentFormView.ProductID
        {
            get { return (int)numericUpDownProductID.Value; }
            set { numericUpDownProductID.Value = value; }
        }
        decimal IAddAssortmentFormView.Price
        {
            get { return numericUpDownProductPrice.Value; }
            set { numericUpDownProductPrice.Value = value; }
        }
        int IAddAssortmentFormView.Amount
        {
            get { return (int)numericUpDownAmount.Value; }
            set { numericUpDownAmount.Value = value; }
        }
        string IAddAssortmentFormView.ProductName
        {
            get { return textBoxProductName.Text; }
            set { textBoxProductName.Text = value; }
        }

        public event EventHandler? AddProductEvent; // событие добавление продукта
        public event EventHandler? AutocompleteEvent; // событие автозаполнение

        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            AddProductEvent?.Invoke(this, EventArgs.Empty);
            Close();
        }

        private void NumericUpDownProductID_ValueChanged(object sender, EventArgs e)
        {
            AutocompleteEvent?.Invoke(this, e);
        }
    }
}
