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
        private IAssortmentDataBase _assortmentData;
        private IDictionary<int, IProductsCollectionItem> _assortment;
        public AddAssortmentPresenter(IAddAssortmentFormView view)
        {
            _view = view;
            _assortmentData = new AssortmentDataBase();
            _assortment = _assortmentData.Load();
            _view.AddProductEvent += AddProductInAssortment;
            _view.AutocompleteEvent += Autocomplete;
        }
        public void AddProductInAssortment(object sender, EventArgs e)
        {
            _assortmentData.Add(new ProductsCollectionItem(new Product(_view.ProductName,_view.Price,_view.ProductID), _view.Amount));
            _assortment = _assortmentData.Load();
        }
        public void Autocomplete(object sender, EventArgs e)
        {
            if (_assortment.ContainsKey(_view.ProductID) == true)
            {
                _view.ProductName = _assortment[_view.ProductID].Product.ProductName;
                _view.Price = _assortment[_view.ProductID].Product.Price;
            }
        }
    }
}
