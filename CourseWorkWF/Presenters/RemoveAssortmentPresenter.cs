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
        private IRepository<long, IProductsCollectionItem> _assortmentData;
        private IRemoveAssortmentFormView _view { get { return _view; } set { _view = value; } }
        public IRemoveAssortmentFormView View { get; set; }
        public RemoveAssortmentPresenter(IDataManager dataManager)
        {
            _assortmentData = new AssortmentRepository("Assortment.json");
            _assortment = _assortmentData.Load();
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
