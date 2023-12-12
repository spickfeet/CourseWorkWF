using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IOperationInfo
    {
        public int OperationNumber { get; set; }
        public DateTime OperationTime { get; set; }
        public IEmployee Employee { get; set; }
    }
}
