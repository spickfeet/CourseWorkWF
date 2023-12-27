using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;
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
    public partial class UsersControllerForm : Form, IUserControllerFormView
    {
        private UserControllerPresenter _presenter;
        private ViewsController _viewsController;
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
        public UsersControllerForm(ViewsController viewsController, UserControllerPresenter presenter)
        {
            _presenter = presenter;
            _viewsController = viewsController;
            _presenter.SelectUserError += OnSelectUserError;
            Load += FormStarted;
            InitializeComponent();
            FormClosed += OnClosed;
        }
        private void OnClosed(object sender, EventArgs e)
        {
            _viewsController.Closed();
            _viewsController.PrevView.Visible = true;
        }
        private void FormStarted(object? sender, EventArgs e)
        {
            UpdateUsersList();
        }
        private void OnSelectUserError(string error)
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
