namespace CourseWorkWF
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
            textBoxPrice = new TextBox();
            comboBoxDiscount = new ComboBox();
            labelDiscount = new Label();
            labelPayMethod = new Label();
            comboBoxTransactionMethod = new ComboBox();
            labelProductID = new Label();
            textBoxCashierName = new TextBox();
            labelCashierName = new Label();
            buttonAddProduct = new Button();
            buttonSell = new Button();
            textBoxRevenue = new TextBox();
            labelRevenue = new Label();
            buttonCancelDiscount = new Button();
            textBoxMoneyChangeBuyer = new TextBox();
            labelCash = new Label();
            labelMoneyChangeBuyer = new Label();
            numericUpDownProductID = new NumericUpDown();
            numericUpDownCash = new NumericUpDown();
            ErrorProviderAddProductByID = new ErrorProvider(components);
            labelAmount = new Label();
            numericUpDownAmount = new NumericUpDown();
            listViewBuyProducts = new ListView();
            ColumnHeaderName = new ColumnHeader();
            ColumnHeaderID = new ColumnHeader();
            ColumnHeaderPrice = new ColumnHeader();
            ColumnHeaderAmount = new ColumnHeader();
            ErrorProviderAmount = new ErrorProvider(components);
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderAddProductByID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderAmount).BeginInit();
            SuspendLayout();
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(551, 480);
            textBoxPrice.Margin = new Padding(3, 4, 3, 4);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(172, 27);
            textBoxPrice.TabIndex = 0;
            textBoxPrice.Text = "0";
            // 
            // comboBoxDiscount
            // 
            comboBoxDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiscount.Enabled = false;
            comboBoxDiscount.FormattingEnabled = true;
            comboBoxDiscount.Items.AddRange(new object[] { "0", "5 ", "10 ", "15 ", "20 ", "25 " });
            comboBoxDiscount.Location = new Point(14, 261);
            comboBoxDiscount.Margin = new Padding(3, 4, 3, 4);
            comboBoxDiscount.Name = "comboBoxDiscount";
            comboBoxDiscount.Size = new Size(138, 28);
            comboBoxDiscount.TabIndex = 1;
            comboBoxDiscount.UseWaitCursor = true;
            comboBoxDiscount.SelectedIndexChanged += ComboBoxDiscount_SelectedIndexChanged;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(14, 237);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(57, 20);
            labelDiscount.TabIndex = 2;
            labelDiscount.Text = "Скидка";
            // 
            // labelPayMethod
            // 
            labelPayMethod.AutoSize = true;
            labelPayMethod.Location = new Point(159, 237);
            labelPayMethod.Name = "labelPayMethod";
            labelPayMethod.Size = new Size(116, 20);
            labelPayMethod.TabIndex = 4;
            labelPayMethod.Text = "Способ оплаты";
            // 
            // comboBoxTransactionMethod
            // 
            comboBoxTransactionMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransactionMethod.Enabled = false;
            comboBoxTransactionMethod.FormattingEnabled = true;
            comboBoxTransactionMethod.Items.AddRange(new object[] { "Наличные", "Карта" });
            comboBoxTransactionMethod.Location = new Point(159, 261);
            comboBoxTransactionMethod.Margin = new Padding(3, 4, 3, 4);
            comboBoxTransactionMethod.Name = "comboBoxTransactionMethod";
            comboBoxTransactionMethod.Size = new Size(138, 28);
            comboBoxTransactionMethod.TabIndex = 3;
            comboBoxTransactionMethod.UseWaitCursor = true;
            comboBoxTransactionMethod.SelectedIndexChanged += ComboBoxTransactionMethod_SelectedIndexChanged;
            // 
            // labelProductID
            // 
            labelProductID.AutoSize = true;
            labelProductID.Location = new Point(794, 12);
            labelProductID.Name = "labelProductID";
            labelProductID.Size = new Size(76, 20);
            labelProductID.TabIndex = 6;
            labelProductID.Text = "ID товара";
            // 
            // textBoxCashierName
            // 
            textBoxCashierName.Location = new Point(14, 553);
            textBoxCashierName.Margin = new Padding(3, 4, 3, 4);
            textBoxCashierName.Name = "textBoxCashierName";
            textBoxCashierName.ReadOnly = true;
            textBoxCashierName.Size = new Size(251, 27);
            textBoxCashierName.TabIndex = 8;
            textBoxCashierName.Text = "Елена Васильевна";
            // 
            // labelCashierName
            // 
            labelCashierName.AutoSize = true;
            labelCashierName.Location = new Point(14, 529);
            labelCashierName.Name = "labelCashierName";
            labelCashierName.Size = new Size(58, 20);
            labelCashierName.TabIndex = 9;
            labelCashierName.Text = "Кассир";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(915, 36);
            buttonAddProduct.Margin = new Padding(3, 4, 3, 4);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(97, 83);
            buttonAddProduct.TabIndex = 10;
            buttonAddProduct.Text = "Добавить";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += ButtonAddProduct_Click;
            // 
            // buttonSell
            // 
            buttonSell.BackColor = SystemColors.ControlLight;
            buttonSell.Enabled = false;
            buttonSell.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSell.Location = new Point(551, 519);
            buttonSell.Margin = new Padding(3, 4, 3, 4);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(463, 65);
            buttonSell.TabIndex = 11;
            buttonSell.Text = "ПРОДАТЬ";
            buttonSell.UseVisualStyleBackColor = false;
            buttonSell.Click += ButtonSell_Click;
            // 
            // textBoxRevenue
            // 
            textBoxRevenue.Location = new Point(144, 13);
            textBoxRevenue.Margin = new Padding(3, 4, 3, 4);
            textBoxRevenue.Name = "textBoxRevenue";
            textBoxRevenue.ReadOnly = true;
            textBoxRevenue.Size = new Size(114, 27);
            textBoxRevenue.TabIndex = 13;
            textBoxRevenue.Text = "0";
            // 
            // labelRevenue
            // 
            labelRevenue.AutoSize = true;
            labelRevenue.Location = new Point(14, 16);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(124, 20);
            labelRevenue.TabIndex = 14;
            labelRevenue.Text = "Выручка за день";
            // 
            // buttonCancelDiscount
            // 
            buttonCancelDiscount.Enabled = false;
            buttonCancelDiscount.Location = new Point(14, 300);
            buttonCancelDiscount.Margin = new Padding(3, 4, 3, 4);
            buttonCancelDiscount.Name = "buttonCancelDiscount";
            buttonCancelDiscount.Size = new Size(138, 61);
            buttonCancelDiscount.TabIndex = 15;
            buttonCancelDiscount.Text = "Отменить скидку";
            buttonCancelDiscount.UseVisualStyleBackColor = true;
            buttonCancelDiscount.Click += ButtonCancelDiscount_Click;
            // 
            // textBoxMoneyChangeBuyer
            // 
            textBoxMoneyChangeBuyer.Location = new Point(159, 389);
            textBoxMoneyChangeBuyer.Margin = new Padding(3, 4, 3, 4);
            textBoxMoneyChangeBuyer.Name = "textBoxMoneyChangeBuyer";
            textBoxMoneyChangeBuyer.ReadOnly = true;
            textBoxMoneyChangeBuyer.Size = new Size(114, 27);
            textBoxMoneyChangeBuyer.TabIndex = 17;
            textBoxMoneyChangeBuyer.Visible = false;
            // 
            // labelCash
            // 
            labelCash.AutoSize = true;
            labelCash.Location = new Point(159, 307);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(81, 20);
            labelCash.TabIndex = 18;
            labelCash.Text = "Наличные";
            labelCash.Visible = false;
            // 
            // labelMoneyChangeBuyer
            // 
            labelMoneyChangeBuyer.AutoSize = true;
            labelMoneyChangeBuyer.Location = new Point(159, 365);
            labelMoneyChangeBuyer.Name = "labelMoneyChangeBuyer";
            labelMoneyChangeBuyer.Size = new Size(50, 20);
            labelMoneyChangeBuyer.TabIndex = 19;
            labelMoneyChangeBuyer.Text = "Сдача";
            labelMoneyChangeBuyer.Visible = false;
            // 
            // numericUpDownProductID
            // 
            numericUpDownProductID.Location = new Point(794, 36);
            numericUpDownProductID.Margin = new Padding(3, 4, 3, 4);
            numericUpDownProductID.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownProductID.Name = "numericUpDownProductID";
            numericUpDownProductID.Size = new Size(114, 27);
            numericUpDownProductID.TabIndex = 20;
            numericUpDownProductID.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownCash
            // 
            numericUpDownCash.Location = new Point(160, 331);
            numericUpDownCash.Margin = new Padding(3, 4, 3, 4);
            numericUpDownCash.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownCash.Name = "numericUpDownCash";
            numericUpDownCash.Size = new Size(113, 27);
            numericUpDownCash.TabIndex = 21;
            numericUpDownCash.Visible = false;
            numericUpDownCash.ValueChanged += NumericUpDownCash_ValueChanged;
            // 
            // ErrorProviderAddProductByID
            // 
            ErrorProviderAddProductByID.ContainerControl = this;
            ErrorProviderAddProductByID.RightToLeft = true;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(794, 67);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(90, 20);
            labelAmount.TabIndex = 22;
            labelAmount.Text = "Количество";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(794, 91);
            numericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(115, 27);
            numericUpDownAmount.TabIndex = 23;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listViewBuyProducts
            // 
            listViewBuyProducts.Columns.AddRange(new ColumnHeader[] { ColumnHeaderName, ColumnHeaderID, ColumnHeaderPrice, ColumnHeaderAmount });
            listViewBuyProducts.Location = new Point(551, 135);
            listViewBuyProducts.Name = "listViewBuyProducts";
            listViewBuyProducts.Size = new Size(461, 337);
            listViewBuyProducts.TabIndex = 24;
            listViewBuyProducts.UseCompatibleStateImageBehavior = false;
            listViewBuyProducts.View = View.Details;
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
            // ColumnHeaderPrice
            // 
            ColumnHeaderPrice.Text = "Цена 1 ед.";
            ColumnHeaderPrice.Width = 100;
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
            // buttonCancel
            // 
            buttonCancel.Location = new Point(14, 68);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(111, 71);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // CashierARM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1026, 600);
            Controls.Add(buttonCancel);
            Controls.Add(listViewBuyProducts);
            Controls.Add(numericUpDownAmount);
            Controls.Add(labelAmount);
            Controls.Add(numericUpDownCash);
            Controls.Add(numericUpDownProductID);
            Controls.Add(labelMoneyChangeBuyer);
            Controls.Add(labelCash);
            Controls.Add(textBoxMoneyChangeBuyer);
            Controls.Add(buttonCancelDiscount);
            Controls.Add(labelRevenue);
            Controls.Add(textBoxRevenue);
            Controls.Add(buttonSell);
            Controls.Add(buttonAddProduct);
            Controls.Add(labelCashierName);
            Controls.Add(textBoxCashierName);
            Controls.Add(labelProductID);
            Controls.Add(labelPayMethod);
            Controls.Add(comboBoxTransactionMethod);
            Controls.Add(labelDiscount);
            Controls.Add(comboBoxDiscount);
            Controls.Add(textBoxPrice);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CashierARM";
            Text = "CashierARM";
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCash).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderAddProductByID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrice;
        private ComboBox comboBoxDiscount;
        private Label labelDiscount;
        private Label labelPayMethod;
        private ComboBox comboBoxTransactionMethod;
        private Label labelProductID;
        private TextBox textBoxCashierName;
        private Label labelCashierName;
        private Button buttonAddProduct;
        private Button buttonSell;
        private TextBox textBoxRevenue;
        private Label labelRevenue;
        private Button buttonCancelDiscount;
        private TextBox textBoxMoneyChangeBuyer;
        private Label labelCash;
        private Label labelMoneyChangeBuyer;
        private NumericUpDown numericUpDownProductID;
        private NumericUpDown numericUpDownCash;
        private ErrorProvider ErrorProviderAddProductByID;
        private Label labelAmount;
        private NumericUpDown numericUpDownAmount;
        private ListView listViewBuyProducts;
        private ColumnHeader ColumnHeaderName;
        private ColumnHeader ColumnHeaderID;
        private ColumnHeader ColumnHeaderAmount;
        private ErrorProvider ErrorProviderAmount;
        private Button buttonCancel;
        private ColumnHeader ColumnHeaderPrice;
    }
}