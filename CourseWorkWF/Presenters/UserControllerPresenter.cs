using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class UserControllerPresenter
    {
        private IUserControllerFormView _view;
        private IRepository<string, IUser> _usersData;
        public IUserControllerFormView View { get { return _view; } set { _view = value; } }
        public IDictionary<string, IUser> Users { get; private set; }
        public UserControllerPresenter(IDataManager dataManager) 
        {
            _usersData = new UsersRepository("Users.json");
            Users = _usersData.Load();
        }
        public event EventHandler<string> SelectUserErrorEvent;
        public void DeleteUser() 
        {
            if(_view.SelectLogin == null)
            {
                SelectUserErrorEvent.Invoke(this, "Выберите пользователя из списка");
                return;
            }
            _usersData.Delete(Users[_view.SelectLogin]);
            Users = _usersData.Load();
        }
        public void ChangeJobTitle()
        {
            IDictionary<string, IUser> users = new Dictionary<string, IUser>();
            if (_view.SelectLogin == null)
            {
                SelectUserErrorEvent.Invoke(this, "Выберите пользователя из списка");
                return;
            } 
            users = _usersData.Load();
            users[_view.SelectLogin].Post = _view.Post;
            _usersData.Delete(Users[_view.SelectLogin]);
            _usersData.Create(users[_view.SelectLogin]);
            Users = users;
        }
    }
}
