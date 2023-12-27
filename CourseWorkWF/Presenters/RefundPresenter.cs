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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Presenters
{
    public class RefundPresenter
    {
        private IRefundService _model;
        public IDictionary<long, IProductsCollectionItem> ProductsRefund { get { return _model.ProductsRefund; } }
        public IRefundFormView View { get; set; }
        public event Action<string> AddError;
        public RefundPresenter(IDataManager dataManager)
        {
            _model = new RefundService(dataManager);
        }
        public ISellInfo? FineReceiptByNumber()
        {
            ISellInfo? sellInfo = _model.FindReceiptByNumber(View.ReceiptNumber);
            if(sellInfo != null)
            {
                View.SellInfo = _model.SellInfo();
            }
            return sellInfo;
        }
        public ISellInfo? FineReceiptBySelectedReceiptNumber()
        {
            ISellInfo? sellInfo = _model.FindReceiptByNumber(View.SelectedReceiptNumber);
            if (sellInfo != null)
            {
                View.SellInfo = _model.SellInfo();
            }
            return sellInfo;
        }
        public IEnumerable<ISellInfo> FineReceiptByDates()
        {
            return _model.FindReceiptByDates(View.DateFrom, View.DateTo);
        }
        public void AddRefundList()
        {
            try
            {
                _model.AddRefundList(View.ProductID, View.Amount);
            }
            catch (Exception ex)
            {
                AddError.Invoke(ex.Message);
            }
        }
        public void ReturnMoney()
        {
            _model.ReturnMoney(View.OperationType, View.Reason);
        }
        public void Cancel()
        {
            _model.Cancel();
        }
    }
}
