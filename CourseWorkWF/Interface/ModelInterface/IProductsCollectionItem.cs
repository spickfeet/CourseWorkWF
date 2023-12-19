using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IProductsCollectionItem
    {
        public IProduct Product { get; set; }
        public decimal Amount { get; set; }
    }
}
