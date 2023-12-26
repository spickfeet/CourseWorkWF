using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Presenters
{
    public class MainMenuPresenter
    {
        private readonly IUser _user;
        private IRevenue _revenue;
        private IRepository<DateTime, IRevenue> _revenueData;
        public IRevenue Revenue { get { return _revenue; } }
        public IUser User { get { return _user; } }

        public event EventHandler? OwnerUserEvent;
        public event EventHandler? AdminUserEvent;
        public event EventHandler? CashierUserEvent;
        public MainMenuPresenter(IUser user)
        {
            _user = user;
            _revenueData = new RevenueRepository("Revenues.json");
            _revenue = new Revenue(0, DateTime.Now);
        }
        public void GiveOpportunities()
        {
            if (_user == null) throw new ArgumentException("Пользователь не может быть null");
            switch (_user.Post)
            {
                case (JobTitle.Owner):
                    OwnerUserEvent?.Invoke(this, EventArgs.Empty);
                    break;
                case (JobTitle.Admin):
                    AdminUserEvent?.Invoke(this, EventArgs.Empty);
                    break;
                case (JobTitle.Cashier):
                    CashierUserEvent?.Invoke(this, EventArgs.Empty);
                    break;
                default:
                    CashierUserEvent?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }
        public void CloseShift()
        {
            _revenueData.Create(_revenue);
        }
    }
}
