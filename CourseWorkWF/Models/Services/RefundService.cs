using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models.Services
{
    public class RefundService: IRefundService
    {
        private IDataManager _dataManager;
        public int _receiptNumber;
        public IDictionary<long, IProductsCollectionItem> ProductsRefund { get; private set; } 
        public RefundService(IDataManager dataManager) 
        {
            ProductsRefund = new Dictionary<long, IProductsCollectionItem>();
            _receiptNumber = 0;
            _dataManager = dataManager;
        }
        public ISellInfo? FindReceiptByNumber(int receiptNumber)
        {
            if (_dataManager.SalesRepository.ReadAll().ContainsKey(receiptNumber))
            {
                _receiptNumber = receiptNumber;
                return _dataManager.SalesRepository.ReadAll()[_receiptNumber];
            }
            return null;
        }
        public IEnumerable<ISellInfo> FindReceiptByDates(DateTime dateFrom,DateTime dateTo)
        {
            IList<ISellInfo> receipts = new List<ISellInfo>();
            foreach (var item in _dataManager.SalesRepository.ReadAll())
            {
                if (dateFrom.Date <= item.Value.OperationTime.Date && dateTo.Date >= item.Value.OperationTime.Date)
                    receipts.Add(item.Value);
            }
            return receipts;
        }
        public void AddRefundList(long productID, decimal amount)
        {
            if(_receiptNumber == 0)
            {
                throw new ArgumentException("Не выбран чек");
            }
            if (!_dataManager.SalesRepository.ReadAll()[_receiptNumber].Sell.Products.ContainsKey(productID))
            {
                throw new ArgumentException("В чеке нет продукта с таким ID");
            }
            else
            {
                if (_dataManager.SalesRepository.ReadAll()[_receiptNumber].Sell.Products[productID].Amount < amount)
                {
                    throw new ArgumentException("В чеке нет столько продуктов");
                }
            }
            if (ProductsRefund.ContainsKey(productID))
            {
                if (_dataManager.SalesRepository.ReadAll()[_receiptNumber].Sell.Products[productID].Amount - ProductsRefund[productID].Amount - amount < 0)
                {
                    throw new ArgumentException("В чеке нет столько продуктов");
                }
                ProductsRefund[productID].Amount += amount;
                return;
            }
            IProductsCollectionItem productRefund = new ProductsCollectionItem(_dataManager.SalesRepository.ReadAll()[_receiptNumber].Sell.Products[productID].Product, amount);
            ProductsRefund[productID] = productRefund;
            }

        public void ReturnMoney(OperationMethod operationType, string reason)
        {
            if (ProductsRefund.Count == 0)
            {
                return;
            }
            decimal moneyAmount = 0;
            foreach (var item in ProductsRefund)
            {
                moneyAmount += item.Value.Product.Price * item.Value.Amount;
            }
            int number = _dataManager.SalesRepository.ReadAll().Count + _dataManager.RefundsRepository.ReadAll().Count + 1;
            Refund refund = new Refund(ProductsRefund, new MoneyOperation(moneyAmount, operationType), reason);
            _dataManager.CurrentRevenue.ChangeRevenue(refund);
            IRefundInfo refundInfo = new RefundInfo(number, refund, _dataManager.CurrentUser, DateTime.Now);
            _dataManager.RefundsRepository.Create(refundInfo);
            ProductsRefund.Clear();
        }
        public void Cancel()
        {
            ProductsRefund.Clear();
            _receiptNumber = 0;
        }
        public string SellInfo()
        {
            return "Номер чека: " + _dataManager.SalesRepository.ReadAll()[_receiptNumber].OperationNumber +
                "\nВремя продажи: " + _dataManager.SalesRepository.ReadAll()[_receiptNumber].OperationTime +
            "\nФИО продавца: " + _dataManager.SalesRepository.ReadAll()[_receiptNumber].Employee.FullName.Surname + " " + 
            _dataManager.SalesRepository.ReadAll()[_receiptNumber].Employee.FullName.Name + " " + 
            _dataManager.SalesRepository.ReadAll()[_receiptNumber].Employee.FullName.Patronymic +
            "\nСпособ оплаты: " + _dataManager.SalesRepository.ReadAll()[_receiptNumber].Sell.MoneyOperation.Method.ToString() +
                "\nСтоимость: " + _dataManager.SalesRepository.ReadAll()[_receiptNumber].Sell.MoneyOperation.MoneyAmount;
        }
    }
}
