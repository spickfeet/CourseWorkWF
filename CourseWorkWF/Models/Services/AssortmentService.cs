using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models.Services
{
    public class AssortmentService
    {
        private IRepository<long,IProductsCollectionItem> _assortmentData;
        public AssortmentService()
        {
            _assortmentData = new AssortmentRepository("Assortment");
        }

    }
}
