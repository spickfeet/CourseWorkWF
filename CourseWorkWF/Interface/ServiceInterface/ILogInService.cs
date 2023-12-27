using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface
{
    public interface ILogInService
    {
        public bool LogIn(string login, string password);
    }
}
