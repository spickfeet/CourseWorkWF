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
        }

        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            // Поиск дубликата
            foreach (Product productInAssortment in AssortmentList.Instance().ProductsAssortment)
            {
                if (NumericUpDownProductID.Value == productInAssortment.ProductID)
                {
                    for (int i = 0; i < NumericUpDownAmount.Value; i++)
                        AssortmentList.Instance().AddProductInAssortment(productInAssortment);
                    Close();
                    return;
                }
            }
            Product product = new Product((int)NumericUpDownProductID.Value, TextBoxProductName.Text, (double)NumericUpDownProductPrice.Value);
            for (int i = 0; i < NumericUpDownAmount.Value; i++)
                AssortmentList.Instance().AddProductInAssortment(product);
            Close();
        }

        private void NumericUpDownProductID_ValueChanged(object sender, EventArgs e)
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                if (product.ProductID == NumericUpDownProductID.Value)
                {
                    TextBoxProductName.Text = product.Name;
                    NumericUpDownProductPrice.Value = (decimal)product.Price;
                }
            }
        }
    }
}
