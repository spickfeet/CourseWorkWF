using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface
{
    public interface IHistoryService
    {
        public IEnumerable<ISellInfo> FindSalesByDates(DateTime dateTimeFrom, DateTime dateTimeTo);
        public IEnumerable<IRefundInfo> FindRefundsByDates(DateTime dateTimeFrom, DateTime dateTimeTo);
        public IEnumerable<IRevenue> FindRevenuesByDates(DateTime dateTimeFrom, DateTime dateTimeTo);
        public IEnumerable<IProductsCollectionItem> FindProductsBySelectedSellNumber(int receiptNumber);
        public IEnumerable<IProductsCollectionItem> FindProductsBySelectedRefundNumber(int receiptNumber);
        public string GetReason(int receiptNumber);
    }
}
