using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;

namespace CourseWorkWF.Views
{
    public partial class MainMenuForm : Form, IView
    {
        private MainMenuPresenter _presenter;
        private ViewsController _viewsController;
        public MainMenuForm(ViewsController viewsController, MainMenuPresenter mainMenuPresenter)
        {
            _presenter = mainMenuPresenter;
            _viewsController = viewsController;
            FormClosed += OnClosed;
            Load += FormStarted;
            InitializeComponent();
            _presenter.CashierUserEvent += ApplyOpportunitiesCashier;
            _presenter.AdminUserEvent += ApplyOpportunitiesAdmin;
            _presenter.OwnerUserEvent += ApplyOpportunitiesOwner;
        }

        private void FormStarted(object? sender, EventArgs e)
        {
            _presenter.GiveOpportunities();
        }

        private void ApplyOpportunitiesOwner(object? sender, EventArgs e)
        {
            buttonSell.Visible = true;
            buttonRefund.Visible = true;
            buttonAssortment.Visible = true;
            buttonHistory.Visible = true;
            buttonUserController.Visible = true;
        }

        private void ApplyOpportunitiesAdmin(object? sender, EventArgs e)
        {
            buttonSell.Visible = true;
            buttonRefund.Visible = true;
            buttonAssortment.Visible = true;
            buttonHistory.Visible = true;
        }

        private void ApplyOpportunitiesCashier(object? sender, EventArgs e)
        {
            buttonSell.Visible = true;
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _presenter.CloseShift();
            Application.Exit();
        }
        private void ButtonAssortment_Click(object sender, EventArgs e)
        {
            _viewsController.ShowDialog(ViewKey.Assortment);
        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            _viewsController.ShowDialog(ViewKey.Sell);
        }

        private void ButtonRefund_Click(object sender, EventArgs e)
        {
            _viewsController.ShowDialog(ViewKey.Refund);
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            _viewsController.ShowDialog(ViewKey.History);
        }

        private void ButtonRemoveEmployee_Click(object sender, EventArgs e)
        {
            _viewsController.ShowDialog(ViewKey.UserController);
        }

        private void ButtonRevenue_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}