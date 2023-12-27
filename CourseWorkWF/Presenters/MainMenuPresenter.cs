using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Models.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class MainMenuPresenter
    {
        private IDataManager _dataManager;
        private IMainMenuService _model;
        public event EventHandler? OwnerUserEnter;
        public event EventHandler? AdminUserEnter;
        public event EventHandler? CashierUserEnter;
        public MainMenuPresenter(IDataManager dataManager)
        {
            _dataManager = dataManager;
            _model = new MainMenuService(dataManager);
        }
        public void GiveOpportunities()
        {
            if (_dataManager.CurrentUser == null) throw new ArgumentException("Пользователь не может быть null");
            switch (_dataManager.CurrentUser.Post)
            {
                case (JobTitle.Owner):
                    OwnerUserEnter?.Invoke(this, EventArgs.Empty);
                    break;
                case (JobTitle.Admin):
                    AdminUserEnter?.Invoke(this, EventArgs.Empty);
                    break;
                case (JobTitle.Cashier):
                    return;
                default:
                    return;
            }
        }
        public void CloseShift()
        {
            _model.CloseShift();
        }
        public bool TryOpenHistory()
        {
            return _model.TryOpenHistory();
        }
        public bool TryOpenRefund()
        {
            return _model.TryOpenRefund();
        }
        public bool TryOpenAssortment()
        {
            return _model.TryOpenAssortment();
        }
        public bool TryOpenUserController()
        {
            return _model.TryOpenUserController();
        }
    }
}
