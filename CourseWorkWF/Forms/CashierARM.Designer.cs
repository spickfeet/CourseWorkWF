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
            components = new System.ComponentModel.Container();
            TextBoxPrice = new TextBox();
            ComboBoxDiscount = new ComboBox();
            LabelDiscount = new Label();
            LabelPayMethod = new Label();
            ComboBoxTransactionMethod = new ComboBox();
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
            ErrorProviderAddProductByID = new ErrorProvider(components);
            LabelAmount = new Label();
            NumericUpDownAmount = new NumericUpDown();
            ListViewBuyProducts = new ListView();
            ColumnHeaderName = new ColumnHeader();
            ColumnHeaderID = new ColumnHeader();
            ColumnHeaderAmount = new ColumnHeader();
            ErrorProviderAmount = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderAddProductByID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderAmount).BeginInit();
            SuspendLayout();
            // 
            // TextBoxPrice
            // 
            TextBoxPrice.Location = new Point(482, 360);
            TextBoxPrice.Name = "TextBoxPrice";
            TextBoxPrice.ReadOnly = true;
            TextBoxPrice.Size = new Size(151, 23);
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
            ButtonAddProduct.Size = new Size(85, 62);
            ButtonAddProduct.TabIndex = 10;
            ButtonAddProduct.Text = "Добавить";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            ButtonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // ButtonSell
            // 
            ButtonSell.Enabled = false;
            ButtonSell.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSell.Location = new Point(482, 389);
            ButtonSell.Name = "ButtonSell";
            ButtonSell.Size = new Size(306, 49);
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
            // ErrorProviderAddProductByID
            // 
            ErrorProviderAddProductByID.ContainerControl = this;
            ErrorProviderAddProductByID.RightToLeft = true;
            // 
            // LabelAmount
            // 
            LabelAmount.AutoSize = true;
            LabelAmount.Location = new Point(597, 50);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(72, 15);
            LabelAmount.TabIndex = 22;
            LabelAmount.Text = "Количество";
            // 
            // NumericUpDownAmount
            // 
            NumericUpDownAmount.Location = new Point(597, 68);
            NumericUpDownAmount.Margin = new Padding(3, 2, 3, 2);
            NumericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDownAmount.Name = "NumericUpDownAmount";
            NumericUpDownAmount.Size = new Size(101, 23);
            NumericUpDownAmount.TabIndex = 23;
            NumericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ListViewBuyProducts
            // 
            ListViewBuyProducts.Columns.AddRange(new ColumnHeader[] { ColumnHeaderName, ColumnHeaderID, ColumnHeaderAmount });
            ListViewBuyProducts.Location = new Point(483, 101);
            ListViewBuyProducts.Margin = new Padding(3, 2, 3, 2);
            ListViewBuyProducts.Name = "ListViewBuyProducts";
            ListViewBuyProducts.Size = new Size(305, 254);
            ListViewBuyProducts.TabIndex = 24;
            ListViewBuyProducts.UseCompatibleStateImageBehavior = false;
            ListViewBuyProducts.View = View.Details;
            // 
            // ColumnHeaderName
            // 
            ColumnHeaderName.Text = "Название";
            ColumnHeaderName.Width = 100;
            // 
            // ColumnHeaderID
            // 
            ColumnHeaderID.Text = "ID";
            ColumnHeaderID.Width = 100;
            // 
            // ColumnHeaderAmount
            // 
            ColumnHeaderAmount.Text = "Количество";
            ColumnHeaderAmount.Width = 100;
            // 
            // ErrorProviderAmount
            // 
            ErrorProviderAmount.ContainerControl = this;
            ErrorProviderAmount.RightToLeft = true;
            // 
            // CashierARM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(ListViewBuyProducts);
            Controls.Add(NumericUpDownAmount);
            Controls.Add(LabelAmount);
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
            Controls.Add(LabelPayMethod);
            Controls.Add(ComboBoxTransactionMethod);
            Controls.Add(LabelDiscount);
            Controls.Add(ComboBoxDiscount);
            Controls.Add(TextBoxPrice);
            Name = "CashierARM";
            Text = "CashierARM";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownCash).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderAddProductByID).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxPrice;
        private ComboBox ComboBoxDiscount;
        private Label LabelDiscount;
        private Label LabelPayMethod;
        private ComboBox ComboBoxTransactionMethod;
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
        private ErrorProvider ErrorProviderAddProductByID;
        private Label LabelAmount;
        private NumericUpDown NumericUpDownAmount;
        private ListView ListViewBuyProducts;
        private ColumnHeader ColumnHeaderName;
        private ColumnHeader ColumnHeaderID;
        private ColumnHeader ColumnHeaderAmount;
        private ErrorProvider ErrorProviderAmount;
    }
}