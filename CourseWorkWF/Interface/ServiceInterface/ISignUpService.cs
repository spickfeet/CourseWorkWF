using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface
{
    public interface ISignUpService
    {
        public bool SignUp(string login, string password, JobTitle post, IFullName fullName);
    }
}
