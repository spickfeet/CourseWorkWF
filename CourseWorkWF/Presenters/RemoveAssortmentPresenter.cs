using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesIterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Presenters
{
    public class RemoveAssortmentPresenter
    {
        private IAssortmentDataBase _assortment;
        private IRemoveAssortmentFormView _view;
        public RemoveAssortmentPresenter(IRemoveAssortmentFormView view)
        {
            _assortment = new AssortmentDataBase();
            _view = view;
        }
        public bool RemoveProduct() 
        {
            if(_assortment.Load().ContainsKey(_view.ProductID) == true)
            {
                _assortment.Delete(_view.ProductID, _view.Amount);
                return true;
            }
            return false;
        }
    }
}
