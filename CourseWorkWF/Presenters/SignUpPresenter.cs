using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesIterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Enums;
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
        private IUserDataBase _userDataBase;
        private ISignUpFormView _view;
        public event EventHandler? LoginBusyErrorEvent;
        public event EventHandler? OnlyOneOwnerErrorEvent;
        public SignUpPresenter(ISignUpFormView view ) 
        { 
            _view = view;
            _userDataBase = new UserDataBase();
        }
        public void SignUp()
            {
                IList<IUser> users = _userDataBase.Load();

                foreach(var item in users) 
                { 
                    if(item.Login == _view.Login)
                    {
                        LoginBusyErrorEvent?.Invoke(this,EventArgs.Empty); 
                        return;
                    }
                    if (_view.Post == JobTitle.Owner)
                    {
                        if(item.Post == _view.Post)
                        {
                            OnlyOneOwnerErrorEvent?.Invoke(this, EventArgs.Empty);
                            return;
                        }
                    }
                }
            IUser user = new User(_view.Login, _view.Password, new FullName(_view.Name, _view.Surname, _view.Patronymic), _view.Post);
            _userDataBase.Add(user);
        }
    }
}
