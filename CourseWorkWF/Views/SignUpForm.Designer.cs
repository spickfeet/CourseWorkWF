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
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonSignUp = new Button();
            labelError = new Label();
            checkBoxPasswordView = new CheckBox();
            labelTitleSignUp = new Label();
            textBoxId = new TextBox();
            labelLogin = new Label();
            labelPassword = new Label();
            labelId = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(125, 138);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(218, 43);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(125, 208);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(218, 43);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(125, 354);
            buttonSignUp.Margin = new Padding(3, 2, 3, 2);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(218, 48);
            buttonSignUp.TabIndex = 3;
            buttonSignUp.Text = "Зарегистрировать";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = SystemColors.Control;
            labelError.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.FromArgb(192, 0, 0);
            labelError.Location = new Point(125, 404);
            labelError.Name = "labelError";
            labelError.Size = new Size(207, 15);
            labelError.TabIndex = 4;
            labelError.Text = "Такой пользователь уже существует";
            // 
            // checkBoxPasswordView
            // 
            checkBoxPasswordView.AutoSize = true;
            checkBoxPasswordView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPasswordView.Location = new Point(349, 223);
            checkBoxPasswordView.Name = "checkBoxPasswordView";
            checkBoxPasswordView.Size = new Size(15, 14);
            checkBoxPasswordView.TabIndex = 5;
            checkBoxPasswordView.UseVisualStyleBackColor = true;
            checkBoxPasswordView.CheckedChanged += checkBoxPasswordView_CheckedChanged;
            // 
            // labelTitleSignUp
            // 
            labelTitleSignUp.AutoSize = true;
            labelTitleSignUp.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleSignUp.Location = new Point(140, 27);
            labelTitleSignUp.Name = "labelTitleSignUp";
            labelTitleSignUp.Size = new Size(176, 38);
            labelTitleSignUp.TabIndex = 2;
            labelTitleSignUp.Text = "Регистрация";
            // 
            // textBoxId
            // 
            textBoxId.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.Location = new Point(125, 278);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(218, 43);
            textBoxId.TabIndex = 6;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(125, 121);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(37, 15);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Login";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(125, 191);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Password";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(125, 261);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 9;
            labelId.Text = "Id";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 501);
            Controls.Add(labelId);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(textBoxId);
            Controls.Add(checkBoxPasswordView);
            Controls.Add(labelError);
            Controls.Add(buttonSignUp);
            Controls.Add(labelTitleSignUp);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonSignUp;
        private Label labelError;
        private CheckBox checkBoxPasswordView;
        private Label labelTitleSignUp;
        private TextBox textBoxId;
        private Label labelLogin;
        private Label labelPassword;
        private Label labelId;
    }
}