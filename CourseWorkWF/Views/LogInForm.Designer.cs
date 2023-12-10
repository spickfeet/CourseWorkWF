namespace Inf_Bez
{
    partial class LogInForm
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
            buttonLogIn = new Button();
            labelError = new Label();
            checkBoxPasswordView = new CheckBox();
            labelTitleLogIn = new Label();
            labelSignUp = new Label();
            labelPassword = new Label();
            labelLogin = new Label();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(125, 190);
            textBoxLogin.Margin = new Padding(3, 2, 3, 2);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(218, 43);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(125, 260);
            textBoxPassword.Margin = new Padding(3, 2, 3, 2);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(218, 43);
            textBoxPassword.TabIndex = 1;
            // 
            // buttonLogIn
            // 
            buttonLogIn.Location = new Point(125, 354);
            buttonLogIn.Margin = new Padding(3, 2, 3, 2);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(218, 48);
            buttonLogIn.TabIndex = 3;
            buttonLogIn.Text = "Войти";
            buttonLogIn.UseVisualStyleBackColor = true;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.BackColor = SystemColors.ScrollBar;
            labelError.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.FromArgb(192, 0, 0);
            labelError.Location = new Point(125, 404);
            labelError.Name = "labelError";
            labelError.Size = new Size(220, 19);
            labelError.TabIndex = 4;
            labelError.Text = "Неправильный логин или пароль";
            // 
            // checkBoxPasswordView
            // 
            checkBoxPasswordView.AutoSize = true;
            checkBoxPasswordView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxPasswordView.Location = new Point(349, 275);
            checkBoxPasswordView.Name = "checkBoxPasswordView";
            checkBoxPasswordView.Size = new Size(15, 14);
            checkBoxPasswordView.TabIndex = 5;
            checkBoxPasswordView.UseVisualStyleBackColor = true;
            checkBoxPasswordView.CheckedChanged += checkBoxPasswordView_CheckedChanged;
            // 
            // labelTitleLogIn
            // 
            labelTitleLogIn.AutoSize = true;
            labelTitleLogIn.Font = new Font("Segoe UI", 21F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitleLogIn.Location = new Point(140, 27);
            labelTitleLogIn.Name = "labelTitleLogIn";
            labelTitleLogIn.Size = new Size(182, 38);
            labelTitleLogIn.TabIndex = 2;
            labelTitleLogIn.Text = "Авторизация";
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.ForeColor = SystemColors.MenuHighlight;
            labelSignUp.Location = new Point(226, 337);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(117, 15);
            labelSignUp.TabIndex = 6;
            labelSignUp.Text = "зарегистрироваться";
            labelSignUp.Click += labelSignUp_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(125, 243);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 15);
            labelPassword.TabIndex = 11;
            labelPassword.Text = "Password";
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(125, 173);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(37, 15);
            labelLogin.TabIndex = 10;
            labelLogin.Text = "Login";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(474, 501);
            Controls.Add(labelPassword);
            Controls.Add(labelLogin);
            Controls.Add(labelSignUp);
            Controls.Add(checkBoxPasswordView);
            Controls.Add(labelError);
            Controls.Add(buttonLogIn);
            Controls.Add(labelTitleLogIn);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogInForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonLogIn;
        private Label labelError;
        private CheckBox checkBoxPasswordView;
        private Label labelTitleLogIn;
        private Label labelSignUp;
        private Label labelPassword;
        private Label labelLogin;
    }
}