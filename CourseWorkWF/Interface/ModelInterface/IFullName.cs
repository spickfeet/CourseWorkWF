using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IFullName
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymic { get; set; }
    }
}
