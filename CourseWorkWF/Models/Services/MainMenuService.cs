using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Models.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models.Services
{
    public class MainMenuService : IMainMenuService
    {
        private IDataManager _dataManager;
        public MainMenuService(IDataManager dataManager) 
        {
            _dataManager = dataManager;
        }
        public bool TryOpenHistory() 
        { 
            if (_dataManager.CurrentUser.Post == JobTitle.Cashier)
                return false; 
            return true;
        }
        public bool TryOpenAssortment()
        {
            if (_dataManager.CurrentUser.Post == JobTitle.Cashier)
                return false;
            return true;
        }
        public bool TryOpenRefund()
        {
            if (_dataManager.CurrentUser.Post == JobTitle.Cashier)
                return false;
            return true;
        }
        public bool TryOpenUserController()
        {
            if (_dataManager.CurrentUser.Post == JobTitle.Cashier || _dataManager.CurrentUser.Post == JobTitle.Admin)
                return false;
            return true;
        }
        public void CloseShift()
        {
            _dataManager.RevenueRepository.Create(_dataManager.CurrentRevenue);
        }

    }
}
