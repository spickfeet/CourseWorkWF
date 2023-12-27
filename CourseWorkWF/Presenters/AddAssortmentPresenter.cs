using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Presenters
{
    public class AddAssortmentPresenter
    {
        private IAddAssortmentFormView _view;
        private IRepository<long, IProductsCollectionItem> _assortmentData;
        private IDictionary<long, IProductsCollectionItem> _assortment;
        public IAddAssortmentFormView View { get { return _view; } set { _view = value; } }
        public AddAssortmentPresenter(IDataManager dataManager)
        {
            _assortmentData = new AssortmentRepository("Assortment.json");
            _assortment = _assortmentData.Load();
        }
        public void AddProductInAssortment()
        {
            _assortmentData.Create(new ProductsCollectionItem(new Product(_view.ProductName,_view.Price,_view.ProductID), _view.Amount));
            _assortment = _assortmentData.Load();
        }
        public bool Autocomplete()
        {
            if (_assortment.ContainsKey(_view.ProductID) == true)
            {
                _view.ProductName = _assortment[_view.ProductID].Product.ProductName;
                _view.Price = _assortment[_view.ProductID].Product.Price;
                return true;
            }
            return false;
        }
    }
}
