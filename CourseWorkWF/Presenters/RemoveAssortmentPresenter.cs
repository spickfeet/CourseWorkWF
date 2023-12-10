using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Presenters
{
    public class RemoveAssortmentPresenter
    {
        private AssortmentDictionary assortment = new();
        private IRemoveAssortmentFormView _view;
        public RemoveAssortmentPresenter(IRemoveAssortmentFormView view)
        {
            _view = view;
        }
        public bool RemoveProduct() 
        {
            if(assortment.ProductsAssortment.ContainsKey(_view.ProductID) == true)
            {
                assortment.RemoveProducts(_view.ProductID, _view.Amount);
                return true;
            }
            return false;
        }
    }
}
