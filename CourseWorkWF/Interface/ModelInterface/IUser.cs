using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IUser : IEmployee
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
