using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
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
        private IUsersDataBase _userData;
        public LogInPresenter(ILogInFormView view) 
        {
            _userData = new UsersDataBase();
            _view = view;
        }

        public IUser? LogIn()
        {
            IList<IUser> users = _userData.Load();

            foreach (var user in users)
            {
                if (user.Login == _view.Login && user.Password == _view.Password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
