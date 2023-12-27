using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;
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
        private ViewsController _viewsController;
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

        DateTime IHistoryFormView.RevenueDateFrom => dateTimePickerRevenueDateFrom.Value;

        DateTime IHistoryFormView.RevenueDateTo => dateTimePickerRefundInfoDateTo.Value;

        string IHistoryFormView.Reason { set { richTextBoxReason.Text = value; } }

        public HistoryForm(ViewsController viewsController, HistoryPresenter presenter)
        {
            _presenter = presenter;
            _viewsController = viewsController;
            InitializeComponent();
            _presenter.SelectSellNumberError += OnSetSellNumberError;
            _presenter.SelectRefundNumberError += OnSetRefundNumberError;
            FormClosed += OnClosed;
        }
        private void OnClosed(object sender, EventArgs e)
        {
            _viewsController.Closed();
            _viewsController.PrevView.Visible = true;
        }

        private void OnSetSellNumberError(string error)
        {
            errorProviderSelectSellNumber.SetError(listViewSelesInfo, error);
        }
        private void OnSetRefundNumberError(string error)
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
            IEnumerable<IProductsCollectionItem>? soldProducts = _presenter.FindProductsBySelectedSellNumber();
            if (soldProducts != null)
            {
                int lineIndex = 0;
                foreach (IProductsCollectionItem product in soldProducts)
                {
                    listViewSellProducts.Items.Add(product.Product.ProductID.ToString());
                    listViewSellProducts.Items[lineIndex].SubItems.Add(product.Product.ProductName);
                    listViewSellProducts.Items[lineIndex].SubItems.Add(product.Product.Price.ToString());
                    listViewSellProducts.Items[lineIndex].SubItems.Add(product.Amount.ToString());
                    lineIndex++;
                }
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
            richTextBoxReason.Clear();
            errorProviderSelectRefundNumber.Clear();
            listViewRefundProducts.Items.Clear();
            IEnumerable<IProductsCollectionItem>? returnedProducts = _presenter.FindProductsBySelectedRefundNumber();
            if (returnedProducts != null)
            {
                int lineIndex = 0;
                foreach (IProductsCollectionItem product in returnedProducts)
                {
                    listViewRefundProducts.Items.Add(product.Product.ProductID.ToString());
                    listViewRefundProducts.Items[lineIndex].SubItems.Add(product.Product.ProductName);
                    listViewRefundProducts.Items[lineIndex].SubItems.Add(product.Amount.ToString());
                    listViewRefundProducts.Items[lineIndex].SubItems.Add(product.Amount.ToString());
                    lineIndex++;
                }
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
