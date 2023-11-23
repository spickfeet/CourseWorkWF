namespace CourseWorkWF
{
    partial class AssortmentForm
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
            buttonAddProductInAssortment.Location = new Point(15, 39);
            buttonAddProductInAssortment.Name = "buttonAddProductInAssortment";
            buttonAddProductInAssortment.Size = new Size(169, 68);
            buttonAddProductInAssortment.TabIndex = 0;
            buttonAddProductInAssortment.Text = "Добавить";
            buttonAddProductInAssortment.UseVisualStyleBackColor = true;
            buttonAddProductInAssortment.Click += AddProductInAssortmentButton_Click;
            // 
            // buttonRemoveProductInAssortment
            // 
            buttonRemoveProductInAssortment.Location = new Point(190, 39);
            buttonRemoveProductInAssortment.Name = "buttonRemoveProductInAssortment";
            buttonRemoveProductInAssortment.Size = new Size(169, 68);
            buttonRemoveProductInAssortment.TabIndex = 1;
            buttonRemoveProductInAssortment.Text = "Удалить";
            buttonRemoveProductInAssortment.UseVisualStyleBackColor = true;
            buttonRemoveProductInAssortment.Click += ButtonRemoveProductInAssortment_Click;
            // 
            // labelAssortment
            // 
            labelAssortment.AutoSize = true;
            labelAssortment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelAssortment.Location = new Point(365, -1);
            labelAssortment.Name = "labelAssortment";
            labelAssortment.Size = new Size(177, 37);
            labelAssortment.TabIndex = 3;
            labelAssortment.Text = "Ассортимент";
            // 
            // buttonLoadAssortment
            // 
            buttonLoadAssortment.Location = new Point(242, 424);
            buttonLoadAssortment.Margin = new Padding(3, 2, 3, 2);
            buttonLoadAssortment.Name = "buttonLoadAssortment";
            buttonLoadAssortment.Size = new Size(117, 52);
            buttonLoadAssortment.TabIndex = 4;
            buttonLoadAssortment.Text = "Обновить ассортимент";
            buttonLoadAssortment.UseVisualStyleBackColor = true;
            buttonLoadAssortment.Click += ButtonLoadAssortment_Click;
            // 
            // listViewAssortment
            // 
            listViewAssortment.Columns.AddRange(new ColumnHeader[] { ColumnHeaderProductName, ColumnHeaderProductID, ColumnHeaderPrice, ColumnHeaderAmount });
            listViewAssortment.Location = new Point(374, 39);
            listViewAssortment.Margin = new Padding(3, 2, 3, 2);
            listViewAssortment.Name = "listViewAssortment";
            listViewAssortment.Size = new Size(318, 438);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(709, 484);
            Controls.Add(listViewAssortment);
            Controls.Add(buttonLoadAssortment);
            Controls.Add(labelAssortment);
            Controls.Add(buttonRemoveProductInAssortment);
            Controls.Add(buttonAddProductInAssortment);
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