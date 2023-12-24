using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class HistoryPresenter
    {
        private IHistoryFormView _view;
        private IRefundInfoDataBase _refundInfoData;
        private ISellInfoDataBase _sellInfoData;
        private IRevenueDataBase _revenueData;
        private IDictionary<int, IRefundInfo> _refundsInfo;
        private IDictionary<int, ISellInfo> _salesInfo;
        private IList<IRevenue> _revenues;

        public HistoryPresenter (IHistoryFormView view) 
        {
            _view = view;
            _refundInfoData = new RefundInfoDataBase();
            _sellInfoData = new SellInfoDataBase();
            _revenueData = new RevenueDataBase();
            _refundsInfo = _refundInfoData.Load();
            _salesInfo = _sellInfoData.Load();
            _revenues = _revenueData.Load();
        }
        public event EventHandler<string> SelectSellNumberErrorEvent;
        public event EventHandler<string> SelectRefundNumberErrorEvent;
        public IList<ISellInfo> FindSalesByDates()
        {
            IList<ISellInfo> salesInfoFind = new List<ISellInfo>();
            foreach (var sellInfo in _salesInfo)
            {
                if (_view.SellInfoDateFrom.Date <= sellInfo.Value.OperationTime.Date && _view.SellInfoDateTo.Date >= sellInfo.Value.OperationTime.Date)
                    salesInfoFind.Add(sellInfo.Value);
            }
            return salesInfoFind;
        }
        public IList<IRefundInfo> FindRefundsByDates()
        {
            IList<IRefundInfo> refundsInfo = new List<IRefundInfo>();
            foreach (var refundInfo in _refundsInfo)
            {
                if (_view.RefundInfoDateFrom.Date <= refundInfo.Value.OperationTime.Date && _view.RefundInfoDateTo.Date >= refundInfo.Value.OperationTime.Date)
                    refundsInfo.Add(refundInfo.Value);
            }
            return refundsInfo;
        }
        public IList<IRevenue> FindRevenuesByDates()
        {
            IList<IRevenue> revenuesFind = new List<IRevenue>();
            foreach (var revenue in _revenues)
            {
                if (_view.SellInfoDateFrom.Date <= revenue.Date.Date && _view.SellInfoDateFrom.Date >= revenue.Date.Date)
                    revenuesFind.Add(revenue);
            }
            return revenuesFind;
        }
        public IList<IProductsCollectionItem>? FineProductsBySelectedSellNumber()
        {
            IList<IProductsCollectionItem> products = new List<IProductsCollectionItem>();
            if(_view.SelectSellNumber == 0)
            {
                SelectSellNumberErrorEvent.Invoke(this, "Выберите чек прихода");
                return products;
            }
            foreach(IProductsCollectionItem productsCollection in _salesInfo[_view.SelectSellNumber].Sell.Products.Values)
            {
                products.Add(productsCollection);
            }
            return products;
        }
        public IList<IProductsCollectionItem>? FineProductsBySelectedRefundNumber()
        {
            IList<IProductsCollectionItem> products = new List<IProductsCollectionItem>();
            if (_view.SelectRefundNumber == 0)
            {
                SelectRefundNumberErrorEvent.Invoke(this, "Выберите чек ухода");
                return products;
            }
            foreach (IProductsCollectionItem productsCollection in _refundsInfo[_view.SelectRefundNumber].Refund.Products.Values)
            {
                products.Add(productsCollection);
            }
            _view.Reason = _refundsInfo[_view.SelectRefundNumber].Refund.Reason;
            return products;
        }

    }
}
