using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models.Managers;
using CourseWorkWF.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class UserControllerPresenter
    {
        private IDataManager _dataManager;
        private IUserControllerService _model;
        public IReadOnlyDictionary<string, IUser> Users { get { return _dataManager.UserRepository.ReadAll(); } }
        public IUserControllerFormView View { get; set; }
        public event Action<string>? SelectUserError;
        public UserControllerPresenter(IDataManager dataManager) 
        {
            _dataManager = dataManager;
            _model = new UserControllerService(dataManager);
        }
        public void DeleteUser()
        {
            try
            {
                _model.DeleteUser(View.SelectLogin);
            }
            catch (Exception ex) 
            {
                SelectUserError?.Invoke(ex.Message);
            }
        }
        public void ChangeJobTitle()
        {
            try
            {
                _model.ChangeJobTitle(View.SelectLogin, View.Post);
            }
            catch (Exception ex)
            {
                SelectUserError?.Invoke(ex.Message);
            }
        }
    }
}
