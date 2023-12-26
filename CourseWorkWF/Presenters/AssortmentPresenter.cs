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
        private IRepository<long, IProductsCollectionItem> _assortmentData;
        public IDictionary<long, IProductsCollectionItem> Assortment 
        {
            get { return _assortmentData.Load();} 
        }
        public AssortmentPresenter()
        {
            _assortmentData = new AssortmentRepository("Assortment.json");
        }
    }
}
