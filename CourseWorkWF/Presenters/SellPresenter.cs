using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Services;
using CourseWorkWF.Views;
using Microsoft.VisualBasic.ApplicationServices;

namespace CourseWorkWF.Presenters
{
    public class SellPresenter
    {
        private ISellService _model;
        public IDictionary<long, IProductsCollectionItem> BuyProducts { get { return _model.BuyProducts; } }
        public ISellFormView View { get; set; }
        public SellPresenter(IDataManager dataManager)
        {
            _model = new SellService(dataManager);
        }
        public event Action<string>? AddError;

        public void CancelBuyProducts()
        {
            _model.CancelBuyProducts();
        }
        public void GetMoneyChangeBuyer()
        {
            View.MoneyChangeBuyer = _model.GetMoneyChangeBuyer(View.Cash, View.Price);
        }

        public void DiscountUse()
        {
            _model.DiscountUse(View.Discount);
            View.Price = _model.Price;
        }

        public void AddProduct()
        {
            try
            {
            _model.AddProduct(View.ProductID, View.Amount);
            }
            catch(Exception ex) 
            {
                AddError?.Invoke(ex.Message);
            }  
            View.Price = _model.Price;
        }
        public void SellOut()
        {
            _model.SellOut(View.OperationMethod);
        }
    }
}
