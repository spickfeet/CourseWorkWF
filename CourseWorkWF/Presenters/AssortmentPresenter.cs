using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class AssortmentPresenter
    {
        private IDataManager _dataManager;
        public IReadOnlyDictionary<long, IProductsCollectionItem> Assortment
        {
            get { return _dataManager.AssortmentRepository.ReadAll(); }
        } 

        public AssortmentPresenter(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }
    }
}
