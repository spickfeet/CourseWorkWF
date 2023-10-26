namespace CourseWorkWF
{
    partial class User
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
            Admin = new Button();
            SuspendLayout();
            // 
            // Admin
            // 
            Admin.Location = new Point(476, 171);
            Admin.Name = "Admin";
            Admin.Size = new Size(94, 29);
            Admin.TabIndex = 0;
            Admin.Text = "Админ";
            Admin.UseVisualStyleBackColor = true;
            Admin.Click += Admin_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Admin);
            Name = "User";
            Text = "User";
            ResumeLayout(false);
        }

        #endregion

        private Button Admin;
    }
}