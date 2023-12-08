using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IProductsCollectionItem
    {
        IProduct Product { get; set; }
        decimal Amount { get; set; }
    }
}
