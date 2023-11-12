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
            if (addAssortment.ShowDialog() == DialogResult.OK) UpdateList();
        }

        private void ButtonLoadAssortment_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void ButtonRemoveProductInAssortment_Click(object sender, EventArgs e)
        {
            RemoveAssortment removeAssortment = new RemoveAssortment();
            if (removeAssortment.ShowDialog() == DialogResult.OK) UpdateList();
        }

        private void UpdateList()
        {
            listViewAssortment.Items.Clear();
            for (int i = 0; i < AssortmentList.Instance().ProductsAssortment.Count; i++)
            {
                listViewAssortment.Items.Add(AssortmentList.Instance().ProductsAssortment[i].Name);
                listViewAssortment.Items[i].SubItems.Add(AssortmentList.Instance().ProductsAssortment[i].ProductID.ToString());
                listViewAssortment.Items[i].SubItems.Add(AssortmentList.Instance().ProductsAssortment[i].Price.ToString());
                listViewAssortment.Items[i].SubItems.Add(AssortmentList.Instance().ProductsAssortment[i].Amount.ToString());
            }
        }
    }
}
