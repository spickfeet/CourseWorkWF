using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IEmployee
    {
        public IFullName FullName { get; set; }
        public JobTitle Post { get; set; }

    }
}
