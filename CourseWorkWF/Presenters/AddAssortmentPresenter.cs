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
        private IAssortmentDataBase _assortment;
        public AddAssortmentPresenter(IAddAssortmentFormView view)
        {
            _view = view;
            _assortment = new AssortmentDataBase();
            _view.AddProductEvent += AddProductInAssortment;
            _view.AutocompleteEvent += Autocomplete;
        }
        public void AddProductInAssortment(object sender, EventArgs e)
        {
            _assortment.Add(new ProductsCollectionItem(new Product(_view.ProductName,_view.Price,_view.ProductID), _view.Amount));
        }
        public void Autocomplete(object sender, EventArgs e)
        {
            if (_assortment.Load().ContainsKey(_view.ProductID) == true)
            {
                _view.ProductName = _assortment.Load()[_view.ProductID].Product.Name;
                _view.Price = _assortment.Load()[_view.ProductID].Product.Price;
            }
        }
    }
}
