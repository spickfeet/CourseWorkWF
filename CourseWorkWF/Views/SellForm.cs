using CourseWorkWF.Interface;
using CourseWorkWF.Models;
using CourseWorkWF.Presenters;

namespace CourseWorkWF.Views
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
        decimal ISell.Amount
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

            if (_presenter.GetBuyProductsList().BuyProductDictionary.Count != 0) // проверяем пустой ли список продуктов
            {
                comboBoxDiscount.Enabled = true;
                buttonCancel.Enabled = true;
            }

            // Вывод в listViewBuyProducts
            listViewBuyProducts.Items.Clear();
            int column = 0;
            foreach (KeyValuePair<int, ProductCollectionItem> productCollectionItem in _presenter.GetBuyProductsList().BuyProductDictionary)
            {
                listViewBuyProducts.Items.Add(productCollectionItem.Value.Product.Name.ToString());
                listViewBuyProducts.Items[column].SubItems.Add(productCollectionItem.Key.ToString());
                listViewBuyProducts.Items[column].SubItems.Add(productCollectionItem.Value.Product.Price.ToString());
                listViewBuyProducts.Items[column].SubItems.Add(productCollectionItem.Value.Amount.ToString());
                column++;
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
            comboBoxTransactionMethod.Enabled = true;
            DiscountEvent?.Invoke(this, EventArgs.Empty);
            if (comboBoxDiscount.SelectedIndex != 0)
            {
                buttonCancelDiscount.Enabled = true;
                comboBoxDiscount.Enabled = false;
            }
        }

        private void ButtonCancelDiscount_Click(object sender, EventArgs e)
        {
            if (comboBoxDiscount.Text != "0")
            {
                CancelDiscountEvent?.Invoke(this, EventArgs.Empty);

                comboBoxDiscount.SelectedIndex = 0;
                comboBoxDiscount.Enabled = true;
                buttonCancelDiscount.Enabled = false;

                comboBoxTransactionMethod.SelectedIndex = 0;
                numericUpDownCash.Value = 0;
                textBoxMoneyChangeBuyer.Text = "0";
            }
        }

        private void ComboBoxTransactionMethod_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (comboBoxTransactionMethod.SelectedIndex == 1)
            {
                labelCash.Visible = true;
                numericUpDownCash.Visible = true;
                labelMoneyChangeBuyer.Visible = true;
                textBoxMoneyChangeBuyer.Visible = true;
                buttonSell.Enabled = true;
            }
            if (comboBoxTransactionMethod.SelectedIndex == 2)
            {
                labelCash.Visible = false;
                numericUpDownCash.Visible = false;
                labelMoneyChangeBuyer.Visible = false;
                textBoxMoneyChangeBuyer.Visible = false;
                buttonSell.Enabled = true;
            }
            if (comboBoxTransactionMethod.SelectedIndex == 0)
            {
                labelCash.Visible = false;
                numericUpDownCash.Visible = false;
                labelMoneyChangeBuyer.Visible = false;
                textBoxMoneyChangeBuyer.Visible = false;
                buttonSell.Enabled = false;
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

            textBoxPrice.Text = "0";
            comboBoxDiscount.SelectedIndex = 0;
            comboBoxDiscount.Enabled = false;
            comboBoxTransactionMethod.SelectedIndex = 0;
            comboBoxTransactionMethod.Enabled = false;
            buttonSell.Enabled = false;
            buttonCancel.Enabled = false;

            labelCash.Visible = false;
            numericUpDownCash.Value = 0;
            numericUpDownCash.Visible = false;
            labelMoneyChangeBuyer.Visible = false;
            textBoxMoneyChangeBuyer.Text = "0";
            textBoxMoneyChangeBuyer.Visible = false;
        }
    }
}
