namespace CourseWorkWF.Views
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
            listViewAssortment = new ListView();
            ColumnHeaderProductName = new ColumnHeader();
            ColumnHeaderProductID = new ColumnHeader();
            ColumnHeaderPrice = new ColumnHeader();
            ColumnHeaderAmount = new ColumnHeader();
            buttonChangePrice = new Button();
            SuspendLayout();
            // 
            // buttonAddProductInAssortment
            // 
            buttonAddProductInAssortment.BackColor = Color.OliveDrab;
            buttonAddProductInAssortment.Location = new Point(20, 39);
            buttonAddProductInAssortment.Name = "buttonAddProductInAssortment";
            buttonAddProductInAssortment.Size = new Size(169, 68);
            buttonAddProductInAssortment.TabIndex = 0;
            buttonAddProductInAssortment.Text = "Добавить";
            buttonAddProductInAssortment.UseVisualStyleBackColor = false;
            buttonAddProductInAssortment.Click += AddProductInAssortmentButton_Click;
            // 
            // buttonRemoveProductInAssortment
            // 
            buttonRemoveProductInAssortment.BackColor = Color.IndianRed;
            buttonRemoveProductInAssortment.Location = new Point(195, 39);
            buttonRemoveProductInAssortment.Name = "buttonRemoveProductInAssortment";
            buttonRemoveProductInAssortment.Size = new Size(169, 68);
            buttonRemoveProductInAssortment.TabIndex = 1;
            buttonRemoveProductInAssortment.Text = "Удалить";
            buttonRemoveProductInAssortment.UseVisualStyleBackColor = false;
            buttonRemoveProductInAssortment.Click += ButtonRemoveProductInAssortment_Click;
            // 
            // labelAssortment
            // 
            labelAssortment.AutoSize = true;
            labelAssortment.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelAssortment.Location = new Point(12, 110);
            labelAssortment.Name = "labelAssortment";
            labelAssortment.Size = new Size(177, 37);
            labelAssortment.TabIndex = 3;
            labelAssortment.Text = "Ассортимент";
            // 
            // listViewAssortment
            // 
            listViewAssortment.Columns.AddRange(new ColumnHeader[] { ColumnHeaderProductName, ColumnHeaderProductID, ColumnHeaderPrice, ColumnHeaderAmount });
            listViewAssortment.Location = new Point(12, 149);
            listViewAssortment.Margin = new Padding(3, 2, 3, 2);
            listViewAssortment.Name = "listViewAssortment";
            listViewAssortment.Size = new Size(660, 318);
            listViewAssortment.TabIndex = 5;
            listViewAssortment.UseCompatibleStateImageBehavior = false;
            listViewAssortment.View = View.Details;
            // 
            // ColumnHeaderProductName
            // 
            ColumnHeaderProductName.Text = "Название";
            ColumnHeaderProductName.Width = 200;
            // 
            // ColumnHeaderProductID
            // 
            ColumnHeaderProductID.Text = "ID";
            ColumnHeaderProductID.Width = 150;
            // 
            // ColumnHeaderPrice
            // 
            ColumnHeaderPrice.Text = "Цена";
            ColumnHeaderPrice.Width = 150;
            // 
            // ColumnHeaderAmount
            // 
            ColumnHeaderAmount.Text = "Количество";
            ColumnHeaderAmount.Width = 150;
            // 
            // buttonChangePrice
            // 
            buttonChangePrice.BackColor = Color.Turquoise;
            buttonChangePrice.Location = new Point(370, 39);
            buttonChangePrice.Name = "buttonChangePrice";
            buttonChangePrice.Size = new Size(172, 68);
            buttonChangePrice.TabIndex = 6;
            buttonChangePrice.Text = "Изменить цену";
            buttonChangePrice.UseVisualStyleBackColor = false;
            buttonChangePrice.Click += ButtonChangePrice_Click;
            // 
            // AssortmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(684, 478);
            Controls.Add(buttonChangePrice);
            Controls.Add(listViewAssortment);
            Controls.Add(labelAssortment);
            Controls.Add(buttonRemoveProductInAssortment);
            Controls.Add(buttonAddProductInAssortment);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AssortmentForm";
            Text = "MyARM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddProductInAssortment;
        private Button buttonRemoveProductInAssortment;
        private Label labelAssortment;
        private ListView listViewAssortment;
        private ColumnHeader ColumnHeaderProductName;
        private ColumnHeader ColumnHeaderProductID;
        private ColumnHeader ColumnHeaderAmount;
        private ColumnHeader ColumnHeaderPrice;
        private Button buttonChangePrice;
    }
}