﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface ILogInFormView : IView
    {
        public string Login { get; }
        public string Password { get; }
    }
}
