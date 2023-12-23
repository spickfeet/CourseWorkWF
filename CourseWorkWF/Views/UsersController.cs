using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF.Views
{
    public partial class UsersController : Form, IUserControllerFormView
    {
        string? IUserControllerFormView.SelectLogin
        {
            get
            {
                if (listViewUsers.SelectedItems.Count == 0)
                {
                    return null;
                }
                return listViewUsers.SelectedItems[0].Text;
            }
        }

        JobTitle IUserControllerFormView.Post
        {
            get
            {
                if (comboBoxJobTitle.Text == "Админ")
                    return JobTitle.Admin;
                if (comboBoxJobTitle.Text == "Кассир")
                    return JobTitle.Cashier;
                throw new ArgumentException("Нет такой должности");
            }
        }
        UserControllerPresenter _presenter;
        public UsersController()
        {
            _presenter = new(this);
            _presenter.SelectUserErrorEvent += SetSelectError;
            Load += FormStarted;
            InitializeComponent();
        }
        private void FormStarted(object? sender, EventArgs e)
        {
            UpdateUsersList();
        }
        private void SetSelectError(object? sender, string error)
        {
            errorProviderUsersList.SetError(listViewUsers, error);
        }

        private void ButtonChangeJobTitle_Click(object sender, EventArgs e)
        {
            errorProviderJobTitle.Clear();
            if (comboBoxJobTitle.SelectedIndex == -1)
            {
                errorProviderJobTitle.SetError(comboBoxJobTitle, "Выберите должность");
                return;
            }
            errorProviderUsersList.Clear();
            _presenter.ChangeJobTitle();
            UpdateUsersList();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            errorProviderUsersList.Clear();
            _presenter.DeleteUser();
            UpdateUsersList();
        }
        private void UpdateUsersList()
        {
            listViewUsers.Items.Clear();
            int lineIndex = 0;
            foreach (IUser user in _presenter.Users.Values)
            {
                listViewUsers.Items.Add(user.Login);
                listViewUsers.Items[lineIndex].SubItems.Add(user.FullName.Name);
                listViewUsers.Items[lineIndex].SubItems.Add(user.FullName.Surname);
                listViewUsers.Items[lineIndex].SubItems.Add(user.FullName.Patronymic);
                listViewUsers.Items[lineIndex].SubItems.Add(user.Post.ToString());
                lineIndex++;
            }
        }
    }
}
