using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface
{
    public interface IRefundService
    {
        public IDictionary<long, IProductsCollectionItem> ProductsRefund { get; }
        public ISellInfo? FindReceiptByNumber(int receiptNumber);
        public IEnumerable<ISellInfo> FindReceiptByDates(DateTime dateFrom, DateTime dateTo);
        public void AddRefundList(long productID, decimal amount);
        public void ReturnMoney(OperationMethod operationType, string reason);
        public void Cancel();
        public string SellInfo();
    }
}
