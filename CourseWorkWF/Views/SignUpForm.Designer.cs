namespace Inf_Bez
{
    partial class SignUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonSignUp = new Button();
            checkBoxPasswordView = new CheckBox();
            labelTitleSignUp = new Label();
            labelLogin = new Label();
            labelPassword = new Label();
            labelJobTitle = new Label();
            comboBoxJobTitle = new ComboBox();
            labelName = new Label();
            textBoxName = new TextBox();
            labelSurname = new Label();
            textBoxSurname = new TextBox();
            labelPatronymic = new Label();
            textBoxPatronymic = new TextBox();
            errorProviderLogin = new ErrorProvider(components);
            errorProviderPassword = new ErrorProvider(components);
            errorProviderName = new ErrorProvider(components);
            errorProviderSurname = new ErrorProvider(components);
            errorProviderJobTitle = new ErrorProvider(components);
            errorProviderPatronymic = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderJobTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPatronymic).BeginInit();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(227, 88);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(218, 25);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.KeyPress += TextBox_KeyPress;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(227, 137);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(218, 25);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.KeyPress += TextBox_KeyPress;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(121, 232);
            buttonSignUp.Margin = new Padding(3, 2, 3, 2);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(218, 48);
            buttonSignUp.TabIndex = 3;
            buttonSignUp.Text = "Зарегистрировать";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += ButtonSignUp_Click;
            // 
            // checkBoxPasswordView
            // 
            checkBoxPasswordView.AutoSize = true;
            checkBoxPasswordView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPasswordView.Location = new Point(451, 148);
            checkBoxPasswordView.Name = "checkBoxPasswordView";
            checkBoxPasswordView.Size = new Size(15, 14);
            checkBoxPasswordView.TabIndex = 5;
            checkBoxPasswordView.UseVisualStyleBackColor = true;
            checkBoxPasswordView.CheckedChanged += CheckBoxPasswordView_CheckedChanged;
            // 
            // labelTitleSignUp
            // 
            labelTitleSignUp.AutoSize = true;
            labelTitleSignUp.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleSignUp.Location = new Point(150, 9);
            labelTitleSignUp.Name = "labelTitleSignUp";
            labelTitleSignUp.Size = new Size(176, 38);
            labelTitleSignUp.TabIndex = 2;
            labelTitleSignUp.Text = "Регистрация";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(227, 71);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(41, 15);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Логин";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(227, 120);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(49, 15);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Пароль";
            // 
            // labelJobTitle
            // 
            labelJobTitle.AutoSize = true;
            labelJobTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelJobTitle.Location = new Point(227, 169);
            labelJobTitle.Name = "labelJobTitle";
            labelJobTitle.Size = new Size(69, 15);
            labelJobTitle.TabIndex = 9;
            labelJobTitle.Text = "Должность";
            // 
            // comboBoxJobTitle
            // 
            comboBoxJobTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJobTitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxJobTitle.FormattingEnabled = true;
            comboBoxJobTitle.Items.AddRange(new object[] { "Владелец", "Кассир" });
            comboBoxJobTitle.Location = new Point(227, 187);
            comboBoxJobTitle.Name = "comboBoxJobTitle";
            comboBoxJobTitle.Size = new Size(218, 25);
            comboBoxJobTitle.TabIndex = 10;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(12, 71);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 15);
            labelName.TabIndex = 12;
            labelName.Text = "Имя";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(12, 88);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(166, 25);
            textBoxName.TabIndex = 11;
            textBoxName.KeyPress += TextBox_KeyPress;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSurname.Location = new Point(12, 120);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(58, 15);
            labelSurname.TabIndex = 14;
            labelSurname.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.Location = new Point(12, 137);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(166, 25);
            textBoxSurname.TabIndex = 13;
            textBoxSurname.KeyPress += TextBox_KeyPress;
            // 
            // labelPatronymic
            // 
            labelPatronymic.AutoSize = true;
            labelPatronymic.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPatronymic.Location = new Point(12, 170);
            labelPatronymic.Name = "labelPatronymic";
            labelPatronymic.Size = new Size(58, 15);
            labelPatronymic.TabIndex = 16;
            labelPatronymic.Text = "Отчество";
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatronymic.Location = new Point(12, 187);
            textBoxPatronymic.Margin = new Padding(3, 2, 3, 2);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(166, 25);
            textBoxPatronymic.TabIndex = 15;
            textBoxPatronymic.KeyPress += TextBox_KeyPress;
            // 
            // errorProviderLogin
            // 
            errorProviderLogin.ContainerControl = this;
            errorProviderLogin.RightToLeft = true;
            // 
            // errorProviderPassword
            // 
            errorProviderPassword.ContainerControl = this;
            errorProviderPassword.RightToLeft = true;
            // 
            // errorProviderName
            // 
            errorProviderName.ContainerControl = this;
            // 
            // errorProviderSurname
            // 
            errorProviderSurname.ContainerControl = this;
            // 
            // errorProviderJobTitle
            // 
            errorProviderJobTitle.ContainerControl = this;
            errorProviderJobTitle.RightToLeft = true;
            // 
            // errorProviderPatronymic
            // 
            errorProviderPatronymic.ContainerControl = this;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(474, 319);
            Controls.Add(labelPatronymic);
            Controls.Add(textBoxPatronymic);
            Controls.Add(labelSurname);
            Controls.Add(textBoxSurname);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxJobTitle);
            Controls.Add(labelJobTitle);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(checkBoxPasswordView);
            Controls.Add(buttonSignUp);
            Controls.Add(labelTitleSignUp);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SignUpForm";
            Text = "MyARM";
            ((System.ComponentModel.ISupportInitialize)errorProviderLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderJobTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPatronymic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonSignUp;
        private CheckBox checkBoxPasswordView;
        private Label labelTitleSignUp;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelJobTitle;
        private ComboBox comboBoxJobTitle;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelSurname;
        private TextBox textBoxSurname;
        private Label labelPatronymic;
        private TextBox textBoxPatronymic;
        private ErrorProvider errorProviderLogin;
        private ErrorProvider errorProviderPassword;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderSurname;
        private ErrorProvider errorProviderJobTitle;
        private ErrorProvider errorProviderPatronymic;
    }
}