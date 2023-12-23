namespace CourseWorkWF.Views
{
    partial class UsersController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listViewUsers = new ListView();
            columnHeaderLogin = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderSurname = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            columnHeaderJobTitle = new ColumnHeader();
            buttonChangeJobTitle = new Button();
            buttonDelete = new Button();
            comboBoxJobTitle = new ComboBox();
            errorProviderJobTitle = new ErrorProvider(components);
            errorProviderUsersList = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderJobTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsersList).BeginInit();
            SuspendLayout();
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { columnHeaderLogin, columnHeaderName, columnHeaderSurname, columnHeaderPatronymic, columnHeaderJobTitle });
            listViewUsers.Location = new Point(12, 26);
            listViewUsers.MultiSelect = false;
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(761, 207);
            listViewUsers.TabIndex = 0;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            // 
            // columnHeaderLogin
            // 
            columnHeaderLogin.Text = "Логин";
            columnHeaderLogin.Width = 150;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Имя";
            columnHeaderName.Width = 150;
            // 
            // columnHeaderSurname
            // 
            columnHeaderSurname.Text = "Фамилия";
            columnHeaderSurname.Width = 150;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.Width = 150;
            // 
            // columnHeaderJobTitle
            // 
            columnHeaderJobTitle.Text = "Должность";
            columnHeaderJobTitle.Width = 150;
            // 
            // buttonChangeJobTitle
            // 
            buttonChangeJobTitle.BackColor = Color.Turquoise;
            buttonChangeJobTitle.Location = new Point(12, 268);
            buttonChangeJobTitle.Name = "buttonChangeJobTitle";
            buttonChangeJobTitle.Size = new Size(170, 51);
            buttonChangeJobTitle.TabIndex = 1;
            buttonChangeJobTitle.Text = "Изменить должность";
            buttonChangeJobTitle.UseVisualStyleBackColor = false;
            buttonChangeJobTitle.Click += ButtonChangeJobTitle_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Location = new Point(603, 239);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(170, 51);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // comboBoxJobTitle
            // 
            comboBoxJobTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJobTitle.FormattingEnabled = true;
            comboBoxJobTitle.Items.AddRange(new object[] { "Админ", "Кассир" });
            comboBoxJobTitle.Location = new Point(12, 239);
            comboBoxJobTitle.Name = "comboBoxJobTitle";
            comboBoxJobTitle.Size = new Size(170, 23);
            comboBoxJobTitle.TabIndex = 3;
            // 
            // errorProviderJobTitle
            // 
            errorProviderJobTitle.ContainerControl = this;
            // 
            // errorProviderUsersList
            // 
            errorProviderUsersList.ContainerControl = this;
            // 
            // UsersManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 332);
            Controls.Add(comboBoxJobTitle);
            Controls.Add(buttonDelete);
            Controls.Add(buttonChangeJobTitle);
            Controls.Add(listViewUsers);
            Name = "UsersManager";
            Text = "UsersManager";
            ((System.ComponentModel.ISupportInitialize)errorProviderJobTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsersList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewUsers;
        private ColumnHeader columnHeaderLogin;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderSurname;
        private ColumnHeader columnHeaderPatronymic;
        private ColumnHeader columnHeaderJobTitle;
        private Button buttonChangeJobTitle;
        private Button buttonDelete;
        private ComboBox comboBoxJobTitle;
        private ErrorProvider errorProviderJobTitle;
        private ErrorProvider errorProviderUsersList;
    }
}