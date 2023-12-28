using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class HistoryPresenter
    {
        private IHistoryService _model;
        public IHistoryFormView View { get; set; }
        public HistoryPresenter (IDataManager dataManager) 
        {
            _model = new HistoryService(dataManager);
        }
        public event Action<string>? SelectSellNumberError;
        public event Action<string>? SelectRefundNumberError;
        public IEnumerable<ISellInfo> FindSalesByDates()
        {
            return _model.FindSalesByDates(View.SellInfoDateFrom.Date, View.SellInfoDateTo.Date);
        }
        public IEnumerable<IRefundInfo> FindRefundsByDates()
        {
            return _model.FindRefundsByDates(View.RefundInfoDateFrom.Date, View.RefundInfoDateTo.Date);
        }
        public IEnumerable<IRevenue> FindRevenuesByDates()
        {
            return _model.FindRevenuesByDates(View.RevenueDateFrom.Date, View.RevenueDateTo.Date);
        }
        public IEnumerable<IProductsCollectionItem>? FindProductsBySelectedSellNumber()
        {
            try
            {
                return _model.FindProductsBySelectedSellNumber(View.SelectSellNumber);
            }
            catch (Exception ex)
            {
                SelectSellNumberError?.Invoke(ex.Message);
                return null;
            }
        }
        public IEnumerable<IProductsCollectionItem>? FindProductsBySelectedRefundNumber()
        {
            try
            {
                View.Reason = _model.GetReason(View.SelectRefundNumber);
                return _model.FindProductsBySelectedRefundNumber(View.SelectRefundNumber);
            }
            catch (Exception ex)
            {
                SelectRefundNumberError?.Invoke(ex.Message);
                return null;
            }

}

    }
}
