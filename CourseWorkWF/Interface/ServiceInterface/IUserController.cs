using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface
{
    public interface IUserControllerService
    {
        public void DeleteUser(string? login);
        public void ChangeJobTitle(string? login, JobTitle jobTitle);
    }
}
