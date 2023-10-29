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
            LabelProductID = new Label();
            LabelProductName = new Label();
            TextBoxProductName = new TextBox();
            LableProductPrice = new Label();
            LabelAmount = new Label();
            NumericUpDownProductID = new NumericUpDown();
            NumericUpDownProductPrice = new NumericUpDown();
            NumericUpDownAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAmount).BeginInit();
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
            // LabelAmount
            // 
            LabelAmount.AutoSize = true;
            LabelAmount.Location = new Point(12, 144);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(72, 15);
            LabelAmount.TabIndex = 8;
            LabelAmount.Text = "Количество";
            // 
            // NumericUpDownProductID
            // 
            NumericUpDownProductID.Location = new Point(12, 24);
            NumericUpDownProductID.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            NumericUpDownProductID.Name = "NumericUpDownProductID";
            NumericUpDownProductID.Size = new Size(145, 23);
            NumericUpDownProductID.TabIndex = 10;
            NumericUpDownProductID.ValueChanged += NumericUpDownProductID_ValueChanged;
            // 
            // NumericUpDownProductPrice
            // 
            NumericUpDownProductPrice.DecimalPlaces = 2;
            NumericUpDownProductPrice.Location = new Point(12, 118);
            NumericUpDownProductPrice.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownProductPrice.Name = "NumericUpDownProductPrice";
            NumericUpDownProductPrice.Size = new Size(145, 23);
            NumericUpDownProductPrice.TabIndex = 11;
            // 
            // NumericUpDownAmount
            // 
            NumericUpDownAmount.Location = new Point(12, 162);
            NumericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownAmount.Name = "NumericUpDownAmount";
            NumericUpDownAmount.Size = new Size(145, 23);
            NumericUpDownAmount.TabIndex = 12;
            // 
            // AddAssortment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 209);
            Controls.Add(NumericUpDownAmount);
            Controls.Add(NumericUpDownProductPrice);
            Controls.Add(NumericUpDownProductID);
            Controls.Add(LabelAmount);
            Controls.Add(LableProductPrice);
            Controls.Add(LabelProductName);
            Controls.Add(TextBoxProductName);
            Controls.Add(LabelProductID);
            Controls.Add(ButtonAddProductInAssortment);
            Name = "AddAssortment";
            Text = "AddAssortment";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonAddProductInAssortment;
        private Label LabelProductID;
        private Label LabelProductName;
        private TextBox TextBoxProductName;
        private Label LableProductPrice;
        private Label LabelAmount;
        private NumericUpDown NumericUpDownProductID;
        private NumericUpDown NumericUpDownProductPrice;
        private NumericUpDown NumericUpDownAmount;
    }
}