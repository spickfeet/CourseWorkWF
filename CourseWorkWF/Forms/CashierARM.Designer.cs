namespace CourseWorkWF.Forms
{
    partial class CashierARM
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
            TextBoxPrice = new TextBox();
            ComboBoxDiscount = new ComboBox();
            LabelDiscount = new Label();
            LabelPayMethod = new Label();
            ComboBoxTransactionMethod = new ComboBox();
            ListBoxBuyProducts = new ListBox();
            LabelProductID = new Label();
            TextBoxProductID = new TextBox();
            TextBoxCashierName = new TextBox();
            LabelCashierName = new Label();
            ButtonAddProduct = new Button();
            ButtonSell = new Button();
            ButtonDiscountUse = new Button();
            TextBoxRevenue = new TextBox();
            SuspendLayout();
            // 
            // TextBoxPrice
            // 
            TextBoxPrice.Location = new Point(597, 291);
            TextBoxPrice.Name = "TextBoxPrice";
            TextBoxPrice.ReadOnly = true;
            TextBoxPrice.Size = new Size(100, 23);
            TextBoxPrice.TabIndex = 0;
            TextBoxPrice.Text = "0";
            // 
            // ComboBoxDiscount
            // 
            ComboBoxDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxDiscount.FormattingEnabled = true;
            ComboBoxDiscount.Items.AddRange(new object[] { "0", "5 ", "10 ", "15 ", "20 ", "25 " });
            ComboBoxDiscount.Location = new Point(12, 261);
            ComboBoxDiscount.Name = "ComboBoxDiscount";
            ComboBoxDiscount.Size = new Size(121, 23);
            ComboBoxDiscount.TabIndex = 1;
            ComboBoxDiscount.UseWaitCursor = true;
            ComboBoxDiscount.SelectedIndexChanged += СomboBoxDiscount_SelectedIndexChanged;
            // 
            // LabelDiscount
            // 
            LabelDiscount.AutoSize = true;
            LabelDiscount.Location = new Point(12, 243);
            LabelDiscount.Name = "LabelDiscount";
            LabelDiscount.Size = new Size(46, 15);
            LabelDiscount.TabIndex = 2;
            LabelDiscount.Text = "Скидка";
            // 
            // LabelPayMethod
            // 
            LabelPayMethod.AutoSize = true;
            LabelPayMethod.Location = new Point(139, 243);
            LabelPayMethod.Name = "LabelPayMethod";
            LabelPayMethod.Size = new Size(93, 15);
            LabelPayMethod.TabIndex = 4;
            LabelPayMethod.Text = "Способ оплаты";
            // 
            // ComboBoxTransactionMethod
            // 
            ComboBoxTransactionMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTransactionMethod.FormattingEnabled = true;
            ComboBoxTransactionMethod.Items.AddRange(new object[] { "Наличные", "Карта" });
            ComboBoxTransactionMethod.Location = new Point(139, 261);
            ComboBoxTransactionMethod.Name = "ComboBoxTransactionMethod";
            ComboBoxTransactionMethod.Size = new Size(121, 23);
            ComboBoxTransactionMethod.TabIndex = 3;
            ComboBoxTransactionMethod.UseWaitCursor = true;
            // 
            // ListBoxBuyProducts
            // 
            ListBoxBuyProducts.FormattingEnabled = true;
            ListBoxBuyProducts.ItemHeight = 15;
            ListBoxBuyProducts.Location = new Point(597, 56);
            ListBoxBuyProducts.Name = "ListBoxBuyProducts";
            ListBoxBuyProducts.Size = new Size(191, 229);
            ListBoxBuyProducts.TabIndex = 5;
            // 
            // LabelProductID
            // 
            LabelProductID.AutoSize = true;
            LabelProductID.Location = new Point(597, 9);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(58, 15);
            LabelProductID.TabIndex = 6;
            LabelProductID.Text = "ID товара";
            // 
            // TextBoxProductID
            // 
            TextBoxProductID.Location = new Point(597, 27);
            TextBoxProductID.Name = "TextBoxProductID";
            TextBoxProductID.Size = new Size(100, 23);
            TextBoxProductID.TabIndex = 7;
            // 
            // TextBoxCashierName
            // 
            TextBoxCashierName.Location = new Point(12, 415);
            TextBoxCashierName.Name = "TextBoxCashierName";
            TextBoxCashierName.ReadOnly = true;
            TextBoxCashierName.Size = new Size(220, 23);
            TextBoxCashierName.TabIndex = 8;
            TextBoxCashierName.Text = "Елена Васильевна";
            // 
            // LabelCashierName
            // 
            LabelCashierName.AutoSize = true;
            LabelCashierName.Location = new Point(12, 397);
            LabelCashierName.Name = "LabelCashierName";
            LabelCashierName.Size = new Size(46, 15);
            LabelCashierName.TabIndex = 9;
            LabelCashierName.Text = "Кассир";
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(703, 27);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(85, 23);
            ButtonAddProduct.TabIndex = 10;
            ButtonAddProduct.Text = "Добавить";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            ButtonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // ButtonSell
            // 
            ButtonSell.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSell.Location = new Point(597, 320);
            ButtonSell.Name = "ButtonSell";
            ButtonSell.Size = new Size(191, 49);
            ButtonSell.TabIndex = 11;
            ButtonSell.Text = "ПРОДАТЬ";
            ButtonSell.UseVisualStyleBackColor = true;
            ButtonSell.Click += ButtonSell_Click;
            // 
            // ButtonDiscountUse
            // 
            ButtonDiscountUse.Location = new Point(12, 291);
            ButtonDiscountUse.Name = "ButtonDiscountUse";
            ButtonDiscountUse.Size = new Size(121, 50);
            ButtonDiscountUse.TabIndex = 12;
            ButtonDiscountUse.Text = "Применит скидку";
            ButtonDiscountUse.UseVisualStyleBackColor = true;
            // 
            // TextBoxRevenue
            // 
            TextBoxRevenue.Location = new Point(71, 56);
            TextBoxRevenue.Name = "TextBoxRevenue";
            TextBoxRevenue.ReadOnly = true;
            TextBoxRevenue.Size = new Size(100, 23);
            TextBoxRevenue.TabIndex = 13;
            TextBoxRevenue.Text = "0";
            // 
            // CashierARM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextBoxRevenue);
            Controls.Add(ButtonDiscountUse);
            Controls.Add(ButtonSell);
            Controls.Add(ButtonAddProduct);
            Controls.Add(LabelCashierName);
            Controls.Add(TextBoxCashierName);
            Controls.Add(TextBoxProductID);
            Controls.Add(LabelProductID);
            Controls.Add(ListBoxBuyProducts);
            Controls.Add(LabelPayMethod);
            Controls.Add(ComboBoxTransactionMethod);
            Controls.Add(LabelDiscount);
            Controls.Add(ComboBoxDiscount);
            Controls.Add(TextBoxPrice);
            Name = "CashierARM";
            Text = "CashierARM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxPrice;
        private ComboBox ComboBoxDiscount;
        private Label LabelDiscount;
        private Label LabelPayMethod;
        private ComboBox ComboBoxTransactionMethod;
        private ListBox ListBoxBuyProducts;
        private Label LabelProductID;
        private TextBox TextBoxProductID;
        private TextBox TextBoxCashierName;
        private Label LabelCashierName;
        private Button ButtonAddProduct;
        private Button ButtonSell;
        private Button ButtonDiscountUse;
        private TextBox TextBoxRevenue;
    }
}