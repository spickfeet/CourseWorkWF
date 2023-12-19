using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
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
        IChangePriceFormView _view;
        IAssortmentDataBase _assortmentData;
        public ChangePricePresenter(IChangePriceFormView view) 
        {
            _assortmentData = new AssortmentDataBase();
            _view = view;
        }
        public event EventHandler<string> IDNotFoundErrorEvent;
        public void ChangePrice()
        {
            IDictionary<int, IProductsCollectionItem> assortment = _assortmentData.Load();
            if (assortment.ContainsKey(_view.ProductID))
            {
                assortment[_view.ProductID].Product.Price = _view.Price;
                _assortmentData.Delete(_view.ProductID, assortment[_view.ProductID].Amount);
                _assortmentData.Add(assortment[_view.ProductID]);
            }
            IDNotFoundErrorEvent?.Invoke(this, "Нет продукта с таким ID");
        }
    }
}
