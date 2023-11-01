using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Forms
{
    public partial class RemoveAssortment : Form
    {
        public RemoveAssortment()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                if (product.ProductID == NumericUpDownProductID.Value)
                {
                    AssortmentList.Instance().RemoveProductsInAssortment(product, (int)NumericUpDownAmount.Value);
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
            }
            ErrorProviderProductID.SetError(NumericUpDownProductID, "Нет продукта с таким ID");
        }
    }
}
