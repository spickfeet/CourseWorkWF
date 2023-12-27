using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Models.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class SignUpPresenter
    {
        private ISignUpService _model;
        public ISignUpFormView View { get; set; }
        public event Action? LoginTakenErrorEvent;
        public event Action? OnlyOneOwnerErrorEvent;
        public SignUpPresenter(IDataManager dataManager) 
        { 
            _model = new SignUpService(dataManager);
        }
        public bool SignUp()
        {
            try
            {
                if(_model.SignUp(View.Login, View.Password, View.Post, new FullName(View.Name, View.Surname, View.Patronymic)) == true)
                {
                    return true;
                }
                LoginTakenErrorEvent?.Invoke();
                return false;
            }
            catch (ArgumentException)
            {
                OnlyOneOwnerErrorEvent?.Invoke();
                return false;
            }
        }
    }
}
