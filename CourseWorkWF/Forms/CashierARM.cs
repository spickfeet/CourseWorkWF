namespace CourseWorkWF
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

                if (product.ProductID == numericUpDownProductID.Value) // поиск по ID
                {
                    ErrorProviderAddProductByID.Clear(); // Убираем ошибки связанные с ID продукта

                    if (product.Amount < numericUpDownAmount.Value) // Проверяем колличество товара
                    {
                        ErrorProviderAmount.SetError(numericUpDownAmount, "В базе нет столько товаров");
                        return;
                    }
                    for (int i = 0; i < _buyList.BuyProductList.Count; i++) // Проверяем колличество товара при условии, что список покупок не пуст
                    {
                        if (_buyList.BuyProductList[i].ProductID == product.ProductID)
                        {
                            if ((product.Amount - _buyList.BuyProductList[i].Amount - numericUpDownAmount.Value) < 0)
                            {
                                ErrorProviderAmount.SetError(numericUpDownAmount, "В базе нет столько товаров");
                                return;
                            }
                        }
                    }
                    ErrorProviderAmount.Clear(); // Убираем ошибки связанные с количеством продукта

                    _buyList.AddProducts(product, (int)numericUpDownAmount.Value); // Добавляем продукты в список покупок


                    numericUpDownProductID.Value = 1;
                    textBoxPrice.Text = Convert.ToString(decimal.Parse(textBoxPrice.Text) + product.Price * numericUpDownAmount.Value); // подсчет цены

                    // Включаем возможность установить скидку и метод оплаты 
                    comboBoxDiscount.SelectedIndex = 0;
                    comboBoxDiscount.Enabled = true;
                    comboBoxTransactionMethod.Enabled = true;
                    ErrorProviderAddProductByID.Clear();
                    break;
                }
                ErrorProviderAddProductByID.SetError(numericUpDownProductID, "В магазине нет продукта с таким ID");
            }
            listViewBuyProducts.Items.Clear();
            for (int i = 0; i < _buyList.BuyProductList.Count; i++)
            {
                listViewBuyProducts.Items.Add(_buyList.BuyProductList[i].Name);
                listViewBuyProducts.Items[i].SubItems.Add(_buyList.BuyProductList[i].ProductID.ToString());
                listViewBuyProducts.Items[i].SubItems.Add(_buyList.BuyProductList[i].Amount.ToString());
            }
        }

        private void ButtonSell_Click(object sender, EventArgs e) // Продать
        {
            Buy buy = new Buy(comboBoxTransactionMethod.Text, double.Parse(textBoxPrice.Text), textBoxCashierName.Text,
                _buyList.BuyProductList, int.Parse(comboBoxDiscount.Text));
            textBoxRevenue.Text = Convert.ToString(double.Parse(textBoxRevenue.Text) + buy.MoneyAmount); // Увеличение выручки

            AssortmentList.Instance().RemoveProductsListInAssortment(_buyList.BuyProductList);


            comboBoxTransactionMethod.SelectedIndex = -1; // Сброс метода транзакции

            comboBoxDiscount.SelectedIndex = 0; // Сброс скидки

            textBoxPrice.Text = "0"; // зануление цены стоимости продуктов

            listViewBuyProducts.Items.Clear(); // Отчистка ListBox

            _buyList.BuyProductList.Clear(); // Отчистка списка купленных продуктов
        }

        private void ComboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = Convert.ToString(Math.Round(double.Parse(textBoxPrice.Text) - (double.Parse(textBoxPrice.Text) / 100) * int.Parse(comboBoxDiscount.Text), 2)); // Применение скидки
            if (comboBoxDiscount.SelectedIndex != 0) buttonCancelDiscount.Enabled = true;
            comboBoxDiscount.Enabled = false;
        }

        private void ButtonCancelDiscount_Click(object sender, EventArgs e)
        {
            if (comboBoxDiscount.Text != "0")
            {
                textBoxPrice.Text = Convert.ToString(Math.Round(double.Parse(textBoxPrice.Text) / (100 - int.Parse(comboBoxDiscount.Text)) * 100, 2)); // Отмена скидки
                comboBoxDiscount.SelectedIndex = 0;
                comboBoxDiscount.Enabled = true;
                buttonCancelDiscount.Enabled = false;
            }
        }

        private void ComboBoxTransactionMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSell.Enabled = true;
            if (comboBoxTransactionMethod.SelectedIndex == 0)
            {
                labelCash.Visible = true;
                numericUpDownCash.Visible = true;
                labelMoneyChangeBuyer.Visible = true;
                textBoxMoneyChangeBuyer.Visible = true;
            }
            else
            {
                labelCash.Visible = false;
                numericUpDownCash.Visible = false;
                labelMoneyChangeBuyer.Visible = false;
                textBoxMoneyChangeBuyer.Visible = false;
            }
        }

        private void NumericUpDownCash_ValueChanged(object sender, EventArgs e)
        {
            textBoxMoneyChangeBuyer.Text = Convert.ToString(Math.Round(numericUpDownCash.Value - decimal.Parse(textBoxPrice.Text), 2));
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _buyList.BuyProductList.Clear();
            listViewBuyProducts.Items.Clear();
        }
    }
}
