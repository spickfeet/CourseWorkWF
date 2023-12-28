using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IOperationInfo
    {
        public int OperationNumber { get; }
        public DateTime OperationTime { get; }
        public IEmployee Employee { get; }
    }
}
