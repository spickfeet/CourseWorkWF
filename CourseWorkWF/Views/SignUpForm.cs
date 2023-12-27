using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace CourseWorkWF.Views
{
    public partial class SignUpForm : Form, ISignUpFormView
    {
        private SignUpPresenter _presenter;
        private bool _haveError;
        private ViewsController _viewsController;

        string ISignUpFormView.Login
        {
            get { return textBoxLogin.Text; }
        }
        string ISignUpFormView.Password
        {
            get { return textBoxPassword.Text; }
        }
        JobTitle ISignUpFormView.Post
        {
            get
            {
                if (comboBoxJobTitle.Text == "��������")
                    return JobTitle.Owner;
                if (comboBoxJobTitle.Text == "������")
                    return JobTitle.Cashier;
                throw new ArgumentException("��� ����� ���������");
            }
        }
        string ISignUpFormView.Name
        {
            get { return textBoxName.Text; }
        }
        string ISignUpFormView.Surname
        {
            get { return textBoxSurname.Text; }
        }
        string? ISignUpFormView.Patronymic
        {
            get { return textBoxPatronymic.Text; }
        }

        public SignUpForm(ViewsController viewsController, SignUpPresenter presenter)
        {
            _viewsController = viewsController;
            _presenter = presenter;
            _presenter.LoginTakenErrorEvent += OnLoginTaken;
            _presenter.OnlyOneOwnerErrorEvent += OnOnlyOneOwner;           
            InitializeComponent();
            FormClosed += OnClosed;
            textBoxPassword.UseSystemPasswordChar = true;
        }
        private void OnClosed(object? sender, EventArgs e)
        {
            textBoxLogin.Clear();
            textBoxName.Clear();
            textBoxPassword.Clear();
            textBoxPatronymic.Clear();
            textBoxSurname.Clear();
            comboBoxJobTitle.SelectedIndex = -1;
            _viewsController.PrevView.Visible = true;
        }
        private void OnOnlyOneOwner()
        {
            errorProviderJobTitle.SetError(comboBoxJobTitle, "�������� ����� ���� ������ 1");
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void OnLoginTaken()
        {
            errorProviderLogin.SetError(textBoxLogin, "����� �����");
        }


        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            errorProviderLogin.Clear();
            errorProviderJobTitle.Clear();
            errorProviderName.Clear();
            errorProviderPassword.Clear();
            errorProviderPatronymic.Clear();
            errorProviderSurname.Clear();
            _haveError = false;
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                errorProviderLogin.SetError(textBoxLogin, "����� �� ����� ���� ������");
                _haveError = true;
            } // ������ �����
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                errorProviderPassword.SetError(textBoxPassword, "������ �� ����� ���� ������");
                _haveError = true;
            } // ������ ������
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                errorProviderName.SetError(textBoxName, "��� �� ����� ���� ������");
                _haveError = true;
            } // ������ ���
            if (string.IsNullOrEmpty(textBoxSurname.Text))
            {
                errorProviderSurname.SetError(textBoxSurname, "������� �� ����� ���� ������");
                _haveError = true;
            } // ������ �������
            if (comboBoxJobTitle.SelectedIndex == -1)
            {
                errorProviderJobTitle.SetError(comboBoxJobTitle, "�������� ���������");
                _haveError = true;
            } // �� ������� ���������
            if (_haveError == false)
            {
                if (_presenter.SignUp())
                {
                    _viewsController.PrevView.Visible = true;
                    Close();
                }

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
    }
}