using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models.Services
{
    public class UserControllerService : IUserControllerService
    {
        private IDataManager _dataManager;
        public UserControllerService(IDataManager dataManager) 
        {
            _dataManager = dataManager;
        }
        public void DeleteUser(string? login)
        {
            if (login == null)
            {
                throw new ArgumentException("Не выбран пользователь");
            }
            _dataManager.UserRepository.Delete(_dataManager.UserRepository.ReadAll()[login]);
        }
        public void ChangeJobTitle(string? login, JobTitle jobTitle)
        {
            if (login == null)
            {
                throw new ArgumentException("Не выбран пользователь");
            }
            if (_dataManager.UserRepository.ReadAll().ContainsKey(login))
            {
                _dataManager.UserRepository.ReadAll()[login].Post = jobTitle;
            }
            throw new ArgumentException("Не выбран пользователь");
        }
    }
}
