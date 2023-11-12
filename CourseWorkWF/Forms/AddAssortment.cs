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
            DialogResult = DialogResult.Cancel;
        }

        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            for (int i = 0; i < AssortmentList.Instance().ProductsAssortment.Count; i++)
            {
                if (AssortmentList.Instance().ProductsAssortment[i].ProductID == numericUpDownProductID.Value)
                {
                    AssortmentList.Instance().ProductsAssortment[i].Amount += (int)numericUpDownAmount.Value;
                    Close();
                    return;
                }
            }
            Product product = new Product((int)numericUpDownProductID.Value, textBoxProductName.Text, (double)numericUpDownProductPrice.Value, (int)numericUpDownAmount.Value);
            AssortmentList.Instance().AddProductInAssortment(product);
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
