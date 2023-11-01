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
            LabelAssortment = new Label();
            ButtonLoadAssortment = new Button();
            ListViewAssortment = new ListView();
            ColumnHeaderProductName = new ColumnHeader();
            ColumnHeaderProductID = new ColumnHeader();
            ColumnHeaderAmount = new ColumnHeader();
            SuspendLayout();
            // 
            // ButtonAddProductInAssortment
            // 
            ButtonAddProductInAssortment.Location = new Point(17, 52);
            ButtonAddProductInAssortment.Margin = new Padding(3, 4, 3, 4);
            ButtonAddProductInAssortment.Name = "ButtonAddProductInAssortment";
            ButtonAddProductInAssortment.Size = new Size(193, 91);
            ButtonAddProductInAssortment.TabIndex = 0;
            ButtonAddProductInAssortment.Text = "Добавить";
            ButtonAddProductInAssortment.UseVisualStyleBackColor = true;
            ButtonAddProductInAssortment.Click += AddProductInAssortmentButton_Click;
            // 
            // ButtonRemoveProductInAssortment
            // 
            ButtonRemoveProductInAssortment.Location = new Point(217, 52);
            ButtonRemoveProductInAssortment.Margin = new Padding(3, 4, 3, 4);
            ButtonRemoveProductInAssortment.Name = "ButtonRemoveProductInAssortment";
            ButtonRemoveProductInAssortment.Size = new Size(193, 91);
            ButtonRemoveProductInAssortment.TabIndex = 1;
            ButtonRemoveProductInAssortment.Text = "Удалить";
            ButtonRemoveProductInAssortment.UseVisualStyleBackColor = true;
            ButtonRemoveProductInAssortment.Click += ButtonRemoveProductInAssortment_Click;
            // 
            // LabelAssortment
            // 
            LabelAssortment.AutoSize = true;
            LabelAssortment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAssortment.Location = new Point(417, -1);
            LabelAssortment.Name = "LabelAssortment";
            LabelAssortment.Size = new Size(224, 46);
            LabelAssortment.TabIndex = 3;
            LabelAssortment.Text = "Ассортимент";
            // 
            // ButtonLoadAssortment
            // 
            ButtonLoadAssortment.Location = new Point(277, 565);
            ButtonLoadAssortment.Name = "ButtonLoadAssortment";
            ButtonLoadAssortment.Size = new Size(134, 69);
            ButtonLoadAssortment.TabIndex = 4;
            ButtonLoadAssortment.Text = "Обновить ассортимент";
            ButtonLoadAssortment.UseVisualStyleBackColor = true;
            ButtonLoadAssortment.Click += ButtonLoadAssortment_Click;
            // 
            // ListViewAssortment
            // 
            ListViewAssortment.Columns.AddRange(new ColumnHeader[] { ColumnHeaderProductName, ColumnHeaderProductID, ColumnHeaderAmount });
            ListViewAssortment.Location = new Point(427, 52);
            ListViewAssortment.Name = "ListViewAssortment";
            ListViewAssortment.Size = new Size(363, 582);
            ListViewAssortment.TabIndex = 5;
            ListViewAssortment.UseCompatibleStateImageBehavior = false;
            ListViewAssortment.View = View.Details;
            // 
            // ColumnHeaderProductName
            // 
            ColumnHeaderProductName.Text = "Название";
            ColumnHeaderProductName.Width = 120;
            // 
            // ColumnHeaderProductID
            // 
            ColumnHeaderProductID.Text = "ID";
            ColumnHeaderProductID.Width = 120;
            // 
            // ColumnHeaderAmount
            // 
            ColumnHeaderAmount.Text = "Количество";
            ColumnHeaderAmount.Width = 120;
            // 
            // Assortment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 646);
            Controls.Add(ListViewAssortment);
            Controls.Add(ButtonLoadAssortment);
            Controls.Add(LabelAssortment);
            Controls.Add(ButtonRemoveProductInAssortment);
            Controls.Add(ButtonAddProductInAssortment);
            Margin = new Padding(3, 4, 3, 4);
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
        private ListView ListViewAssortment;
        private ColumnHeader ColumnHeaderProductName;
        private ColumnHeader ColumnHeaderProductID;
        private ColumnHeader ColumnHeaderAmount;
    }
}