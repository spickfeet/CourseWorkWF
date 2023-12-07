using CourseWorkWF.Interface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Presenters
{
    public class AddAsortmentPresenter
    {
        private IAddAssortmentFormView _view;

        public AddAsortmentPresenter(IAddAssortmentFormView view)
        {
            _view = view;
            _view.AddProductEvent += AddProductInAssortment;
            _view.AutocompleteEvent += Autocomplete;
        }
        public void AddProductInAssortment(object sender, EventArgs e)
        {
            AssortmentDictionary.Instance().AddProducts(_view.ProductID, _view.ProductName, _view.Price, _view.Amount);
        }
        public void Autocomplete(object sender, EventArgs e)
        {
            if(AssortmentDictionary.Instance().ProductsAssortment.ContainsKey(_view.ProductID) == true)
            {
                _view.ProductName = AssortmentDictionary.Instance().ProductsAssortment[_view.ProductID].Product.Name;
                _view.Price = AssortmentDictionary.Instance().ProductsAssortment[_view.ProductID].Product.Price;
            }
        }
    }
}
