using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models.Services
{
    public class LoginService : ILogInService
    {
        IDataManager _dataManager;
        public LoginService(IDataManager dataManager) 
        {
            _dataManager = dataManager;
        }
        public bool LogIn(string login, string password)
        {
            foreach (var user in _dataManager.UserRepository.ReadAll())
            {
                if (user.Key == login && user.Value.Password == HashCodeConvertor.ConvertToHashCode(password + user.Value.Salt))
                {
                    _dataManager.CurrentUser = user.Value;
                    return true;
                }
            }
            return false;
        }
    }
}
