using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Presenters
{
    public class AddAssortmentPresenter
    {
        private IAddAssortmentFormView _view;
        private AssortmentDictionary assortment = new();
        public AddAssortmentPresenter(IAddAssortmentFormView view)
        {
            _view = view;
            _view.AddProductEvent += AddProductInAssortment;
            _view.AutocompleteEvent += Autocomplete;
        }
        public void AddProductInAssortment(object sender, EventArgs e)
        {
            assortment.AddProducts(_view.ProductID, _view.ProductName, _view.Price, _view.Amount);
        }
        public void Autocomplete(object sender, EventArgs e)
        {
            if (assortment.ProductsAssortment.ContainsKey(_view.ProductID) == true)
            {
                _view.ProductName = assortment.ProductsAssortment[_view.ProductID].Product.Name;
                _view.Price = assortment.ProductsAssortment[_view.ProductID].Product.Price;
            }
        }
    }
}
