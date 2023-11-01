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
            ErrorProviderAddProductByID = new ErrorProvider(components);
            LabelAmount = new Label();
            NumericUpDownAmount = new NumericUpDown();
            listView1 = new ListView();
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
            TextBoxPrice.Location = new Point(609, 388);
            TextBoxPrice.Margin = new Padding(3, 4, 3, 4);
            TextBoxPrice.Name = "TextBoxPrice";
            TextBoxPrice.ReadOnly = true;
            TextBoxPrice.Size = new Size(114, 27);
            TextBoxPrice.TabIndex = 0;
            TextBoxPrice.Text = "0";
            // 
            // ComboBoxDiscount
            // 
            ComboBoxDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxDiscount.Enabled = false;
            ComboBoxDiscount.FormattingEnabled = true;
            ComboBoxDiscount.Items.AddRange(new object[] { "0", "5 ", "10 ", "15 ", "20 ", "25 " });
            ComboBoxDiscount.Location = new Point(14, 261);
            ComboBoxDiscount.Margin = new Padding(3, 4, 3, 4);
            ComboBoxDiscount.Name = "ComboBoxDiscount";
            ComboBoxDiscount.Size = new Size(138, 28);
            ComboBoxDiscount.TabIndex = 1;
            ComboBoxDiscount.UseWaitCursor = true;
            ComboBoxDiscount.SelectedIndexChanged += ComboBoxDiscount_SelectedIndexChanged;
            // 
            // LabelDiscount
            // 
            LabelDiscount.AutoSize = true;
            LabelDiscount.Location = new Point(14, 237);
            LabelDiscount.Name = "LabelDiscount";
            LabelDiscount.Size = new Size(57, 20);
            LabelDiscount.TabIndex = 2;
            LabelDiscount.Text = "Скидка";
            // 
            // LabelPayMethod
            // 
            LabelPayMethod.AutoSize = true;
            LabelPayMethod.Location = new Point(159, 237);
            LabelPayMethod.Name = "LabelPayMethod";
            LabelPayMethod.Size = new Size(116, 20);
            LabelPayMethod.TabIndex = 4;
            LabelPayMethod.Text = "Способ оплаты";
            // 
            // ComboBoxTransactionMethod
            // 
            ComboBoxTransactionMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxTransactionMethod.Enabled = false;
            ComboBoxTransactionMethod.FormattingEnabled = true;
            ComboBoxTransactionMethod.Items.AddRange(new object[] { "Наличные", "Карта" });
            ComboBoxTransactionMethod.Location = new Point(159, 261);
            ComboBoxTransactionMethod.Margin = new Padding(3, 4, 3, 4);
            ComboBoxTransactionMethod.Name = "ComboBoxTransactionMethod";
            ComboBoxTransactionMethod.Size = new Size(138, 28);
            ComboBoxTransactionMethod.TabIndex = 3;
            ComboBoxTransactionMethod.UseWaitCursor = true;
            ComboBoxTransactionMethod.SelectedIndexChanged += ComboBoxTransactionMethod_SelectedIndexChanged;
            // 
            // ListBoxBuyProducts
            // 
            ListBoxBuyProducts.FormattingEnabled = true;
            ListBoxBuyProducts.ItemHeight = 20;
            ListBoxBuyProducts.Location = new Point(281, 54);
            ListBoxBuyProducts.Margin = new Padding(3, 4, 3, 4);
            ListBoxBuyProducts.Name = "ListBoxBuyProducts";
            ListBoxBuyProducts.Size = new Size(218, 304);
            ListBoxBuyProducts.TabIndex = 5;
            // 
            // LabelProductID
            // 
            LabelProductID.AutoSize = true;
            LabelProductID.Location = new Point(682, 12);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(76, 20);
            LabelProductID.TabIndex = 6;
            LabelProductID.Text = "ID товара";
            // 
            // numericUpDownCashierName
            // 
            numericUpDownCashierName.Location = new Point(14, 553);
            numericUpDownCashierName.Margin = new Padding(3, 4, 3, 4);
            numericUpDownCashierName.Name = "numericUpDownCashierName";
            numericUpDownCashierName.ReadOnly = true;
            numericUpDownCashierName.Size = new Size(251, 27);
            numericUpDownCashierName.TabIndex = 8;
            numericUpDownCashierName.Text = "Елена Васильевна";
            // 
            // LabelCashierName
            // 
            LabelCashierName.AutoSize = true;
            LabelCashierName.Location = new Point(14, 529);
            LabelCashierName.Name = "LabelCashierName";
            LabelCashierName.Size = new Size(58, 20);
            LabelCashierName.TabIndex = 9;
            LabelCashierName.Text = "Кассир";
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(803, 36);
            ButtonAddProduct.Margin = new Padding(3, 4, 3, 4);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(97, 82);
            ButtonAddProduct.TabIndex = 10;
            ButtonAddProduct.Text = "Добавить";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            ButtonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // ButtonSell
            // 
            ButtonSell.Enabled = false;
            ButtonSell.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSell.Location = new Point(609, 427);
            ButtonSell.Margin = new Padding(3, 4, 3, 4);
            ButtonSell.Name = "ButtonSell";
            ButtonSell.Size = new Size(291, 65);
            ButtonSell.TabIndex = 11;
            ButtonSell.Text = "ПРОДАТЬ";
            ButtonSell.UseVisualStyleBackColor = true;
            ButtonSell.Click += ButtonSell_Click;
            // 
            // TextBoxRevenue
            // 
            TextBoxRevenue.Location = new Point(131, 12);
            TextBoxRevenue.Margin = new Padding(3, 4, 3, 4);
            TextBoxRevenue.Name = "TextBoxRevenue";
            TextBoxRevenue.ReadOnly = true;
            TextBoxRevenue.Size = new Size(114, 27);
            TextBoxRevenue.TabIndex = 13;
            TextBoxRevenue.Text = "0";
            // 
            // LabelRevenue
            // 
            LabelRevenue.AutoSize = true;
            LabelRevenue.Location = new Point(14, 16);
            LabelRevenue.Name = "LabelRevenue";
            LabelRevenue.Size = new Size(124, 20);
            LabelRevenue.TabIndex = 14;
            LabelRevenue.Text = "Выручка за день";
            // 
            // ButtonCancelDiscount
            // 
            ButtonCancelDiscount.Enabled = false;
            ButtonCancelDiscount.Location = new Point(14, 300);
            ButtonCancelDiscount.Margin = new Padding(3, 4, 3, 4);
            ButtonCancelDiscount.Name = "ButtonCancelDiscount";
            ButtonCancelDiscount.Size = new Size(138, 61);
            ButtonCancelDiscount.TabIndex = 15;
            ButtonCancelDiscount.Text = "Отменит скидку";
            ButtonCancelDiscount.UseVisualStyleBackColor = true;
            ButtonCancelDiscount.Click += ButtonCancelDiscount_Click;
            // 
            // TextBoxMoneyChangeBuyer
            // 
            TextBoxMoneyChangeBuyer.Location = new Point(159, 389);
            TextBoxMoneyChangeBuyer.Margin = new Padding(3, 4, 3, 4);
            TextBoxMoneyChangeBuyer.Name = "TextBoxMoneyChangeBuyer";
            TextBoxMoneyChangeBuyer.ReadOnly = true;
            TextBoxMoneyChangeBuyer.Size = new Size(114, 27);
            TextBoxMoneyChangeBuyer.TabIndex = 17;
            TextBoxMoneyChangeBuyer.Visible = false;
            // 
            // LabelCash
            // 
            LabelCash.AutoSize = true;
            LabelCash.Location = new Point(159, 307);
            LabelCash.Name = "LabelCash";
            LabelCash.Size = new Size(81, 20);
            LabelCash.TabIndex = 18;
            LabelCash.Text = "Наличные";
            LabelCash.Visible = false;
            // 
            // LabelMoneyChangeBuyer
            // 
            LabelMoneyChangeBuyer.AutoSize = true;
            LabelMoneyChangeBuyer.Location = new Point(159, 365);
            LabelMoneyChangeBuyer.Name = "LabelMoneyChangeBuyer";
            LabelMoneyChangeBuyer.Size = new Size(50, 20);
            LabelMoneyChangeBuyer.TabIndex = 19;
            LabelMoneyChangeBuyer.Text = "Сдача";
            LabelMoneyChangeBuyer.Visible = false;
            // 
            // NumericUpDownProductID
            // 
            NumericUpDownProductID.Location = new Point(682, 36);
            NumericUpDownProductID.Margin = new Padding(3, 4, 3, 4);
            NumericUpDownProductID.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownProductID.Name = "NumericUpDownProductID";
            NumericUpDownProductID.Size = new Size(114, 27);
            NumericUpDownProductID.TabIndex = 20;
            // 
            // NumericUpDownCash
            // 
            NumericUpDownCash.Location = new Point(160, 331);
            NumericUpDownCash.Margin = new Padding(3, 4, 3, 4);
            NumericUpDownCash.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownCash.Name = "NumericUpDownCash";
            NumericUpDownCash.Size = new Size(113, 27);
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
            LabelAmount.Location = new Point(682, 67);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(90, 20);
            LabelAmount.TabIndex = 22;
            LabelAmount.Text = "Количество";
            // 
            // NumericUpDownAmount
            // 
            NumericUpDownAmount.Location = new Point(682, 91);
            NumericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericUpDownAmount.Name = "NumericUpDownAmount";
            NumericUpDownAmount.Size = new Size(115, 27);
            NumericUpDownAmount.TabIndex = 23;
            NumericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ColumnHeaderName, ColumnHeaderID, ColumnHeaderAmount });
            listView1.Location = new Point(609, 136);
            listView1.Name = "listView1";
            listView1.Size = new Size(302, 245);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(listView1);
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
            Controls.Add(ListBoxBuyProducts);
            Controls.Add(LabelPayMethod);
            Controls.Add(ComboBoxTransactionMethod);
            Controls.Add(LabelDiscount);
            Controls.Add(ComboBoxDiscount);
            Controls.Add(TextBoxPrice);
            Margin = new Padding(3, 4, 3, 4);
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
        private ErrorProvider ErrorProviderAddProductByID;
        private Label LabelAmount;
        private NumericUpDown NumericUpDownAmount;
        private ListView listView1;
        private ColumnHeader ColumnHeaderName;
        private ColumnHeader ColumnHeaderID;
        private ColumnHeader ColumnHeaderAmount;
        private ErrorProvider ErrorProviderAmount;
    }
}