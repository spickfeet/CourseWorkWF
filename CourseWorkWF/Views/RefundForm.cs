using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Views
{
    public partial class RefundForm : Form, IRefundFormView
    {
        private RefundPresenter _presenter;
        private bool _haveError;

        int IRefundFormView.ReceiptNumber => int.Parse(textBoxReceiptNumber.Text);

        int IRefundFormView.SelectedReceiptNumber
        {
            get
            {
                if (listViewSeles.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return int.Parse(listViewSeles.SelectedItems[0].Text);
            }
        }

        DateTime IRefundFormView.DateFrom => dateTimePickerFromDate.Value;

        DateTime IRefundFormView.DateTo => dateTimePickerToDate.Value;

        int IRefundFormView.ProductID => int.Parse(textBoxProductID.Text);

        OperationMethod IRefundFormView.OperationType
        {
            get
            {
                if (comboBoxOperationMethod.Text == "Карта") return OperationMethod.Card;
                if (comboBoxOperationMethod.Text == "Наличные") return OperationMethod.Cash;
                throw new ArgumentException("Не выбран способ оплаты");
            }
        }

        int IRefundFormView.Amount => (int)numericUpDownAmount.Value;

        public string Reason => richTextBoxReason.Text;

        string IRefundFormView.SellInfo { set { richTextBoxSellInfo.Text = value; } }

        string IRefundFormView.Reason => richTextBoxReason.Text;

        public RefundForm(IEmployee employee)
        {
            _presenter = new RefundPresenter(this, employee);
            InitializeComponent();
            _presenter.AmountErrorEvent += AmountErrorSet;
            _presenter.ProductIDErrorEvent += ProductIDErrorSet;
            _presenter.SellInfoErrorEvent += SellInfoErrorSet;
        }

        private void SellInfoErrorSet(object? sender, string error)
        {
            errorProviderSellInfo.SetError(richTextBoxSellInfo, error);
        }

        private void ProductIDErrorSet(object? sender, string error)
        {
            errorProviderProductID.SetError(textBoxProductID, error);
        }

        private void AmountErrorSet(object? sender, string error)
        {
            errorProviderAmount.SetError(numericUpDownAmount, error);
        }

        private void TextBoxNumerical_KeyPressNotNumber(object sender, KeyPressEventArgs e) // Запрет на все кроме цифр
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void ButtonRefund_Click(object sender, EventArgs e)
        {
            _haveError = false;
            errorProviderReason.Clear();
            errorProviderOperationMethod.Clear();
            if (string.IsNullOrEmpty(richTextBoxReason.Text))
            {
                errorProviderReason.SetError(richTextBoxReason, "Введите причину возврата");
                _haveError = true;
            }
            if (string.IsNullOrEmpty(comboBoxOperationMethod.Text))
            {
                errorProviderOperationMethod.SetError(comboBoxOperationMethod, "Выберите куда вернуть деньги");
                _haveError = true;
            }
            if (_haveError == false)
            {
                _presenter.ReturnMoney();

                comboBoxOperationMethod.SelectedIndex = -1;
                listViewBuyList.Items.Clear();
                listViewRefundList.Items.Clear();
                listViewSeles.Items.Clear();
                richTextBoxReason.Clear();
                richTextBoxSellInfo.Clear();
                textBoxProductID.Clear();
                textBoxReceiptNumber.Clear();
                numericUpDownAmount.Value = 1;
            }
        }
        private void CheckBoxFindByDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFindByDate.Checked == true)
            {
                labelFromDate.Visible = true;
                labelToDate.Visible = true;
                dateTimePickerFromDate.Visible = true;
                dateTimePickerToDate.Visible = true;
                buttonFind.Location = new Point(10, 163);
            }
            else
            {
                labelFromDate.Visible = false;
                labelToDate.Visible = false;
                dateTimePickerFromDate.Visible = false;
                dateTimePickerToDate.Visible = false;
                buttonFind.Location = new Point(10, 80);
            }
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            errorProviderSellInfo.Clear();
            errorProviderNumber.Clear();
            listViewBuyList.Items.Clear();
            listViewRefundList.Items.Clear();
            listViewSeles.Items.Clear();
            richTextBoxReason.Clear();
            richTextBoxSellInfo.Clear();
            textBoxProductID.Clear();
            numericUpDownAmount.Value = 1;
            if (checkBoxFindByDate.Checked == false)
            {
                if (string.IsNullOrEmpty(textBoxReceiptNumber.Text))
                {
                    errorProviderNumber.SetError(textBoxReceiptNumber, "Введите номер чека или найдите чек по дате");
                    return;
                }
                if (_presenter.FineReceiptByNumber() == null)
                {
                    errorProviderNumber.SetError(textBoxReceiptNumber, "Нет чека с таким номером");
                }
                else
                {
                    listViewSeles.Items.Add(_presenter.FineReceiptByNumber().OperationNumber.ToString());
                    listViewSeles.Items[0].SubItems.Add(_presenter.FineReceiptByNumber().Sell.MoneyOperation.MoneyAmount.ToString());
                    listViewSeles.Items[0].SubItems.Add(_presenter.FineReceiptByNumber().OperationTime.ToString());


                    listViewBuyList.Items.Clear();
                    int lineIndex = 0;
                    foreach (var product in _presenter.FineReceiptByNumber().Sell.Products)
                    {
                        listViewBuyList.Items.Add(product.Value.Product.ProductID.ToString());
                        listViewBuyList.Items[lineIndex].SubItems.Add(product.Value.Product.ProductName.ToString());
                        listViewBuyList.Items[lineIndex].SubItems.Add(product.Value.Product.Price.ToString());
                        listViewBuyList.Items[lineIndex].SubItems.Add(product.Value.Amount.ToString());
                        lineIndex++;
                    }
                }
            }
            else
            {
                int lineIndex = 0;
                foreach (var sellInfo in _presenter.FineReceiptByDates())
                {
                    listViewSeles.Items.Add(sellInfo.OperationNumber.ToString());
                    listViewSeles.Items[lineIndex].SubItems.Add(sellInfo.Sell.MoneyOperation.MoneyAmount.ToString());
                    listViewSeles.Items[lineIndex].SubItems.Add(sellInfo.OperationTime.ToString());
                    lineIndex++;
                }
            }
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            if (_presenter.FineReceiptBySelectedReceiptNumber() != null)
            {
                listViewBuyList.Items.Clear();
                int lineIndex = 0;
                foreach (var product in _presenter.FineReceiptBySelectedReceiptNumber().Sell.Products)
                {
                    listViewBuyList.Items.Add(product.Value.Product.ProductID.ToString());
                    listViewBuyList.Items[lineIndex].SubItems.Add(product.Value.Product.ProductName.ToString());
                    listViewBuyList.Items[lineIndex].SubItems.Add(product.Value.Product.Price.ToString());
                    listViewBuyList.Items[lineIndex].SubItems.Add(product.Value.Amount.ToString());
                    lineIndex++;
                }
            }

        }

        private void ButtonAddProductRefundList_Click(object sender, EventArgs e)
        {
            errorProviderSellInfo.Clear();
            errorProviderProductID.Clear();
            errorProviderAmount.Clear();
            if (string.IsNullOrEmpty(textBoxProductID.Text))
            {
                errorProviderProductID.SetError(textBoxProductID, "Введите ID");
                return;
            }
            _presenter.AddRefundList();
            listViewRefundList.Items.Clear();
            int column = 0;
            foreach (var item in _presenter.ProductsRefund)
            {
                listViewRefundList.Items.Add(item.Value.Product.ProductID.ToString());
                listViewRefundList.Items[column].SubItems.Add(item.Value.Product.ProductName.ToString());
                listViewRefundList.Items[column].SubItems.Add(item.Value.Product.Price.ToString());
                listViewRefundList.Items[column].SubItems.Add(item.Value.Amount.ToString());
                column++;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            _presenter.Cancel();
            errorProviderAmount.Clear();
            errorProviderNumber.Clear();
            errorProviderOperationMethod.Clear();
            errorProviderProductID.Clear();
            errorProviderReason.Clear();
            errorProviderSellInfo.Clear();
            comboBoxOperationMethod.SelectedIndex = -1;
            listViewBuyList.Items.Clear();
            listViewRefundList.Items.Clear();
            listViewSeles.Items.Clear();
            richTextBoxReason.Clear();
            richTextBoxSellInfo.Clear();
            textBoxProductID.Clear();
            textBoxReceiptNumber.Clear();
            numericUpDownAmount.Value = 0;
        }
    }
}
