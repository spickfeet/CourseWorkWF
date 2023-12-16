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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Views
{
    public partial class RefundForm : Form, IRefundFormView
    {
        private RefundPresenter _presenter;

        int IRefundFormView.ReceiptNumber => int.Parse(textBoxReceiptNumber.Text);

        int IRefundFormView.SelectedReceiptNumber => int.Parse(listViewSeles.SelectedItems[0].Text);

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

        public RefundForm(IEmployee employee)
        {
            _presenter = new RefundPresenter(this, employee);
            InitializeComponent();
        }
        private void textBoxNumerical_KeyPressNotNumber(object sender, KeyPressEventArgs e) // Запрет на все кроме цифр
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.KeyChar = '\0';
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonRefund_Click(object sender, EventArgs e)
        {
            _presenter.ReturnMoney();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

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
            listViewSeles.Items.Clear();
            if (checkBoxFindByDate.Checked == false)
            {
                if (_presenter.FineReceiptByNumber() == null)
                {
                    errorProviderNumber.SetError(textBoxReceiptNumber, "Нет чека с таким номером");
                }
                else
                {
                    listViewSeles.Items.Add(_presenter.FineReceiptByNumber().OperationNumber.ToString());
                    listViewSeles.Items[0].SubItems.Add(_presenter.FineReceiptByNumber().Sell.MoneyOperation.MoneyAmount.ToString());
                    listViewSeles.Items[0].SubItems.Add(_presenter.FineReceiptByNumber().OperationTime.ToString());

                    SellInfo(_presenter.FineReceiptByNumber());

                    listViewBuyList.Items.Clear();
                    int column = 0;
                    foreach (var item in _presenter.FineReceiptByNumber().Sell.Products)
                    {
                        listViewBuyList.Items.Add(item.Value.Product.ProductID.ToString());
                        listViewBuyList.Items[column].SubItems.Add(item.Value.Product.Name.ToString());
                        listViewBuyList.Items[column].SubItems.Add(item.Value.Product.Price.ToString());
                        listViewBuyList.Items[column].SubItems.Add(item.Value.Amount.ToString());
                        column++;
                    }
                }
            }
            else
            {
                int column = 0;
                foreach (var item in _presenter.FineReceiptByDates())
                {
                    listViewSeles.Items.Add(item.OperationNumber.ToString());
                    listViewSeles.Items[column].SubItems.Add(item.Sell.MoneyOperation.MoneyAmount.ToString());
                    listViewSeles.Items[column].SubItems.Add(item.OperationTime.ToString());
                    column++;
                }
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            SellInfo(_presenter.FineReceiptBySelectedReceiptNumber());
            listViewBuyList.Items.Clear();
            int column = 0;
            foreach (var item in _presenter.FineReceiptBySelectedReceiptNumber().Sell.Products)
            {
                listViewBuyList.Items.Add(item.Value.Product.ProductID.ToString());
                listViewBuyList.Items[column].SubItems.Add(item.Value.Product.Name.ToString());
                listViewBuyList.Items[column].SubItems.Add(item.Value.Product.Price.ToString());
                listViewBuyList.Items[column].SubItems.Add(item.Value.Amount.ToString());
                column++;
            }
        }
        private void SellInfo(ISellInfo sellInfo)
        {
            richTextBoxSellInfo.Text = "Номер чека: " + sellInfo.OperationNumber +
                "\nВремя продажи: " + sellInfo.OperationTime +
                "\nФИО продавца: " + sellInfo.Employee.FullName.Surname + " " + sellInfo.Employee.FullName.Name + " " + sellInfo.Employee.FullName.Patronymic +
                "\nСпособ оплаты: " + sellInfo.Sell.MoneyOperation.Method.ToString() +
                "\nСтоимость: " + sellInfo.Sell.MoneyOperation.MoneyAmount;
        }

        private void buttonAddProductRefundList_Click(object sender, EventArgs e)
        {
            _presenter.AddRefundList();
            listViewRefundList.Items.Clear();
            int column = 0;
            foreach (var item in _presenter.ProductsRefund)
            {
                listViewRefundList.Items.Add(item.Value.Product.ProductID.ToString());
                listViewRefundList.Items[column].SubItems.Add(item.Value.Product.Name.ToString());
                listViewRefundList.Items[column].SubItems.Add(item.Value.Product.Price.ToString());
                listViewRefundList.Items[column].SubItems.Add(item.Value.Amount.ToString());
                column++;
            }
        }
    }
}
