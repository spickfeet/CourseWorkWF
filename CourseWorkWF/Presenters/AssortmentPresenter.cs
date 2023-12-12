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
        private IAssortmentDataBase _assortment;
        public AssortmentPresenter()
        {
            _assortment = new AssortmentDataBase();
        }
        public IDictionary<int,IProductsCollectionItem> GetAssortment()
        {
            return _assortment.Load();
        }
    }
}
