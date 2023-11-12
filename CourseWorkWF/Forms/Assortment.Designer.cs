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
            buttonAddProductInAssortment = new Button();
            buttonRemoveProductInAssortment = new Button();
            labelAssortment = new Label();
            buttonLoadAssortment = new Button();
            listViewAssortment = new ListView();
            ColumnHeaderProductName = new ColumnHeader();
            ColumnHeaderProductID = new ColumnHeader();
            ColumnHeaderPrice = new ColumnHeader();
            ColumnHeaderAmount = new ColumnHeader();
            SuspendLayout();
            // 
            // buttonAddProductInAssortment
            // 
            buttonAddProductInAssortment.Location = new Point(17, 52);
            buttonAddProductInAssortment.Margin = new Padding(3, 4, 3, 4);
            buttonAddProductInAssortment.Name = "buttonAddProductInAssortment";
            buttonAddProductInAssortment.Size = new Size(193, 91);
            buttonAddProductInAssortment.TabIndex = 0;
            buttonAddProductInAssortment.Text = "Добавить";
            buttonAddProductInAssortment.UseVisualStyleBackColor = true;
            buttonAddProductInAssortment.Click += AddProductInAssortmentButton_Click;
            // 
            // buttonRemoveProductInAssortment
            // 
            buttonRemoveProductInAssortment.Location = new Point(217, 52);
            buttonRemoveProductInAssortment.Margin = new Padding(3, 4, 3, 4);
            buttonRemoveProductInAssortment.Name = "buttonRemoveProductInAssortment";
            buttonRemoveProductInAssortment.Size = new Size(193, 91);
            buttonRemoveProductInAssortment.TabIndex = 1;
            buttonRemoveProductInAssortment.Text = "Удалить";
            buttonRemoveProductInAssortment.UseVisualStyleBackColor = true;
            buttonRemoveProductInAssortment.Click += ButtonRemoveProductInAssortment_Click;
            // 
            // labelAssortment
            // 
            labelAssortment.AutoSize = true;
            labelAssortment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelAssortment.Location = new Point(417, -1);
            labelAssortment.Name = "labelAssortment";
            labelAssortment.Size = new Size(224, 46);
            labelAssortment.TabIndex = 3;
            labelAssortment.Text = "Ассортимент";
            // 
            // buttonLoadAssortment
            // 
            buttonLoadAssortment.Location = new Point(277, 565);
            buttonLoadAssortment.Name = "buttonLoadAssortment";
            buttonLoadAssortment.Size = new Size(134, 69);
            buttonLoadAssortment.TabIndex = 4;
            buttonLoadAssortment.Text = "Обновить ассортимент";
            buttonLoadAssortment.UseVisualStyleBackColor = true;
            buttonLoadAssortment.Click += ButtonLoadAssortment_Click;
            // 
            // listViewAssortment
            // 
            listViewAssortment.Columns.AddRange(new ColumnHeader[] { ColumnHeaderProductName, ColumnHeaderProductID, ColumnHeaderPrice, ColumnHeaderAmount });
            listViewAssortment.Location = new Point(427, 52);
            listViewAssortment.Name = "listViewAssortment";
            listViewAssortment.Size = new Size(363, 583);
            listViewAssortment.TabIndex = 5;
            listViewAssortment.UseCompatibleStateImageBehavior = false;
            listViewAssortment.View = View.Details;
            // 
            // ColumnHeaderProductName
            // 
            ColumnHeaderProductName.Text = "Название";
            ColumnHeaderProductName.Width = 120;
            // 
            // ColumnHeaderProductID
            // 
            ColumnHeaderProductID.Text = "ID";
            // 
            // ColumnHeaderPrice
            // 
            ColumnHeaderPrice.Text = "Цена";
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
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(810, 645);
            Controls.Add(listViewAssortment);
            Controls.Add(buttonLoadAssortment);
            Controls.Add(labelAssortment);
            Controls.Add(buttonRemoveProductInAssortment);
            Controls.Add(buttonAddProductInAssortment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Assortment";
            Text = "Assortment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddProductInAssortment;
        private Button buttonRemoveProductInAssortment;
        private Label labelAssortment;
        private Button buttonLoadAssortment;
        private ListView listViewAssortment;
        private ColumnHeader ColumnHeaderProductName;
        private ColumnHeader ColumnHeaderProductID;
        private ColumnHeader ColumnHeaderAmount;
        private ColumnHeader ColumnHeaderPrice;
    }
}