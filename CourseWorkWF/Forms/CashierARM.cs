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

        private void ButtonAddProduct_Click(object sender, EventArgs e) // Нажатие кнопки добавить
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment) // Обход ассортимента 
            {
                if (product.ProductID == NumericUpDownProductID.Value) // поиск по ID
                {
                    _buyProductsList.Add(product); // Добавление продукта в список покупаемых продуктов
                    AssortmentList.Instance().ProductsAssortment.Remove(product); // удаление продукта из ассортимента
                    NumericUpDownProductID.Value = 0;
                    TextBoxPrice.Text = Convert.ToString(double.Parse(TextBoxPrice.Text) + product.Price); // подсчет цены

                    // Включаем возможность установить скидку и метод оплаты 
                    ComboBoxDiscount.SelectedIndex = 0;
                    ComboBoxDiscount.Enabled = true;
                    ComboBoxTransactionMethod.Enabled = true;
                    break;
                }
            }
            ListBoxBuyProducts.Items.Clear();
            foreach (Product product in _buyProductsList)
            {
                ListBoxBuyProducts.Items.Add(product.Name);
            }
        }

        private void ButtonSell_Click(object sender, EventArgs e) // Продать
        {
            Buy buy = new Buy(ComboBoxTransactionMethod.Text, double.Parse(TextBoxPrice.Text), numericUpDownCashierName.Text,
                _buyProductsList, int.Parse(ComboBoxDiscount.Text));
            TextBoxRevenue.Text = Convert.ToString(double.Parse(TextBoxRevenue.Text) + buy.MoneyAmount); // Увеличение выручки

            ComboBoxTransactionMethod.SelectedIndex = -1; // Сброс метода транзакции

            ComboBoxDiscount.SelectedIndex = 0; // Сброс скидки

            TextBoxPrice.Text = "0"; // зануление цены стоимости продуктов

            ListBoxBuyProducts.Items.Clear(); // Отчистка ListBox

            _buyProductsList.Clear(); // Отчистка списка купленных продуктов
        }

        private void ComboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxPrice.Text = Convert.ToString(Math.Round(double.Parse(TextBoxPrice.Text) - (double.Parse(TextBoxPrice.Text) / 100) * int.Parse(ComboBoxDiscount.Text), 2)); // Применение скидки
            if (ComboBoxDiscount.SelectedIndex != 0) ButtonCancelDiscount.Enabled = true;
            ComboBoxDiscount.Enabled = false;
        }

        private void ButtonCancelDiscount_Click(object sender, EventArgs e)
        {
            if (ComboBoxDiscount.Text != "0")
            {
                TextBoxPrice.Text = Convert.ToString(Math.Round(double.Parse(TextBoxPrice.Text) / (100 - int.Parse(ComboBoxDiscount.Text)) * 100, 2)); // Отмена скидки
                ComboBoxDiscount.SelectedIndex = 0;
                ComboBoxDiscount.Enabled = true;
                ButtonCancelDiscount.Enabled = false;
            }
        }

        private void ComboBoxTransactionMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonSell.Enabled = true;
            if (ComboBoxTransactionMethod.SelectedIndex == 0)
            {
                LabelCash.Visible = true;
                NumericUpDownCash.Visible = true;
                LabelMoneyChangeBuyer.Visible = true;
                TextBoxMoneyChangeBuyer.Visible = true;
            }
            else
            {
                LabelCash.Visible = false;
                NumericUpDownCash.Visible = false;
                LabelMoneyChangeBuyer.Visible = false;
                TextBoxMoneyChangeBuyer.Visible = false;
            }
        }

        private void NumericUpDownCash_ValueChanged(object sender, EventArgs e)
        {
            TextBoxMoneyChangeBuyer.Text = Convert.ToString(Math.Round(NumericUpDownCash.Value - decimal.Parse(TextBoxPrice.Text), 2));
        }
    }
}
