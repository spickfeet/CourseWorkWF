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
    public class RefundPresenter
    {
        private IRefundFormView _view;
        private IDictionary<int,ISellInfo> _salesInfo;
        private IDictionary<int, IProductsCollectionItem> _productsRefund;
        private IRefundInfoDataBase _refundInfoData;
        private ISellDataBase _sellInfoData;
        private IEmployee _employee;
        private int _receiptSellNumber = 0;
        public IDictionary<int, IProductsCollectionItem> ProductsRefund { get { return _productsRefund; } }
        public RefundPresenter(IRefundFormView view, IEmployee employee)
        {
            _employee = employee;
            _refundInfoData = new RefundInfoDataBase();
            _sellInfoData = new SellInfoDataBase();
            _productsRefund = new Dictionary<int, IProductsCollectionItem>();
            _salesInfo = _sellInfoData.Load();
            _view = view;
        }

        public ISellInfo? FineReceiptByNumber()
        {
            if (_salesInfo.ContainsKey(_view.ReceiptNumber))
            {
                _receiptSellNumber = _view.ReceiptNumber;
                return _salesInfo[_view.ReceiptNumber];
            }
            return null;
        }
        public ISellInfo? FineReceiptBySelectedReceiptNumber()
        {
            if (_salesInfo.ContainsKey(_view.SelectedReceiptNumber))
            {
                _receiptSellNumber = _view.SelectedReceiptNumber;
                return _salesInfo[_view.SelectedReceiptNumber];
            }
            return null;
        }
        public IList<ISellInfo> FineReceiptByDates()
        {
            IList<ISellInfo> receipts = new List<ISellInfo>();
            foreach (var item in _salesInfo)
            {
                if (_view.DateFrom < item.Value.OperationTime && _view.DateTo > item.Value.OperationTime)
                    receipts.Add(item.Value);
            }
            return receipts;
        }
        public void AddRefundList()
        {
            if (_productsRefund.ContainsKey(_view.ProductID))
            {
                _productsRefund[_view.ProductID].Amount += _view.Amount;
                return;
            }
            IProductsCollectionItem productRefund = new ProductsCollectionItem(_salesInfo[_receiptSellNumber].Sell.Products[_view.ProductID].Product, _view.Amount);
            _productsRefund[_view.ProductID] = productRefund;
            return;
        }
        public void ReturnMoney()
        {
            decimal moneyAmount = 0;
            foreach (var item in ProductsRefund) 
            {
                moneyAmount += item.Value.Product.Price;
            }
            int number = _sellInfoData.Load().Count + _sellInfoData.Load().Count + 1;
            IRefund refund = new Refund(_productsRefund, new MoneyOperation(moneyAmount, _view.OperationType), _view.Reason);
            IRefundInfo refundInfo = new RefundInfo(number, refund, _employee, DateTime.Now);
            _refundInfoData.Add(refundInfo);
        }
    }
}
