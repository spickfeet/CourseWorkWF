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
        string Name { get;}
        string Surname { get;}
        string? Patronymic { get;}
        string Login { get; }
        string Password { get; }
        JobTitle Post { get; }
    }
}
