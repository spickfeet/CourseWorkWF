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
            numericUpDownCashierName = new TextBox();
            LabelCashierName = new Label();
            ButtonAddProduct = new Button();
            ButtonSell = new Button();
            TextBoxRevenue = new TextBox();
            LabelRevenue = new Label();
            ButtonCancelDiscount = new Button();
            TextBoxMoneyChangeBuyer = new TextBox();
            LabelCash = new Label();
            LabelMoneyChangeBuyer = new Label();
            NumericUpDownProductID = new NumericUpDown();
            NumericUpDownCash = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCash).BeginInit();
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
            ComboBoxDiscount.Enabled = false;
            ComboBoxDiscount.FormattingEnabled = true;
            ComboBoxDiscount.Items.AddRange(new object[] { "0", "5 ", "10 ", "15 ", "20 ", "25 " });
            ComboBoxDiscount.Location = new Point(12, 196);
            ComboBoxDiscount.Name = "ComboBoxDiscount";
            ComboBoxDiscount.Size = new Size(121, 23);
            ComboBoxDiscount.TabIndex = 1;
            ComboBoxDiscount.UseWaitCursor = true;
            ComboBoxDiscount.SelectedIndexChanged += ComboBoxDiscount_SelectedIndexChanged;
            // 
            // LabelDiscount
            // 
            LabelDiscount.AutoSize = true;
            LabelDiscount.Location = new Point(12, 178);
            LabelDiscount.Name = "LabelDiscount";
            LabelDiscount.Size = new Size(46, 15);
            LabelDiscount.TabIndex = 2;
            LabelDiscount.Text = "Скидка";
            // 
            // LabelPayMethod
            // 
            LabelPayMethod.AutoSize = true;
            LabelPayMethod.Location = new Point(139, 178);
            LabelPayMethod.Name = "LabelPayMethod";
            LabelPayMethod.Size = new Size(93, 15);
            LabelPayMethod.TabIndex = 4;
            LabelPayMethod.Text = "Способ оплаты";
            // 
            // ComboBoxTransactionMethod
            // 
            ComboBoxTransactionMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTransactionMethod.Enabled = false;
            ComboBoxTransactionMethod.FormattingEnabled = true;
            ComboBoxTransactionMethod.Items.AddRange(new object[] { "Наличные", "Карта" });
            ComboBoxTransactionMethod.Location = new Point(139, 196);
            ComboBoxTransactionMethod.Name = "ComboBoxTransactionMethod";
            ComboBoxTransactionMethod.Size = new Size(121, 23);
            ComboBoxTransactionMethod.TabIndex = 3;
            ComboBoxTransactionMethod.UseWaitCursor = true;
            ComboBoxTransactionMethod.SelectedIndexChanged += ComboBoxTransactionMethod_SelectedIndexChanged;
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
            // numericUpDownCashierName
            // 
            numericUpDownCashierName.Location = new Point(12, 415);
            numericUpDownCashierName.Name = "numericUpDownCashierName";
            numericUpDownCashierName.ReadOnly = true;
            numericUpDownCashierName.Size = new Size(220, 23);
            numericUpDownCashierName.TabIndex = 8;
            numericUpDownCashierName.Text = "Елена Васильевна";
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
            ButtonSell.Enabled = false;
            ButtonSell.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSell.Location = new Point(597, 320);
            ButtonSell.Name = "ButtonSell";
            ButtonSell.Size = new Size(191, 49);
            ButtonSell.TabIndex = 11;
            ButtonSell.Text = "ПРОДАТЬ";
            ButtonSell.UseVisualStyleBackColor = true;
            ButtonSell.Click += ButtonSell_Click;
            // 
            // TextBoxRevenue
            // 
            TextBoxRevenue.Location = new Point(115, 9);
            TextBoxRevenue.Name = "TextBoxRevenue";
            TextBoxRevenue.ReadOnly = true;
            TextBoxRevenue.Size = new Size(100, 23);
            TextBoxRevenue.TabIndex = 13;
            TextBoxRevenue.Text = "0";
            // 
            // LabelRevenue
            // 
            LabelRevenue.AutoSize = true;
            LabelRevenue.Location = new Point(12, 12);
            LabelRevenue.Name = "LabelRevenue";
            LabelRevenue.Size = new Size(97, 15);
            LabelRevenue.TabIndex = 14;
            LabelRevenue.Text = "Выручка за день";
            // 
            // ButtonCancelDiscount
            // 
            ButtonCancelDiscount.Enabled = false;
            ButtonCancelDiscount.Location = new Point(12, 225);
            ButtonCancelDiscount.Name = "ButtonCancelDiscount";
            ButtonCancelDiscount.Size = new Size(121, 46);
            ButtonCancelDiscount.TabIndex = 15;
            ButtonCancelDiscount.Text = "Отменит скидку";
            ButtonCancelDiscount.UseVisualStyleBackColor = true;
            ButtonCancelDiscount.Click += ButtonCancelDiscount_Click;
            // 
            // TextBoxMoneyChangeBuyer
            // 
            TextBoxMoneyChangeBuyer.Location = new Point(139, 292);
            TextBoxMoneyChangeBuyer.Name = "TextBoxMoneyChangeBuyer";
            TextBoxMoneyChangeBuyer.ReadOnly = true;
            TextBoxMoneyChangeBuyer.Size = new Size(100, 23);
            TextBoxMoneyChangeBuyer.TabIndex = 17;
            TextBoxMoneyChangeBuyer.Visible = false;
            // 
            // LabelCash
            // 
            LabelCash.AutoSize = true;
            LabelCash.Location = new Point(139, 230);
            LabelCash.Name = "LabelCash";
            LabelCash.Size = new Size(65, 15);
            LabelCash.TabIndex = 18;
            LabelCash.Text = "Наличные";
            LabelCash.Visible = false;
            // 
            // LabelMoneyChangeBuyer
            // 
            LabelMoneyChangeBuyer.AutoSize = true;
            LabelMoneyChangeBuyer.Location = new Point(139, 274);
            LabelMoneyChangeBuyer.Name = "LabelMoneyChangeBuyer";
            LabelMoneyChangeBuyer.Size = new Size(40, 15);
            LabelMoneyChangeBuyer.TabIndex = 19;
            LabelMoneyChangeBuyer.Text = "Сдача";
            LabelMoneyChangeBuyer.Visible = false;
            // 
            // NumericUpDownProductID
            // 
            NumericUpDownProductID.Location = new Point(597, 27);
            NumericUpDownProductID.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownProductID.Name = "NumericUpDownProductID";
            NumericUpDownProductID.Size = new Size(100, 23);
            NumericUpDownProductID.TabIndex = 20;
            // 
            // NumericUpDownCash
            // 
            NumericUpDownCash.Location = new Point(140, 248);
            NumericUpDownCash.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownCash.Name = "NumericUpDownCash";
            NumericUpDownCash.Size = new Size(99, 23);
            NumericUpDownCash.TabIndex = 21;
            NumericUpDownCash.Visible = false;
            NumericUpDownCash.ValueChanged += NumericUpDownCash_ValueChanged;
            // 
            // CashierARM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumericUpDownCash);
            Controls.Add(NumericUpDownProductID);
            Controls.Add(LabelMoneyChangeBuyer);
            Controls.Add(LabelCash);
            Controls.Add(TextBoxMoneyChangeBuyer);
            Controls.Add(ButtonCancelDiscount);
            Controls.Add(LabelRevenue);
            Controls.Add(TextBoxRevenue);
            Controls.Add(ButtonSell);
            Controls.Add(ButtonAddProduct);
            Controls.Add(LabelCashierName);
            Controls.Add(numericUpDownCashierName);
            Controls.Add(LabelProductID);
            Controls.Add(ListBoxBuyProducts);
            Controls.Add(LabelPayMethod);
            Controls.Add(ComboBoxTransactionMethod);
            Controls.Add(LabelDiscount);
            Controls.Add(ComboBoxDiscount);
            Controls.Add(TextBoxPrice);
            Name = "CashierARM";
            Text = "CashierARM";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCash).EndInit();
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
        private TextBox numericUpDownCashierName;
        private Label LabelCashierName;
        private Button ButtonAddProduct;
        private Button ButtonSell;
        private TextBox TextBoxRevenue;
        private Label LabelRevenue;
        private Button ButtonCancelDiscount;
        private TextBox TextBoxMoneyChangeBuyer;
        private Label LabelCash;
        private Label LabelMoneyChangeBuyer;
        private NumericUpDown NumericUpDownProductID;
        private NumericUpDown NumericUpDownCash;
    }
}