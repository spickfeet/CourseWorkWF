using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IProduct
    {
        public long ProductID { get; set;}
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public IProduct Clone();
    }
}
