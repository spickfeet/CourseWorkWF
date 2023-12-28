using CourseWorkWF.Models;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Views.ViewsControl;

namespace CourseWorkWF.Views
{
    public partial class SellForm : Form, ISellFormView
    {
        private SellPresenter _presenter;
        private IViewsController _viewsController;
        int ISellFormView.Discount
        {
            get
            {
                if (comboBoxDiscount.SelectedIndex == -1)
                    return 0;
                return int.Parse(comboBoxDiscount.Text);
            }
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
        long ISellFormView.ProductID
        {
            get { return long.Parse(textBoxProductID.Text); }
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
        public SellForm(IViewsController viewsController, SellPresenter presenter)
        {
            InitializeComponent();
            _presenter = presenter;
            _viewsController = viewsController;
            _presenter.AddError += OnAddError;
            FormClosed += OnClosed;
        }
        private void OnClosed(object sender, EventArgs e)
        {
            Cancel();

            _viewsController.Closed();
            _viewsController.PrevView.Visible = true;
        }

        private void TextBoxNumerical_KeyPressNotNumber(object sender, KeyPressEventArgs e) // Запрет на все кроме цифр
        {
            errorProviderProductID.Clear();
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {
                if (e.KeyChar == 48)
                {
                    e.KeyChar = '\0';
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.KeyChar = '\0';
            }
            if (textBoxProductID.Text.Length > 14)
            {
                errorProviderProductID.SetError(textBoxProductID, "ID не может быть такой длинны");
            }
        }

        private void OnAddError(string error)
        {
            errorProviderProductID.SetError(buttonAddProduct, error);
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e) // Нажатие кнопки добавить
        {
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {
                return;
            }
            if (textBoxProductID.Text.Length > 14)
            {
                return;
            }
            errorProviderProductID.Clear();
            errorProviderAmount.Clear();
            _presenter.AddProduct();
            textBoxProductID.Clear();
            checkBoxWeightProduct.Checked = false;

            if (_presenter.BuyProducts.Count != 0) // проверяем пустой ли список продуктов
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
            foreach (KeyValuePair<long, IProductsCollectionItem> productCollectionItem in _presenter.BuyProducts)
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
            _presenter.SellOut();

            Cancel();
        }

        private void ComboBoxDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonAddProduct.Enabled = false;
            comboBoxOperationMethod.Enabled = true;
            _presenter.DiscountUse();
            if (comboBoxDiscount.SelectedIndex != 0)
            {
                comboBoxDiscount.Enabled = false;
            }
            UpdateBuyList();
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
            _presenter.GetMoneyChangeBuyer();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        private void Cancel()
        {
            _presenter.CancelBuyProducts();
            listViewBuyProducts.Items.Clear();

            textBoxPrice.Text = "0";
            comboBoxDiscount.SelectedIndex = -1;
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
            buttonAddProduct.Enabled = true;
        }

        private void CheckBoxWeightProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWeightProduct.Checked == true)
            {
                numericUpDownAmount.DecimalPlaces = 3;
            }
            else
            {
                numericUpDownAmount.DecimalPlaces = 0;
            }
        }
    }
}
