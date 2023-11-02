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
        private BuyList _buyList = new BuyList();
        private Form _prevForm;
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
                    ErrorProviderAddProductByID.Clear(); // Убираем ошибки связанные с ID продукта

                    if (product.Amount < NumericUpDownAmount.Value) // Проверяем колличество товара
                    {
                        ErrorProviderAmount.SetError(NumericUpDownAmount, "В базе нет столько товаров");
                        return;
                    }
                    for (int i = 0; i < _buyList.BuyProductList.Count; i++) // Проверяем колличество товара при условии, что список покупок не пуст
                    {
                        if (_buyList.BuyProductList[i].ProductID == product.ProductID)
                        {
                            if ((product.Amount - _buyList.BuyProductList[i].Amount - NumericUpDownAmount.Value) < 0)
                            {
                                ErrorProviderAmount.SetError(NumericUpDownAmount, "В базе нет столько товаров");
                                return;
                            }
                        }
                    }
                    ErrorProviderAmount.Clear(); // Убираем ошибки связанные с количеством продукта

                    _buyList.AddProducts(product, (int)NumericUpDownAmount.Value); // Добавляем продукты в список покупок


                    NumericUpDownProductID.Value = 1;
                    TextBoxPrice.Text = Convert.ToString(double.Parse(TextBoxPrice.Text) + product.Price * (double)NumericUpDownAmount.Value); // подсчет цены

                    // Включаем возможность установить скидку и метод оплаты 
                    ComboBoxDiscount.SelectedIndex = 0;
                    ComboBoxDiscount.Enabled = true;
                    ComboBoxTransactionMethod.Enabled = true;
                    ErrorProviderAddProductByID.Clear();
                    break;
                }
                ErrorProviderAddProductByID.SetError(NumericUpDownProductID, "В магазине нет продукта с таким ID");
            }
            ListViewBuyProducts.Items.Clear();
            for (int i = 0; i < _buyList.BuyProductList.Count; i++)
            {
                ListViewBuyProducts.Items.Add(_buyList.BuyProductList[i].Name);
                ListViewBuyProducts.Items[i].SubItems.Add(_buyList.BuyProductList[i].ProductID.ToString());
                ListViewBuyProducts.Items[i].SubItems.Add(_buyList.BuyProductList[i].Amount.ToString());
            }
        }

        private void ButtonSell_Click(object sender, EventArgs e) // Продать
        {
            Buy buy = new Buy(ComboBoxTransactionMethod.Text, double.Parse(TextBoxPrice.Text), numericUpDownCashierName.Text,
                _buyList.BuyProductList, int.Parse(ComboBoxDiscount.Text));
            TextBoxRevenue.Text = Convert.ToString(double.Parse(TextBoxRevenue.Text) + buy.MoneyAmount); // Увеличение выручки

            AssortmentList.Instance().RemoveProductsListInAssortment(_buyList.BuyProductList);


            ComboBoxTransactionMethod.SelectedIndex = -1; // Сброс метода транзакции

            ComboBoxDiscount.SelectedIndex = 0; // Сброс скидки

            TextBoxPrice.Text = "0"; // зануление цены стоимости продуктов

            ListViewBuyProducts.Items.Clear(); // Отчистка ListBox

            _buyList.BuyProductList.Clear(); // Отчистка списка купленных продуктов
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _buyList.BuyProductList.Clear();
            ListViewBuyProducts.Items.Clear();
        }
    }
}
