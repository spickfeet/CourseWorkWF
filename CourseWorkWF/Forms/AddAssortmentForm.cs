using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF
{
    public partial class AddAssortmentForm : Form, IAddAssortmentFormView
    {
        private AddAsortmentPresenter _presenter;
        public AddAssortmentForm()
        {
            InitializeComponent();
            _presenter = new AddAsortmentPresenter(this);
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
            _presenter.AddProductInAssortment();
            Close();
        }

        private void NumericUpDownProductID_ValueChanged(object sender, EventArgs e)
        {
            AutocompleteEvent?.Invoke(this, e );
        }
    }
}
