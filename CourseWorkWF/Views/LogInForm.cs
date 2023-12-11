using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Inf_Bez
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            labelError.Visible = false;
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
        //    labelError.Visible = false;
        //    var users = File.Exists("Users.json")
        //        ? JsonConvert.DeserializeObject<List<User>>(File.ReadAllText("Users.json"))
        //        : throw new Exception("Users.json не найден");

        //    if (users == null)
        //    {
        //        labelError.Visible = true;
        //        return;
        //    }

        //    foreach (var user in users)
        //    {
        //        if (user.Login == textBoxLogin.Text && user.Password == User.ConvertToHashCode(textBoxPassword.Text))
        //        {
        //            FileForm fileForm = new FileForm(this, user);
        //            fileForm.ShowDialog();
        //            return;
        //        }
        //    }
        //    labelError.Visible = true;
        }

        private void checkBoxPasswordView_CheckedChanged(object sender, EventArgs e)
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
            SignUpForm signUpForm = new SignUpForm(null);
            signUpForm.ShowDialog();
        }
    }
}