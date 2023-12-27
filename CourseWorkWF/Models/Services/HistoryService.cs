using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Models.Services
{
    public class HistoryService: IHistoryService
    {
        private IDataManager _dataManager;
        public HistoryService(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public IEnumerable<ISellInfo> FindSalesByDates(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            List<ISellInfo> salesInfoFind = new();
            foreach (var sellInfo in _dataManager.SalesRepository.ReadAll().Values)
            {
                if (dateTimeFrom.Date <= sellInfo.OperationTime.Date && dateTimeTo.Date >= sellInfo.OperationTime.Date)
                    salesInfoFind.Add(sellInfo);
            }
            return salesInfoFind;
        }
        public IEnumerable<IRefundInfo> FindRefundsByDates(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            List<IRefundInfo> refundsInfo = new();
            foreach (var refundInfo in _dataManager.RefundsRepository.ReadAll().Values)
            {
                if (dateTimeFrom.Date <= refundInfo.OperationTime.Date && dateTimeTo.Date >= refundInfo.OperationTime.Date)
                    refundsInfo.Add(refundInfo);
            }
            return refundsInfo;
        }
        public IEnumerable<IRevenue> FindRevenuesByDates(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            List<IRevenue> revenuesFind = new();
            foreach (var revenue in _dataManager.RevenueRepository.ReadAll().Values)
            {
                if (dateTimeFrom.Date <= revenue.Date.Date && dateTimeTo.Date >= revenue.Date.Date)
                    revenuesFind.Add(revenue);
            }
            return revenuesFind;
        }
        public IEnumerable<IProductsCollectionItem> FindProductsBySelectedSellNumber(int receiptNumber)
        {
            List<IProductsCollectionItem> products = new();
            if (receiptNumber < 1)
            {
                throw new ArgumentException("Некорректный номер чека прихода");
            }
            foreach (IProductsCollectionItem productsCollection in _dataManager.SalesRepository.ReadAll()[receiptNumber].Sell.Products.Values)
            {
                products.Add(productsCollection);
            }
            return products;
        }
        public IEnumerable<IProductsCollectionItem> FindProductsBySelectedRefundNumber(int receiptNumber)
        {
            List<IProductsCollectionItem> products = new();
            if (receiptNumber < 1)
            {
                throw new ArgumentException("Некорректный номер чека ухода");
            }
            foreach (IProductsCollectionItem productsCollection in _dataManager.RefundsRepository.ReadAll()[receiptNumber].Refund.Products.Values)
            {
                products.Add(productsCollection);
            }
            return products;
        }
        public string GetReason(int receiptNumber)
        {
            if (receiptNumber < 1)
            {
                throw new ArgumentException("Некорректный номер чека ухода");
            }
            return _dataManager.RefundsRepository.ReadAll()[receiptNumber].Refund.Reason;
        }
    }
}
