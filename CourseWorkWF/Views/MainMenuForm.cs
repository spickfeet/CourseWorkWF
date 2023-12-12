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
            InitializeComponent();
        }
        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
        }
        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            AssortmentForm assortment = new AssortmentForm(this);
            assortment.ShowDialog();
        }

        private void ButtonSell_Click(object sender, EventArgs e)
        {
            SellForm sellForm = new SellForm(this);
            sellForm.ShowDialog();
        }

        private void buttonRefund_Click(object sender, EventArgs e)
        {

        }

        private void buttonHistoryComingsAndGoings_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangeJobTitle_Click(object sender, EventArgs e)
        {

        }
    }
}