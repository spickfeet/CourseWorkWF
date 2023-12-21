using CourseWorkWF.Models;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;

namespace CourseWorkWF.Views
{
    public partial class SellForm : Form, ISellFormView
    {
        private Form _prevForm;
        private SellPresenter _presenter;
        int ISellFormView.Discount
        {
            get { return int.Parse(comboBoxDiscount.Text); }
        }
        OperationMethod ISellFormView.OperationMethod
        {
            get
            {
                if (comboBoxOperationMethod.Text == "Карта") return OperationMethod.Card;
                if (comboBoxOperationMethod.Text == "Наличные") return OperationMethod.Cash;
                throw new ArgumentException("Не выбран способ оплаты");
            }
        }
        decimal ISellFormView.Cash
        {
            get { return numericUpDownCash.Value; }
        }
        decimal ISellFormView.MoneyChangeBuyer
        {
            get { return decimal.Parse(textBoxMoneyChangeBuyer.Text); }
            set { textBoxMoneyChangeBuyer.Text = value.ToString(); }
        }
        string ISellFormView.CashierName
        {
            get { return textBoxCashierName.Text; }
        }
        int ISellFormView.ProductID
        {
            get { return int.Parse(textBoxProductID.Text); }
        }
        decimal ISellFormView.Amount
        {
            get { return (int)numericUpDownAmount.Value; }
        }
        decimal ISellFormView.Price
        {
            get { return decimal.Parse(textBoxPrice.Text); }
            set { textBoxPrice.Text = value.ToString(); }
        }
        public SellForm(Form prev, IEmployee user)
        {
            _prevForm = prev;
            _prevForm.Hide();
            InitializeComponent();
            _presenter = new(this, user);
            textBoxRevenue.Text = Convert.ToString(Program.revenue.Proceeds);

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

        private void TextBoxNumerical_KeyPressNotNumber(object sender, KeyPressEventArgs e) // Запрет на все кроме цифр
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.KeyChar = '\0';
            }
            if (textBoxProductID.Text.Length > 9)
            {
                errorProviderProductID.SetError(textBoxProductID, "ID не может быть такой длинны");
            }
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
        }
        private void ProductIDErrorSet(object? sender, EventArgs e)
        {
            errorProviderProductID.SetError(textBoxProductID, "Нет продукта с таким ID");
        }

        private void AmountErrorSet(object? sender, EventArgs e)
        {
            errorProviderAmount.SetError(numericUpDownAmount, "В ассортименте нет столько продуктов");
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e) // Нажатие кнопки добавить
        {
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {
                return;
            }
            if (textBoxProductID.Text.Length > 9)
            {
                return;
            }
            errorProviderProductID.Clear();
            errorProviderAmount.Clear();
            AddProductEvent?.Invoke(this, EventArgs.Empty);
            textBoxProductID.Clear();

            if (_presenter.GetBuyProductsList().Count != 0) // проверяем пустой ли список продуктов
            {
                comboBoxDiscount.Enabled = true;
                buttonCancel.Enabled = true;
            }
            UpdateBuyList();
        }
        private void UpdateBuyList()
        {
            listViewBuyProducts.Items.Clear();
            int lineIndex = 0;
            foreach (KeyValuePair<int, IProductsCollectionItem> productCollectionItem in _presenter.GetBuyProductsList())
            {
                listViewBuyProducts.Items.Add(productCollectionItem.Value.Product.ProductName.ToString());
                listViewBuyProducts.Items[lineIndex].SubItems.Add(productCollectionItem.Key.ToString());
                listViewBuyProducts.Items[lineIndex].SubItems.Add(productCollectionItem.Value.Product.Price.ToString());
                listViewBuyProducts.Items[lineIndex].SubItems.Add(productCollectionItem.Value.Amount.ToString());
                lineIndex++;
            }
        }

        private void ButtonSell_Click(object sender, EventArgs e) // Продать
        {
            SellEvent?.Invoke(this, EventArgs.Empty);
            textBoxRevenue.Text = Convert.ToString(Program.revenue.Proceeds);

            comboBoxOperationMethod.SelectedIndex = -1; // Сброс метода транзакции
            comboBoxDiscount.SelectedIndex = 0; // Сброс скидки
            textBoxPrice.Text = "0"; // зануление цены стоимости продуктов
            listViewBuyProducts.Items.Clear(); // Отчистка ListView
            comboBoxDiscount.Enabled = false;
            comboBoxOperationMethod.Enabled = false;
        }

        private void ComboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOperationMethod.Enabled = true;
            DiscountEvent?.Invoke(this, EventArgs.Empty);
            if (comboBoxDiscount.SelectedIndex != 0)
            {
                buttonCancelDiscount.Enabled = true;
                comboBoxDiscount.Enabled = false;
            }
            UpdateBuyList();
        }

        private void ButtonCancelDiscount_Click(object sender, EventArgs e)
        {
            if (comboBoxDiscount.Text != "0")
            {
                CancelDiscountEvent?.Invoke(this, EventArgs.Empty);

                comboBoxDiscount.SelectedIndex = 0;
                comboBoxDiscount.Enabled = true;
                buttonCancelDiscount.Enabled = false;

                comboBoxOperationMethod.SelectedIndex = -1;
                numericUpDownCash.Value = 0;
                textBoxMoneyChangeBuyer.Text = "0";
            }
        }

        private void ComboBoxTransactionMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperationMethod.SelectedIndex == 0)
            {
                labelCash.Visible = true;
                numericUpDownCash.Visible = true;
                labelMoneyChangeBuyer.Visible = true;
                textBoxMoneyChangeBuyer.Visible = true;
                buttonSell.Enabled = true;
            }
            if (comboBoxOperationMethod.SelectedIndex == 1)
            {
                labelCash.Visible = false;
                numericUpDownCash.Visible = false;
                labelMoneyChangeBuyer.Visible = false;
                textBoxMoneyChangeBuyer.Visible = false;
                buttonSell.Enabled = true;
            }
            if (comboBoxOperationMethod.SelectedIndex == -1)
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
            comboBoxOperationMethod.SelectedIndex = -1;
            comboBoxOperationMethod.Enabled = false;
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
