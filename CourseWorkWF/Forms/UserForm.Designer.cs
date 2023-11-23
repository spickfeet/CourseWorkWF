namespace CourseWorkWF
{
    partial class UserForm
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
            ButtonAdmin = new Button();
            ButtonCashier = new Button();
            SuspendLayout();
            // 
            // ButtonAdmin
            // 
            ButtonAdmin.Location = new Point(416, 128);
            ButtonAdmin.Margin = new Padding(3, 2, 3, 2);
            ButtonAdmin.Name = "ButtonAdmin";
            ButtonAdmin.Size = new Size(148, 96);
            ButtonAdmin.TabIndex = 0;
            ButtonAdmin.Text = "Админ";
            ButtonAdmin.UseVisualStyleBackColor = true;
            ButtonAdmin.Click += ButtonAdmin_Click;
            // 
            // ButtonCashier
            // 
            ButtonCashier.Location = new Point(210, 132);
            ButtonCashier.Name = "ButtonCashier";
            ButtonCashier.Size = new Size(137, 92);
            ButtonCashier.TabIndex = 1;
            ButtonCashier.Text = "Кассир";
            ButtonCashier.UseVisualStyleBackColor = true;
            ButtonCashier.Click += ButtonCashier_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(ButtonCashier);
            Controls.Add(ButtonAdmin);
            Margin = new Padding(3, 2, 3, 2);
            Name = "User";
            Text = "User";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonAdmin;
        private Button ButtonCashier;
    }
}