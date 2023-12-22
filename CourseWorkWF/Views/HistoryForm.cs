using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Views
{
    public partial class HistoryForm : Form, IHistoryFormView
    {
        private HistoryPresenter _presenter;
        DateTime IHistoryFormView.SellInfoDateFrom => dateTimePickerSellInfoDateFrom.Value;

        DateTime IHistoryFormView.SellInfoDateTo => dateTimePickerSellInfoDateTo.Value;

        int IHistoryFormView.SelectSellNumber
        {
            get
            {
                if (listViewSelesInfo.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return int.Parse(listViewSelesInfo.SelectedItems[0].Text);
            }
        }

        DateTime IHistoryFormView.RefundInfoDateFrom => dateTimePickerRefundInfoDateFrom.Value;

        DateTime IHistoryFormView.RefundInfoDateTo => dateTimePickerRefundInfoDateTo.Value;

        int IHistoryFormView.SelectRefundNumber
        {
            get
            {
                if (listViewRefundsInfo.SelectedItems.Count == 0)
                {
                    return 0;
                }
                return int.Parse(listViewRefundsInfo.SelectedItems[0].Text);
            }
        }

        DateTime IHistoryFormView.RevenueInfoDateFrom => dateTimePickerRevenueDateFrom.Value;

        DateTime IHistoryFormView.RevenueInfoDateTo => dateTimePickerRefundInfoDateTo.Value;
        public HistoryForm()
        {
            _presenter = new(this);
            InitializeComponent();
            _presenter.SelectSellNumberErrorEvent += SetSellNumberError;
            _presenter.SelectRefundNumberErrorEvent += SetRefundNumberError;
        }

        private void SetSellNumberError(object? sender, string error)
        {
            errorProviderSelectSellNumber.SetError(listViewSelesInfo, error);
        }
        private void SetRefundNumberError(object? sender, string error)
        {
            errorProviderSelectRefundNumber.SetError(listViewRefundsInfo, error);
        }


        private void ButtonFindSelesInfoByDate_Click(object sender, EventArgs e)
        {
            listViewSelesInfo.Items.Clear();
            int lineIndex = 0;
            foreach (ISellInfo sellInfo in _presenter.FindSalesByDates())
            {
                listViewSelesInfo.Items.Add(sellInfo.OperationNumber.ToString());
                listViewSelesInfo.Items[lineIndex].SubItems.Add(sellInfo.Sell.MoneyOperation.MoneyAmount.ToString());
                listViewSelesInfo.Items[lineIndex].SubItems.Add(sellInfo.Employee.FullName.Name);
                listViewSelesInfo.Items[lineIndex].SubItems.Add(sellInfo.Employee.FullName.Surname);
                listViewSelesInfo.Items[lineIndex].SubItems.Add(sellInfo.Sell.MoneyOperation.Method.ToString());
                listViewSelesInfo.Items[lineIndex].SubItems.Add(sellInfo.OperationTime.ToString());
                lineIndex++;
            }
        }

        private void ButtonGetSellProducts_Click(object sender, EventArgs e)
        {
            errorProviderSelectSellNumber.Clear();
            listViewSellProducts.Items.Clear();
            int lineIndex = 0;
            foreach (IProductsCollectionItem product in _presenter.FineProductsBySelectedSellNumber())
            {
                listViewSellProducts.Items.Add(product.Product.ProductID.ToString());
                listViewSellProducts.Items[lineIndex].SubItems.Add(product.Product.ProductName);
                listViewSellProducts.Items[lineIndex].SubItems.Add(product.Amount.ToString());
                listViewSellProducts.Items[lineIndex].SubItems.Add(product.Amount.ToString());
                lineIndex++;
            }
        }

        private void ButtonRefundsInfoDate_Click(object sender, EventArgs e)
        {
            listViewRefundsInfo.Items.Clear();
            int lineIndex = 0;
            foreach (IRefundInfo refundInfo in _presenter.FindRefundsByDates())
            {
                listViewRefundsInfo.Items.Add(refundInfo.OperationNumber.ToString());
                listViewRefundsInfo.Items[lineIndex].SubItems.Add(refundInfo.Refund.MoneyOperation.MoneyAmount.ToString());
                listViewRefundsInfo.Items[lineIndex].SubItems.Add(refundInfo.Employee.FullName.Name);
                listViewRefundsInfo.Items[lineIndex].SubItems.Add(refundInfo.Employee.FullName.Surname);
                listViewRefundsInfo.Items[lineIndex].SubItems.Add(refundInfo.Refund.MoneyOperation.Method.ToString());
                listViewRefundsInfo.Items[lineIndex].SubItems.Add(refundInfo.OperationTime.ToString());
                lineIndex++;
            }
        }

        private void ButtonGetRefundProducts_Click(object sender, EventArgs e)
        {
            listViewRefundProducts.Items.Clear();
            int lineIndex = 0;
            foreach (IProductsCollectionItem product in _presenter.FineProductsBySelectedRefundNumber())
            {
                listViewRefundProducts.Items.Add(product.Product.ProductID.ToString());
                listViewRefundProducts.Items[lineIndex].SubItems.Add(product.Product.ProductName);
                listViewRefundProducts.Items[lineIndex].SubItems.Add(product.Amount.ToString());
                listViewRefundProducts.Items[lineIndex].SubItems.Add(product.Amount.ToString());
                lineIndex++;
            }
        }

        private void ButtonRevenueInfoDate_Click(object sender, EventArgs e)
        {
            listViewRevenues.Items.Clear();
            int lineIndex = 0;
            foreach (IRevenue revenue in _presenter.FindRevenuesByDates())
            {
                listViewRevenues.Items.Add(revenue.Proceeds.ToString());
                listViewRevenues.Items[lineIndex].SubItems.Add(revenue.Date.Date.ToString());
                lineIndex++;
            }
        }
    }
}
