using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Inf_Bez
{
    public partial class LogInForm : Form , ILogInFormView
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

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            if(_presenter.LogIn() == true)
            {
                UserForm usermenu = new UserForm(this);
                usermenu.ShowDialog();
            }
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

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm(this);
            signUpForm.ShowDialog();
        }
    }
}