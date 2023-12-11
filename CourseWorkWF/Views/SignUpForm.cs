using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Presenters;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;

namespace Inf_Bez
{
    public partial class SignUpForm : Form, ISignUpFormView
    {
        private SignUpPresenter _presenter;
        private Form _prevForm;
        private bool _haveError;

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
                if (comboBoxJobTitle.Text == "�����")
                    return JobTitle.Admin;
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

        public SignUpForm(Form prev)
        {
            _presenter = new(this);
            _prevForm = prev;
            _prevForm.Hide();
            FormClosed += OnClosed;
            _presenter.LoginBusyErrorEvent += LoginBusy;
            _presenter.OnlyOneOwnerErrorEvent += OnlyOneOwner;
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void OnlyOneOwner(object? sender, EventArgs e)
        {
            errorProviderJobTitle.SetError(comboBoxJobTitle, "�������� ����� ���� ������ 1");
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void LoginBusy(object? sender, EventArgs e)
        {
            errorProviderLogin.SetError(textBoxLogin, "����� �����");
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
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
                    Close();
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