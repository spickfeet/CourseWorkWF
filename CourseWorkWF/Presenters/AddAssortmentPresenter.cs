using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface.AssortmentServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Services;

namespace CourseWorkWF.Presenters
{
    public class AddAssortmentPresenter
    {
        private IAddAssortmentFormView _view;
        private IDataManager _dataManager;
        private IAssortmentAdderService _model;
        public IAddAssortmentFormView View { get { return _view; } set { _view = value; } }
        public AddAssortmentPresenter(IDataManager dataManager)
        {
            _model = new AssortmentService(dataManager);
            _dataManager = dataManager;
        }

        public bool AddProductInAssortment()
        {
            return _model.Add(_view.ProductName, _view.Price, _view.ProductID, _view.Amount);
        }

        public bool Autocomplete()
        {
            if (_dataManager.AssortmentRepository.ReadAll().ContainsKey(_view.ProductID) == true)
            {
                _view.ProductName = _dataManager.AssortmentRepository.ReadAll()[_view.ProductID].Product.ProductName;
                _view.Price = _dataManager.AssortmentRepository.ReadAll()[_view.ProductID].Product.Price;
                return true;
            }
            return false;
        }
    }
}
