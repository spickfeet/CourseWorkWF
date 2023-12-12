using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Presenters;

namespace CourseWorkWF.Views
{
    public partial class MainMenuForm : Form, IMainMenuFormView
    {
        private Form _prevForm;
        private MainMenuPresenter _presenter;
        public MainMenuForm(Form prev, MainMenuPresenter mainMenuPresenter)
        {
            _presenter = mainMenuPresenter;
            
            _prevForm = prev;
            _prevForm.Hide();
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
            buttonHistoryComingsAndGoings.Visible = true;
            buttonChangeJobTitle.Visible = true;
            buttonRemoveEmployee.Visible = true;
        }

        private void ApplyOpportunitiesAdmin(object? sender, EventArgs e)
        {
            buttonSell.Visible = true;
            buttonRefund.Visible = true;
            buttonAssortment.Visible = true;
            buttonHistoryComingsAndGoings.Visible = true;
        }

        private void ApplyOpportunitiesCashier(object? sender, EventArgs e)
        {
            buttonSell.Visible = true;
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            AssortmentForm assortment = new AssortmentForm(this);
            assortment.ShowDialog();
        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            SellForm sellForm = new SellForm(this,_presenter.GetUser());
            sellForm.ShowDialog();
        }

        private void ButtonRefund_Click(object sender, EventArgs e)
        {

        }

        private void ButtonHistoryComingsAndGoings_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRemoveEmployee_Click(object sender, EventArgs e)
        {

        }

        private void ButtonChangeJobTitle_Click(object sender, EventArgs e)
        {

        }
    }
}