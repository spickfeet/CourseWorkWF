using CourseWorkWF.Forms;
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
        private List<Product> _AssortmentlistView;
        private Form _prevForm;
        public Assortment(Form prev)
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
            int count = 0;
            _AssortmentlistView = AssortmentList.Instance().ProductsAssortment.Distinct().ToList();
            foreach (Product productView in _AssortmentlistView) // проходимся по списку без дубликатов
            {
                foreach (Product productInAssortment in AssortmentList.Instance().ProductsAssortment) // проходимся по всему ассортименту 
                {
                    if (productView == productInAssortment) count++;
                }
                ListBoxAssortment.Items.Add(productView.Name + "    " + count + " Шт.");
                count = 0;
            }
        }

        private void ButtonRemoveProductInAssortment_Click(object sender, EventArgs e)
        {
            RemoveAssortment removeAssortment = new RemoveAssortment(); 
            removeAssortment.ShowDialog();
        }
    }
}
