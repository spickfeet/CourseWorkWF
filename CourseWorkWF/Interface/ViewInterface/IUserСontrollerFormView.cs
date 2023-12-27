using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface IUserControllerFormView : IView
    {
        string? SelectLogin { get; }
        JobTitle Post { get; }
    }
}
