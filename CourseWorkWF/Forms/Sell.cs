using CourseWorkWF.Presenters;
using System.Windows.Forms;

namespace CourseWorkWF
{
    public partial class Sell : Form, ISell
    {
        private BuyProductsList _buyList = new BuyProductsList();
        private Form _prevForm;


        public Sell(Form prev)
        {
            _prevForm = prev;
            _prevForm.Hide();
            InitializeComponent();
            PresenterSell presenterSell = new PresenterSell(this, _buyList);

            FormClosed += OnClosed;

            presenterSell.AmountErrorEvent += AmountErrorSet;
            presenterSell.ProductIDErrorEvent += ProductIDErrorSet;
        }


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

        public event EventHandler? AddProductEvent;
        public event EventHandler? SellEvent;
        public event EventHandler? RevenueEvent;
        public event EventHandler? DiscountEvent;
        public event EventHandler? CashEvent;
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
            AddProductEvent?.Invoke(sender, e);
            numericUpDownProductID.Value = 1;
            if(errorProviderAmount == null && errorProviderProductID == null) 
            {
                comboBoxDiscount.Enabled = true;
                comboBoxTransactionMethod.Enabled = true;
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
            SellEvent?.Invoke(sender, e);

            comboBoxTransactionMethod.SelectedIndex = -1; // Сброс метода транзакции
            comboBoxDiscount.SelectedIndex = 0; // Сброс скидки
            textBoxPrice.Text = "0"; // зануление цены стоимости продуктов
            listViewBuyProducts.Items.Clear(); // Отчистка ListView
            comboBoxDiscount.Enabled = false;
            comboBoxTransactionMethod.Enabled = false;
        }

        private void ComboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = Convert.ToString(Math.Round(decimal.Parse(textBoxPrice.Text) - (decimal.Parse(textBoxPrice.Text) / 100) * int.Parse(comboBoxDiscount.Text), 2)); // Применение скидки
            if(comboBoxDiscount.Text == "0") 
            {
                buttonCancelDiscount.Enabled = true;
                return;
            }
            comboBoxDiscount.Enabled = false;
        }

        private void ButtonCancelDiscount_Click(object sender, EventArgs e)
        {
            if (comboBoxDiscount.Text != "0")
            {
                textBoxPrice.Text = Convert.ToString(Math.Round(decimal.Parse(textBoxPrice.Text) / (100 - int.Parse(comboBoxDiscount.Text)) * 100, 2)); // Отмена скидки
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
