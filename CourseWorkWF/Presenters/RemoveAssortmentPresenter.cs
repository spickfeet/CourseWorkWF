using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface.AssortmentServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Services;

namespace CourseWorkWF.Presenters
{
    public class RemoveAssortmentPresenter
    {
        private IAssortmentRemoverService _model;
        private IRemoveAssortmentFormView _view;
        public IRemoveAssortmentFormView View { get { return _view; } set { _view = value; } }
        public RemoveAssortmentPresenter(IDataManager dataManager)
        {
            _model = new AssortmentService(dataManager);
        }
        public bool RemoveProduct() 
        {
            return _model.RemoveProduct(_view.ProductID, _view.Amount);
        }
    }
}
