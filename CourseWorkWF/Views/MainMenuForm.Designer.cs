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
            buttonUserController = new Button();
            buttonRefund = new Button();
            buttonHistory = new Button();
            buttonRevenue = new Button();
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
            // buttonUserController
            // 
            buttonUserController.Location = new Point(551, 234);
            buttonUserController.Name = "buttonUserController";
            buttonUserController.Size = new Size(137, 92);
            buttonUserController.TabIndex = 3;
            buttonUserController.Text = "Управление сотрудниками";
            buttonUserController.UseVisualStyleBackColor = true;
            buttonUserController.Visible = false;
            buttonUserController.Click += ButtonRemoveEmployee_Click;
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
            buttonRefund.Click += ButtonRefund_Click;
            // 
            // buttonHistory
            // 
            buttonHistory.Location = new Point(408, 11);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(137, 92);
            buttonHistory.TabIndex = 6;
            buttonHistory.Text = "История";
            buttonHistory.UseVisualStyleBackColor = true;
            buttonHistory.Visible = false;
            buttonHistory.Click += ButtonHistory_Click;
            // 
            // buttonRevenue
            // 
            buttonRevenue.Location = new Point(12, 234);
            buttonRevenue.Name = "buttonRevenue";
            buttonRevenue.Size = new Size(137, 92);
            buttonRevenue.TabIndex = 7;
            buttonRevenue.Text = "Закрыть смену";
            buttonRevenue.UseVisualStyleBackColor = true;
            buttonRevenue.Click += ButtonRevenue_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(buttonRevenue);
            Controls.Add(buttonHistory);
            Controls.Add(buttonRefund);
            Controls.Add(buttonUserController);
            Controls.Add(buttonSell);
            Controls.Add(buttonAssortment);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenuForm";
            Text = "User";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAssortment;
        private Button buttonSell;
        private Button buttonChangeJobTitle;
        private Button buttonUserController;
        private Button buttonRefund;
        private Button buttonHistory;
        private Button buttonRevenue;
    }
}