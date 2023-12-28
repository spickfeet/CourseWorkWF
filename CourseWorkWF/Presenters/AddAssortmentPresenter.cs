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
        private IDataManager _dataManager;
        private IAssortmentAdderService _model;
        public IAddAssortmentFormView View { get; set; }
        public AddAssortmentPresenter(IDataManager dataManager)
        {
            _model = new AssortmentService(dataManager);
            _dataManager = dataManager;
        }

        public bool AddProductInAssortment()
        {
            return _model.Add(View.ProductName, View.Price, View.ProductID, View.Amount);
        }

        public bool Autocomplete()
        {
            if (_dataManager.AssortmentRepository.ReadAll().ContainsKey(View.ProductID) == true)
            {
                View.ProductName = _dataManager.AssortmentRepository.ReadAll()[View.ProductID].Product.ProductName;
                View.Price = _dataManager.AssortmentRepository.ReadAll()[View.ProductID].Product.Price;
                return true;
            }
            return false;
        }
    }
}
