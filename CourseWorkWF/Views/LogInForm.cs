using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CourseWorkWF.Views
{
    public partial class LogInForm : Form, ILogInFormView
    {
        private LogInPresenter _presenter;
        private IViewsController _viewsController;
        public LogInForm(IViewsController viewsController, LogInPresenter presenter)
        {
            _presenter = presenter;
            _viewsController = viewsController;
            InitializeComponent();
            labelError.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        string ILogInFormView.Login
        {
            get { return textBoxLogin.Text; }
        }
        string ILogInFormView.Password
        {
            get { return textBoxPassword.Text; }
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            if (_presenter.LogIn() != false)
            {
                labelError.Visible = false;
                _viewsController.CurrentView.Visible = false;
                _viewsController.ShowDialog(ViewKey.MainMenu);
            }
            labelError.Visible = true;

        }

        private void CheckBoxPasswordView_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordView.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void LabelSignUp_Click(object sender, EventArgs e)
        {
            _viewsController.CurrentView.Visible = false;
            _viewsController.ShowDialog(ViewKey.SingUp);
        }
    }
}