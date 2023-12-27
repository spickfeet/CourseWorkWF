using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Presenters
{
    public class LogInPresenter
    {
        public ILogInFormView View { get; set; }
        private ILogInService _model;
        public LogInPresenter(IDataManager dataManager) 
        {
            _model = new LoginService(dataManager);
        }
        public bool LogIn()
        {
            return _model.LogIn(View.Login, View.Password);
        }
    }
}
