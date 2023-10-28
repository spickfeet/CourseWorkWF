using CWTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWorkWF.Forms
{
    public partial class CashierARM : Form
    {
        static private double _revenue;
        private Form _prevForm;
        private List<Product> _buyProductsList = new();
        public CashierARM(Form prev)
        {
            _prevForm = prev;
            _prevForm.Hide();
            InitializeComponent();

            FormClosed += OnClosed;
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                if (product.ProductID == int.Parse(TextBoxProductID.Text))
                {
                    _buyProductsList.Add(product);
                    AssortmentList.Instance().ProductsAssortment.Remove(product);
                    TextBoxPrice.Text = Convert.ToString(double.Parse(TextBoxPrice.Text) + product.Price);
                    break;
                }
            }
            ListBoxBuyProducts.Items.Clear();
            foreach (Product product in _buyProductsList)
            {
                ListBoxBuyProducts.Items.Add(product.Name);
            }
        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy(ComboBoxTransactionMethod.Text, double.Parse(TextBoxPrice.Text), TextBoxCashierName.Text,
                _buyProductsList);
            TextBoxRevenue.Text = Convert.ToString(double.Parse(TextBoxRevenue.Text) + buy.MoneyAmount);
            TextBoxPrice.Text = "0";
            ListBoxBuyProducts.Items.Clear();
            _buyProductsList.Clear();
        }

        private void СomboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxPrice.Text = Convert.ToString(double.Parse(TextBoxPrice.Text) - (double.Parse(TextBoxPrice.Text) / 100) * int.Parse(ComboBoxDiscount.Text));
        }

    }
}
