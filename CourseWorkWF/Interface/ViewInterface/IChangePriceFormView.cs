using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface IChangePriceFormView : IView
    {
        public long ProductID { get; }
        public decimal Price { get; }
    }
}
