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
    public partial class Assortment : Form
    {
        private Form _prevForm;
        private AssortmentList _assortment;
        public Assortment(Form prev, AssortmentList assortment)
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

        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            AddAssortment addAssortment = new AddAssortment();
            addAssortment.ShowDialog();
        }

        private void ButtonLoadAssortment_Click(object sender, EventArgs e)
        {
            ListBoxAssortment.Items.Clear();
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                ListBoxAssortment.Items.Add(product.Name);
            }

        }

        private void ButtonRemoveProductInAssortment_Click(object sender, EventArgs e)
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                if (product.Name == (string)ListBoxAssortment.SelectedItem)
                {
                    AssortmentList.Instance().RemoveProductInAssortment(product);
                    break;
                }

            }
            ListBoxAssortment.Items.Clear();
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                ListBoxAssortment.Items.Add(product.Name);
            }
        }
    }
}
