namespace CourseWorkWF
{
    partial class AddAssortment
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
            TextBoxProductID = new TextBox();
            LabelProductID = new Label();
            LabelProductName = new Label();
            TextBoxProductName = new TextBox();
            LableProductPrice = new Label();
            TextBoxProductPrice = new TextBox();
            LabelAmount = new Label();
            TextBoxAmount = new TextBox();
            SuspendLayout();
            // 
            // ButtonAddProductInAssortment
            // 
            ButtonAddProductInAssortment.Location = new Point(188, 24);
            ButtonAddProductInAssortment.Name = "ButtonAddProductInAssortment";
            ButtonAddProductInAssortment.Size = new Size(104, 70);
            ButtonAddProductInAssortment.TabIndex = 0;
            ButtonAddProductInAssortment.Text = "Добавить";
            ButtonAddProductInAssortment.UseVisualStyleBackColor = true;
            ButtonAddProductInAssortment.Click += AddProductInAssortmentButton_Click;
            // 
            // TextBoxProductID
            // 
            TextBoxProductID.Location = new Point(12, 24);
            TextBoxProductID.Name = "TextBoxProductID";
            TextBoxProductID.Size = new Size(145, 23);
            TextBoxProductID.TabIndex = 1;
            // 
            // LabelProductID
            // 
            LabelProductID.AutoSize = true;
            LabelProductID.Location = new Point(12, 6);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(71, 15);
            LabelProductID.TabIndex = 3;
            LabelProductID.Text = "ID продукта";
            // 
            // LabelProductName
            // 
            LabelProductName.AutoSize = true;
            LabelProductName.Location = new Point(12, 50);
            LabelProductName.Name = "LabelProductName";
            LabelProductName.Size = new Size(59, 15);
            LabelProductName.TabIndex = 5;
            LabelProductName.Text = "Название";
            // 
            // TextBoxProductName
            // 
            TextBoxProductName.Location = new Point(12, 71);
            TextBoxProductName.Name = "TextBoxProductName";
            TextBoxProductName.Size = new Size(145, 23);
            TextBoxProductName.TabIndex = 4;
            // 
            // LableProductPrice
            // 
            LableProductPrice.AutoSize = true;
            LableProductPrice.Location = new Point(12, 97);
            LableProductPrice.Name = "LableProductPrice";
            LableProductPrice.Size = new Size(35, 15);
            LableProductPrice.TabIndex = 7;
            LableProductPrice.Text = "Цена";
            // 
            // TextBoxProductPrice
            // 
            TextBoxProductPrice.Location = new Point(12, 118);
            TextBoxProductPrice.Name = "TextBoxProductPrice";
            TextBoxProductPrice.Size = new Size(145, 23);
            TextBoxProductPrice.TabIndex = 6;
            // 
            // LabelAmount
            // 
            LabelAmount.AutoSize = true;
            LabelAmount.Location = new Point(12, 144);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(72, 15);
            LabelAmount.TabIndex = 8;
            LabelAmount.Text = "Количество";
            // 
            // TextBoxAmount
            // 
            TextBoxAmount.Location = new Point(12, 165);
            TextBoxAmount.Name = "TextBoxAmount";
            TextBoxAmount.Size = new Size(145, 23);
            TextBoxAmount.TabIndex = 9;
            // 
            // AddAssortment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 209);
            Controls.Add(TextBoxAmount);
            Controls.Add(LabelAmount);
            Controls.Add(LableProductPrice);
            Controls.Add(TextBoxProductPrice);
            Controls.Add(LabelProductName);
            Controls.Add(TextBoxProductName);
            Controls.Add(LabelProductID);
            Controls.Add(TextBoxProductID);
            Controls.Add(ButtonAddProductInAssortment);
            Name = "AddAssortment";
            Text = "AddAssortment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAddProductInAssortment;
        private TextBox TextBoxProductID;
        private Label LabelProductID;
        private Label LabelProductName;
        private TextBox TextBoxProductName;
        private Label LableProductPrice;
        private TextBox TextBoxProductPrice;
        private Label LabelAmount;
        private TextBox TextBoxAmount;
    }
}