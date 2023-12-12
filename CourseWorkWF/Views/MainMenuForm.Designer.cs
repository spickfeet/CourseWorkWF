namespace CourseWorkWF.Views
{
    partial class MainMenuForm
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
            buttonAssortment = new Button();
            buttonSell = new Button();
            buttonChangeJobTitle = new Button();
            buttonRemoveEmployee = new Button();
            buttonRefund = new Button();
            buttonHistoryComingsAndGoings = new Button();
            SuspendLayout();
            // 
            // buttonAssortment
            // 
            buttonAssortment.Location = new Point(551, 11);
            buttonAssortment.Margin = new Padding(3, 2, 3, 2);
            buttonAssortment.Name = "buttonAssortment";
            buttonAssortment.Size = new Size(137, 92);
            buttonAssortment.TabIndex = 0;
            buttonAssortment.Text = "Асортимент";
            buttonAssortment.UseVisualStyleBackColor = true;
            buttonAssortment.Visible = false;
            buttonAssortment.Click += ButtonAdmin_Click;
            // 
            // buttonSell
            // 
            buttonSell.Location = new Point(12, 12);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(137, 92);
            buttonSell.TabIndex = 1;
            buttonSell.Text = "Продать";
            buttonSell.UseVisualStyleBackColor = true;
            buttonSell.Visible = false;
            buttonSell.Click += ButtonSell_Click;
            // 
            // buttonChangeJobTitle
            // 
            buttonChangeJobTitle.Location = new Point(408, 234);
            buttonChangeJobTitle.Name = "buttonChangeJobTitle";
            buttonChangeJobTitle.Size = new Size(137, 92);
            buttonChangeJobTitle.TabIndex = 2;
            buttonChangeJobTitle.Text = "Изменить должность";
            buttonChangeJobTitle.UseVisualStyleBackColor = true;
            buttonChangeJobTitle.Visible = false;
            buttonChangeJobTitle.Click += buttonChangeJobTitle_Click;
            // 
            // buttonRemoveEmployee
            // 
            buttonRemoveEmployee.Location = new Point(551, 234);
            buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            buttonRemoveEmployee.Size = new Size(137, 92);
            buttonRemoveEmployee.TabIndex = 3;
            buttonRemoveEmployee.Text = "Удалить сотрудника";
            buttonRemoveEmployee.UseVisualStyleBackColor = true;
            buttonRemoveEmployee.Visible = false;
            buttonRemoveEmployee.Click += buttonRemoveEmployee_Click;
            // 
            // buttonRefund
            // 
            buttonRefund.Location = new Point(12, 119);
            buttonRefund.Name = "buttonRefund";
            buttonRefund.Size = new Size(137, 92);
            buttonRefund.TabIndex = 5;
            buttonRefund.Text = "Вернуть деньги";
            buttonRefund.UseVisualStyleBackColor = true;
            buttonRefund.Visible = false;
            buttonRefund.Click += buttonRefund_Click;
            // 
            // buttonHistoryComingsAndGoings
            // 
            buttonHistoryComingsAndGoings.Location = new Point(408, 11);
            buttonHistoryComingsAndGoings.Name = "buttonHistoryComingsAndGoings";
            buttonHistoryComingsAndGoings.Size = new Size(137, 92);
            buttonHistoryComingsAndGoings.TabIndex = 6;
            buttonHistoryComingsAndGoings.Text = "История прихода и ухода";
            buttonHistoryComingsAndGoings.UseVisualStyleBackColor = true;
            buttonHistoryComingsAndGoings.Visible = false;
            buttonHistoryComingsAndGoings.Click += buttonHistoryComingsAndGoings_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonHistoryComingsAndGoings);
            Controls.Add(buttonRefund);
            Controls.Add(buttonRemoveEmployee);
            Controls.Add(buttonChangeJobTitle);
            Controls.Add(buttonSell);
            Controls.Add(buttonAssortment);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenuForm";
            Text = "User";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAssortment;
        private Button buttonSell;
        private Button buttonChangeJobTitle;
        private Button buttonRemoveEmployee;
        private Button buttonRefund;
        private Button buttonHistoryComingsAndGoings;
    }
}