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
        IFullName FullName { get; set; }
        JobTitle Post { get; set; }

    }
}
