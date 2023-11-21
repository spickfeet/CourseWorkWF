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
    public partial class AddAssortment : Form
    {
        public AddAssortment()
        {
            InitializeComponent();
            new PresenterAddAsortment(this);
            DialogResult = DialogResult.Cancel;
        }
        public event EventHandler addAssortmentEvent;
        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            addAssortmentEvent.Invoke(sender, e);
            AssortmentList.Instance().AddProductInAssortment((int)numericUpDownProductID.Value, textBoxProductName.Text, (double)numericUpDownProductPrice.Value, (int)numericUpDownAmount.Value);
            Close();
        }

        private void NumericUpDownProductID_ValueChanged(object sender, EventArgs e)
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                if (product.ProductID == numericUpDownProductID.Value)
                {
                    textBoxProductName.Text = product.Name;
                    numericUpDownProductPrice.Value = (decimal)product.Price;
                }
            }
        }
    }
}
