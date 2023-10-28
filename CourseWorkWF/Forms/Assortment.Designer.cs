namespace CourseWorkWF
{
    partial class Assortment
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
            ButtonAddProductInAssortment = new Button();
            ButtonRemoveProductInAssortment = new Button();
            ListBoxAssortment = new ListBox();
            LabelAssortment = new Label();
            ButtonLoadAssortment = new Button();
            SuspendLayout();
            // 
            // ButtonAddProductInAssortment
            // 
            ButtonAddProductInAssortment.Location = new Point(15, 39);
            ButtonAddProductInAssortment.Name = "ButtonAddProductInAssortment";
            ButtonAddProductInAssortment.Size = new Size(169, 68);
            ButtonAddProductInAssortment.TabIndex = 0;
            ButtonAddProductInAssortment.Text = "Добавить";
            ButtonAddProductInAssortment.UseVisualStyleBackColor = true;
            ButtonAddProductInAssortment.Click += AddProductInAssortmentButton_Click;
            // 
            // ButtonRemoveProductInAssortment
            // 
            ButtonRemoveProductInAssortment.Location = new Point(190, 39);
            ButtonRemoveProductInAssortment.Name = "ButtonRemoveProductInAssortment";
            ButtonRemoveProductInAssortment.Size = new Size(169, 68);
            ButtonRemoveProductInAssortment.TabIndex = 1;
            ButtonRemoveProductInAssortment.Text = "Удалить";
            ButtonRemoveProductInAssortment.UseVisualStyleBackColor = true;
            ButtonRemoveProductInAssortment.Click += ButtonRemoveProductInAssortment_Click;
            // 
            // ListBoxAssortment
            // 
            ListBoxAssortment.FormattingEnabled = true;
            ListBoxAssortment.ItemHeight = 15;
            ListBoxAssortment.Location = new Point(365, 39);
            ListBoxAssortment.Name = "ListBoxAssortment";
            ListBoxAssortment.Size = new Size(245, 439);
            ListBoxAssortment.TabIndex = 2;
            // 
            // LabelAssortment
            // 
            LabelAssortment.AutoSize = true;
            LabelAssortment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAssortment.Location = new Point(365, -1);
            LabelAssortment.Name = "LabelAssortment";
            LabelAssortment.Size = new Size(177, 37);
            LabelAssortment.TabIndex = 3;
            LabelAssortment.Text = "Ассортимент";
            // 
            // ButtonLoadAssortment
            // 
            ButtonLoadAssortment.Location = new Point(242, 424);
            ButtonLoadAssortment.Margin = new Padding(3, 2, 3, 2);
            ButtonLoadAssortment.Name = "ButtonLoadAssortment";
            ButtonLoadAssortment.Size = new Size(117, 52);
            ButtonLoadAssortment.TabIndex = 4;
            ButtonLoadAssortment.Text = "Загрузить ассортимент";
            ButtonLoadAssortment.UseVisualStyleBackColor = true;
            ButtonLoadAssortment.Click += ButtonLoadAssortment_Click;
            // 
            // Assortment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 512);
            Controls.Add(ButtonLoadAssortment);
            Controls.Add(LabelAssortment);
            Controls.Add(ListBoxAssortment);
            Controls.Add(ButtonRemoveProductInAssortment);
            Controls.Add(ButtonAddProductInAssortment);
            Name = "Assortment";
            Text = "Assortment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAddProductInAssortment;
        private Button ButtonRemoveProductInAssortment;
        private Label LabelAssortment;
        private Button ButtonLoadAssortment;
        public ListBox ListBoxAssortment;
    }
}