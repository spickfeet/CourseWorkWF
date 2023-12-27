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
    internal class SignUpService : ISignUpService
    {
        private IDataManager _dataManager;
        public SignUpService(IDataManager dataManager) 
        {
            _dataManager = dataManager;
        }
        public bool SignUp(string login, string password, JobTitle post, IFullName fullName)
        {
            foreach (var user in _dataManager.UserRepository.ReadAll())
            {
                if (user.Key == login)
                {
                    return false;
                }
                if (post == JobTitle.Owner)
                {
                    if (user.Value.Post == post)
                    {
                        throw new ArgumentException("Владелец может быть только один");
                    }
                }
            }
            string salt = Guid.NewGuid().ToString();
            _dataManager.UserRepository.Create(new User(login, HashCodeConvertor.ConvertToHashCode(password + salt), fullName, post, salt));
            return true;
        }
    }
}
