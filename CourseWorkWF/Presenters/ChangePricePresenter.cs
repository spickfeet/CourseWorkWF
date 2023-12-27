using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Presenters
{
    public class ChangePricePresenter
    {
        private IChangePriceFormView _view;
        private IRepository<long, IProductsCollectionItem> _assortmentData;
        public IChangePriceFormView View { get { return _view; } set { _view = value; } }
        public ChangePricePresenter(IDataManager dataManager) 
        {
            _assortmentData = new AssortmentRepository("Assortment.json");
        }
        public event EventHandler<string> IDNotFoundErrorEvent;
        public bool ChangePrice()
        {
            IDictionary<long, IProductsCollectionItem> assortment = _assortmentData.Load();
            if (assortment.ContainsKey(_view.ProductID))
            {
                assortment[_view.ProductID].Product.Price = _view.Price;
                _assortmentData.Delete(assortment[_view.ProductID]);
                _assortmentData.Create(assortment[_view.ProductID]);
                return true;
            }
            return false;
        }
    }
}
