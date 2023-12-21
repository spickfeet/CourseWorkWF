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
        private ISellInfo? _sellInfo;
        private IEmployee _employee;
        private IRevenue _revenue;
        private int _receiptSellNumber;
        private bool _haveError;
        public event EventHandler<string> AmountErrorEvent;
        public event EventHandler<string> ProductIDErrorEvent;
        public event EventHandler<string> SellInfoErrorEvent;
        public IDictionary<int, IProductsCollectionItem> ProductsRefund { get { return _productsRefund; } }
        public RefundPresenter(IRefundFormView view, IEmployee employee, IRevenue revenue)
        {
            _revenue = revenue;
            _haveError = false;
            _employee = employee;
            _refundInfoData = new RefundInfoDataBase();
            _sellInfoData = new SellInfoDataBase();
            _productsRefund = new Dictionary<int, IProductsCollectionItem>();
            _salesInfo = _sellInfoData.Load();
            _view = view;
            _receiptSellNumber = 0;
        }

        public ISellInfo? FineReceiptByNumber()
        {
            if (_salesInfo.ContainsKey(_view.ReceiptNumber))
            {
                _receiptSellNumber = _view.ReceiptNumber;
                _sellInfo = _salesInfo[_receiptSellNumber];
                SellInfo();
                return _sellInfo;
            }
            return null;
        }
        public ISellInfo? FineReceiptBySelectedReceiptNumber()
        {
            if (_salesInfo.ContainsKey(_view.SelectedReceiptNumber))
            {
                _receiptSellNumber = _view.SelectedReceiptNumber;
                _sellInfo = _salesInfo[_view.SelectedReceiptNumber];
                SellInfo();
                return _sellInfo;
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
            if(_sellInfo == null)
            {
                SellInfoErrorEvent.Invoke(this, "Получите информацию о продаже");
                return;
            }
            _haveError = false;
            if (!_sellInfo.Sell.Products.ContainsKey(_view.ProductID))
            {
                ProductIDErrorEvent?.Invoke(this,"В чеке нет продукта с таким ID");
                _haveError = true;
            }
            else
            {
                if (_sellInfo.Sell.Products[_view.ProductID].Amount < _view.Amount)
                {
                    AmountErrorEvent?.Invoke(this, "В чеке нет столько продуктов");
                    _haveError = true;
                }
            }
            if (ProductsRefund.ContainsKey(_view.ProductID))
            {
                if (_sellInfo.Sell.Products[_view.ProductID].Amount - ProductsRefund[_view.ProductID].Amount - _view.Amount < 0)
                {
                    AmountErrorEvent?.Invoke(this, "В чеке нет столько продуктов");
                    return;
                }
                ProductsRefund[_view.ProductID].Amount += _view.Amount;
                return;
            }
            if(_haveError == false)
            {
                IProductsCollectionItem productRefund = new ProductsCollectionItem(_salesInfo[_receiptSellNumber].Sell.Products[_view.ProductID].Product, _view.Amount);
                ProductsRefund[_view.ProductID] = productRefund;
            }
            return;
        }
        public void ReturnMoney()
        {
            if(ProductsRefund.Count == 0)
            {
                return;
            }
            decimal moneyAmount = 0;
            foreach (var item in ProductsRefund) 
            {
                moneyAmount += item.Value.Product.Price * item.Value.Amount;
            }
            int number = _salesInfo.Count + _sellInfoData.Load().Count + 1;
            Refund refund = new Refund(_productsRefund, new MoneyOperation(moneyAmount, _view.OperationType), _view.Reason);
            _revenue.ChangeRevenue(refund);
            IRefundInfo refundInfo = new RefundInfo(number, refund, _employee, DateTime.Now);
            _refundInfoData.Add(refundInfo);
            _productsRefund.Clear();
        }
        public void Cancel()
        {
            ProductsRefund.Clear();
            _sellInfo = null;
            _receiptSellNumber = 0;
            _haveError = false;

        }
        private void SellInfo()
        {
            _view.SellInfo = "Номер чека: " + _sellInfo.OperationNumber +
                "\nВремя продажи: " + _sellInfo.OperationTime +
                "\nФИО продавца: " + _sellInfo.Employee.FullName.Surname + " " + _sellInfo.Employee.FullName.Name + " " + _sellInfo.Employee.FullName.Patronymic +
                "\nСпособ оплаты: " + _sellInfo.Sell.MoneyOperation.Method.ToString() +
                "\nСтоимость: " + _sellInfo.Sell.MoneyOperation.MoneyAmount;
        }
    }
}
