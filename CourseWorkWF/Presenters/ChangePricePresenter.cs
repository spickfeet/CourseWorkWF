using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface.AssortmentServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Presenters
{
    public class ChangePricePresenter
    {
        private IAssortmentChangerPriceService _model;
        public IChangePriceFormView View { get; set; }
        public ChangePricePresenter(IDataManager dataManager) 
        {
            _model = new AssortmentService(dataManager);
        }
        public bool ChangePrice()
        {
            return _model.ChangePrice(View.ProductID, View.Price);
        }
    }
}
