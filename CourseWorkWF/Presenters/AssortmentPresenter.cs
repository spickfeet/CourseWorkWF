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
        private AssortmentDictionary _assortment = new();
        public void UpdateAssortment()
        {
            _assortment.UpdateAssortment();
        }
        public IDictionary<int,IProductsCollectionItem> GetAssortment()
        {
            return _assortment.ProductsAssortment;
        }
    }
}
