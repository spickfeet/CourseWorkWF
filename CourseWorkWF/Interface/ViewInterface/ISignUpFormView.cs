using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface ISignUpFormView
    {
        public string Name { get;}
        public string Surname { get;}
        public string? Patronymic { get;}
        public string Login { get; }
        public string Password { get; }
        public JobTitle Post { get; }
    }
}
