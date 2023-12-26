using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
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
        private ILogInFormView _view;
        private IRepository<string, IUser> _userData;
        public LogInPresenter(ILogInFormView view) 
        {
            _userData = new UsersRepository("Users.json");
            _view = view;
        }

        public IUser? LogIn()
        {
            IDictionary<string, IUser> users = _userData.Load();

            foreach (var user in users)
            {
                if (user.Key == _view.Login && user.Value.Password == HashCodeConvertor.ConvertToHashCode(_view.Password + user.Value.Salt))
                {
                    return user.Value;
                }
            }
            return null;
        }
    }
}
