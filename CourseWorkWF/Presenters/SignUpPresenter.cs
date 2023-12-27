using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
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
        private IRepository<string, IUser> _userData;
        private ISignUpFormView _view;
        public ISignUpFormView View { get { return _view; } set { _view = value; } }
        public event EventHandler? LoginBusyErrorEvent;
        public event EventHandler? OnlyOneOwnerErrorEvent;
        public SignUpPresenter(IDataManager dataManager) 
        { 
            _userData = new UsersRepository("Users.json");
        }
        public bool SignUp()
        {
            IDictionary<string, IUser> users = _userData.Load();

            foreach(var item in users) 
            { 
                if(item.Key == _view.Login)
                {

                    LoginBusyErrorEvent?.Invoke(this,EventArgs.Empty); 
                    return false;
                }
                if (_view.Post == JobTitle.Owner)
                {
                    if(item.Value.Post == _view.Post)
                    {
                        OnlyOneOwnerErrorEvent?.Invoke(this, EventArgs.Empty);
                        return false;
                    }
                }
            }
            string salt = Guid.NewGuid().ToString();
            IUser user = new User(_view.Login, HashCodeConvertor.ConvertToHashCode(_view.Password + salt), new FullName(_view.Name, _view.Surname, _view.Patronymic), _view.Post, salt);
            _userData.Create(user);
            return true;
        }
    }
}
