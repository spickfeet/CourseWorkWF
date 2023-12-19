using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Inf_Bez
{
    public partial class LogInForm : Form, ILogInFormView
    {
        private LogInPresenter _presenter;
        public LogInForm()
        {
            _presenter = new(this);
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
            if (_presenter.LogIn() != null)
            {
                labelError.Visible = false;
                MainMenuForm mainMenu = new MainMenuForm(this, new MainMenuPresenter(_presenter.LogIn()));
                mainMenu.ShowDialog();
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
            SignUpForm signUpForm = new(this);
            signUpForm.ShowDialog();
        }
    }
}