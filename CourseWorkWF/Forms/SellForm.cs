namespace CourseWorkWF
{
    public partial class SellForm : Form, ISell
    {
        private Form _prevForm;
        private SellPresenter _presenter;


        decimal ISell.Revenue
        {
            get { return decimal.Parse(textBoxRevenue.Text); }
            set { textBoxRevenue.Text = value.ToString(); }
        }
        int ISell.Discount
        {
            get { return int.Parse(comboBoxDiscount.Text); }
            set { comboBoxDiscount.Text = value.ToString(); }
        }
        string ISell.TransactionMethod
        {
            get { return comboBoxTransactionMethod.Text; }
            set { comboBoxTransactionMethod.Text = value; }
        }
        decimal ISell.Cash
        {
            get { return numericUpDownCash.Value; }
            set { numericUpDownCash.Value = value; }
        }
        decimal ISell.MoneyChangeBuyer
        {
            get { return decimal.Parse(textBoxMoneyChangeBuyer.Text); }
            set { textBoxMoneyChangeBuyer.Text = value.ToString(); }
        }
        string ISell.CashierName
        {
            get { return textBoxCashierName.Text; }
            set { textBoxCashierName.Text = value; }
        }
        int ISell.ProductID
        {
            get { return (int)numericUpDownProductID.Value; }
            set { numericUpDownAmount.Value = value; }
        }
        int ISell.Amount
        {
            get { return (int)numericUpDownAmount.Value; }
            set { numericUpDownAmount.Value = value; }
        }
        decimal ISell.Price
        {
            get { return decimal.Parse(textBoxPrice.Text); }
            set { textBoxPrice.Text = value.ToString(); }
        }
        public SellForm(Form prev)
        {
            _prevForm = prev;
            _prevForm.Hide();
            InitializeComponent();
            _presenter = new(this);

            FormClosed += OnClosed;

            _presenter.AmountErrorEvent += AmountErrorSet;
            _presenter.ProductIDErrorEvent += ProductIDErrorSet;
        }


        public event EventHandler? AddProductEvent;
        public event EventHandler? SellEvent;
        public event EventHandler? DiscountEvent;
        public event EventHandler? CashEvent;
        public event EventHandler? CancelDiscountEvent;
        public event EventHandler? CancelBuyProductsEvent;

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
        }
        private void ProductIDErrorSet(object? sender, EventArgs e)
        {
            errorProviderProductID.SetError(numericUpDownProductID, "Нет продукта с таким ID");
        }

        private void AmountErrorSet(object? sender, EventArgs e)
        {
            errorProviderAmount.SetError(numericUpDownAmount, "В ассортементе нет столько продуктов");
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e) // Нажатие кнопки добавить
        {
            errorProviderProductID.Clear();
            errorProviderAmount.Clear();
            AddProductEvent?.Invoke(this, EventArgs.Empty);
            numericUpDownProductID.Value = 1;

            if(_presenter.GetBuyProductsList().BuyProductList != null) // проверяем пустой ли список продуктов
            {
                comboBoxDiscount.Enabled = true;
                comboBoxTransactionMethod.Enabled = true;
            }

            // Вывод в listViewBuyProducts
            listViewBuyProducts.Items.Clear();
            for (int i = 0; i < _presenter.GetBuyProductsList().BuyProductList.Count; i++)
            {   
                listViewBuyProducts.Items.Add(_presenter.GetBuyProductsList().BuyProductList[i].Name);
                listViewBuyProducts.Items[i].SubItems.Add(_presenter.GetBuyProductsList().BuyProductList[i].ProductID.ToString());
                listViewBuyProducts.Items[i].SubItems.Add(_presenter.GetBuyProductsList().BuyProductList[i].Price.ToString());
                listViewBuyProducts.Items[i].SubItems.Add(_presenter.GetBuyProductsList().BuyProductList[i].Amount.ToString());
            }
        }

        private void ButtonSell_Click(object sender, EventArgs e) // Продать
        {
            SellEvent?.Invoke(this, EventArgs.Empty);

            comboBoxTransactionMethod.SelectedIndex = -1; // Сброс метода транзакции
            comboBoxDiscount.SelectedIndex = 0; // Сброс скидки
            textBoxPrice.Text = "0"; // зануление цены стоимости продуктов
            listViewBuyProducts.Items.Clear(); // Отчистка ListView
            comboBoxDiscount.Enabled = false;
            comboBoxTransactionMethod.Enabled = false;
        }

        private void ComboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiscountEvent?.Invoke(this, EventArgs.Empty);

            buttonCancelDiscount.Enabled = true;
            comboBoxDiscount.Enabled = false;
        }

        private void ButtonCancelDiscount_Click(object sender, EventArgs e)
        {
            if (comboBoxDiscount.Text != "0")
            {
                CancelDiscountEvent?.Invoke(this, EventArgs.Empty);

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
            CashEvent?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            CancelBuyProductsEvent?.Invoke(this, EventArgs.Empty);
            listViewBuyProducts.Items.Clear();
        }
    }
}
