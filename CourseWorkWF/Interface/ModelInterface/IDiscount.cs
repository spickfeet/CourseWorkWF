using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IDiscount
    {
        public decimal Discount { get; set; }
        public decimal UseDiscount(decimal price);
    }
}
