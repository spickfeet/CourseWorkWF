using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Presenters
{
    public class RemoveAssortmentPresenter
    {
        private IDictionary<long, IProductsCollectionItem> _assortment;
        private IAssortmentDataBase _assortmentData;
        private IRemoveAssortmentFormView _view;
        public RemoveAssortmentPresenter(IRemoveAssortmentFormView view)
        {
            _assortmentData = new AssortmentDataBase();
            _assortment = _assortmentData.Load();
            _view = view;
        }
        public bool RemoveProduct() 
        {
            if(_assortment.ContainsKey(_view.ProductID) == true)
            {
                _assortmentData.Delete(new ProductsCollectionItem(_assortment[_view.ProductID].Product, _view.Amount));
                return true;
            }
            return false;
        }
    }
}
