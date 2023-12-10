using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IUser : IEmployee
    {
        string Login { get; set; }
        string Password { get; set; }
    }
}
