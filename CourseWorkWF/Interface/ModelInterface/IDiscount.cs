using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IDiscount
    {
        decimal Discount { get; set; }
        decimal UseDiscount(decimal price);
    }
}
