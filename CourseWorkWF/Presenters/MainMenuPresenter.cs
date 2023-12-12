using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
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
        private IUser _user;

        public event EventHandler? OwnerUserEvent;
        public event EventHandler? AdminUserEvent;
        public event EventHandler? CashierUserEvent;
        public MainMenuPresenter(IUser user)
        {
            _user = user;
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
    }
}
