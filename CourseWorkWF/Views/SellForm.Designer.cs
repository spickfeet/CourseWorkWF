namespace CourseWorkWF.Views
{
    partial class SellForm
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
            comboBoxOperationMethod = new ComboBox();
            labelProductID = new Label();
            textBoxCashierName = new TextBox();
            labelCashierName = new Label();
            buttonAddProduct = new Button();
            buttonSell = new Button();
            textBoxRevenue = new TextBox();
            labelRevenue = new Label();
            textBoxMoneyChangeBuyer = new TextBox();
            labelCash = new Label();
            labelMoneyChangeBuyer = new Label();
            numericUpDownCash = new NumericUpDown();
            errorProviderProductID = new ErrorProvider(components);
            labelAmount = new Label();
            numericUpDownAmount = new NumericUpDown();
            listViewBuyProducts = new ListView();
            ColumnHeaderName = new ColumnHeader();
            ColumnHeaderID = new ColumnHeader();
            ColumnHeaderPrice = new ColumnHeader();
            ColumnHeaderAmount = new ColumnHeader();
            errorProviderAmount = new ErrorProvider(components);
            buttonCancel = new Button();
            textBoxProductID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAmount).BeginInit();
            SuspendLayout();
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(482, 360);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(151, 23);
            textBoxPrice.TabIndex = 0;
            textBoxPrice.Text = "0";
            // 
            // comboBoxDiscount
            // 
            comboBoxDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiscount.Enabled = false;
            comboBoxDiscount.FormattingEnabled = true;
            comboBoxDiscount.Items.AddRange(new object[] { "0", "5 ", "10 ", "15 ", "20 ", "25 " });
            comboBoxDiscount.Location = new Point(12, 196);
            comboBoxDiscount.Name = "comboBoxDiscount";
            comboBoxDiscount.Size = new Size(121, 23);
            comboBoxDiscount.TabIndex = 1;
            comboBoxDiscount.UseWaitCursor = true;
            comboBoxDiscount.SelectedIndexChanged += ComboBoxDiscount_SelectedIndexChanged;
            // 
            // labelDiscount
            // 
            labelDiscount.AutoSize = true;
            labelDiscount.Location = new Point(12, 178);
            labelDiscount.Name = "labelDiscount";
            labelDiscount.Size = new Size(46, 15);
            labelDiscount.TabIndex = 2;
            labelDiscount.Text = "Скидка";
            // 
            // labelPayMethod
            // 
            labelPayMethod.AutoSize = true;
            labelPayMethod.Location = new Point(139, 178);
            labelPayMethod.Name = "labelPayMethod";
            labelPayMethod.Size = new Size(93, 15);
            labelPayMethod.TabIndex = 4;
            labelPayMethod.Text = "Способ оплаты";
            // 
            // comboBoxOperationMethod
            // 
            comboBoxOperationMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperationMethod.Enabled = false;
            comboBoxOperationMethod.FormattingEnabled = true;
            comboBoxOperationMethod.Items.AddRange(new object[] { "Наличные", "Карта" });
            comboBoxOperationMethod.Location = new Point(139, 196);
            comboBoxOperationMethod.Name = "comboBoxOperationMethod";
            comboBoxOperationMethod.Size = new Size(121, 23);
            comboBoxOperationMethod.TabIndex = 3;
            comboBoxOperationMethod.UseWaitCursor = true;
            comboBoxOperationMethod.SelectedIndexChanged += ComboBoxTransactionMethod_SelectedIndexChanged;
            // 
            // labelProductID
            // 
            labelProductID.AutoSize = true;
            labelProductID.Location = new Point(695, 9);
            labelProductID.Name = "labelProductID";
            labelProductID.Size = new Size(58, 15);
            labelProductID.TabIndex = 6;
            labelProductID.Text = "ID товара";
            // 
            // textBoxCashierName
            // 
            textBoxCashierName.Location = new Point(12, 415);
            textBoxCashierName.Name = "textBoxCashierName";
            textBoxCashierName.ReadOnly = true;
            textBoxCashierName.Size = new Size(220, 23);
            textBoxCashierName.TabIndex = 8;
            textBoxCashierName.Text = "Елена Васильевна";
            // 
            // labelCashierName
            // 
            labelCashierName.AutoSize = true;
            labelCashierName.Location = new Point(12, 397);
            labelCashierName.Name = "labelCashierName";
            labelCashierName.Size = new Size(46, 15);
            labelCashierName.TabIndex = 9;
            labelCashierName.Text = "Кассир";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(801, 27);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(85, 62);
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
            buttonSell.Location = new Point(482, 389);
            buttonSell.Name = "buttonSell";
            buttonSell.Size = new Size(405, 49);
            buttonSell.TabIndex = 11;
            buttonSell.Text = "ПРОДАТЬ";
            buttonSell.UseVisualStyleBackColor = false;
            buttonSell.Click += ButtonSell_Click;
            // 
            // textBoxRevenue
            // 
            textBoxRevenue.Location = new Point(126, 10);
            textBoxRevenue.Name = "textBoxRevenue";
            textBoxRevenue.ReadOnly = true;
            textBoxRevenue.Size = new Size(100, 23);
            textBoxRevenue.TabIndex = 13;
            textBoxRevenue.Text = "0";
            // 
            // labelRevenue
            // 
            labelRevenue.AutoSize = true;
            labelRevenue.Location = new Point(12, 12);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(97, 15);
            labelRevenue.TabIndex = 14;
            labelRevenue.Text = "Выручка за день";
            // 
            // textBoxMoneyChangeBuyer
            // 
            textBoxMoneyChangeBuyer.Location = new Point(139, 292);
            textBoxMoneyChangeBuyer.Name = "textBoxMoneyChangeBuyer";
            textBoxMoneyChangeBuyer.ReadOnly = true;
            textBoxMoneyChangeBuyer.Size = new Size(100, 23);
            textBoxMoneyChangeBuyer.TabIndex = 17;
            textBoxMoneyChangeBuyer.Visible = false;
            // 
            // labelCash
            // 
            labelCash.AutoSize = true;
            labelCash.Location = new Point(139, 230);
            labelCash.Name = "labelCash";
            labelCash.Size = new Size(65, 15);
            labelCash.TabIndex = 18;
            labelCash.Text = "Наличные";
            labelCash.Visible = false;
            // 
            // labelMoneyChangeBuyer
            // 
            labelMoneyChangeBuyer.AutoSize = true;
            labelMoneyChangeBuyer.Location = new Point(139, 274);
            labelMoneyChangeBuyer.Name = "labelMoneyChangeBuyer";
            labelMoneyChangeBuyer.Size = new Size(40, 15);
            labelMoneyChangeBuyer.TabIndex = 19;
            labelMoneyChangeBuyer.Text = "Сдача";
            labelMoneyChangeBuyer.Visible = false;
            // 
            // numericUpDownCash
            // 
            numericUpDownCash.Location = new Point(140, 248);
            numericUpDownCash.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownCash.Name = "numericUpDownCash";
            numericUpDownCash.Size = new Size(99, 23);
            numericUpDownCash.TabIndex = 21;
            numericUpDownCash.Visible = false;
            numericUpDownCash.ValueChanged += NumericUpDownCash_ValueChanged;
            // 
            // errorProviderProductID
            // 
            errorProviderProductID.ContainerControl = this;
            errorProviderProductID.RightToLeft = true;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(695, 50);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(72, 15);
            labelAmount.TabIndex = 22;
            labelAmount.Text = "Количество";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 3;
            numericUpDownAmount.Location = new Point(695, 68);
            numericUpDownAmount.Margin = new Padding(3, 2, 3, 2);
            numericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(101, 23);
            numericUpDownAmount.TabIndex = 23;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // listViewBuyProducts
            // 
            listViewBuyProducts.Columns.AddRange(new ColumnHeader[] { ColumnHeaderName, ColumnHeaderID, ColumnHeaderPrice, ColumnHeaderAmount });
            listViewBuyProducts.Location = new Point(482, 101);
            listViewBuyProducts.Margin = new Padding(3, 2, 3, 2);
            listViewBuyProducts.Name = "listViewBuyProducts";
            listViewBuyProducts.Size = new Size(404, 254);
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
            // errorProviderAmount
            // 
            errorProviderAmount.ContainerControl = this;
            errorProviderAmount.RightToLeft = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(12, 51);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(97, 53);
            buttonCancel.TabIndex = 25;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // textBoxProductID
            // 
            textBoxProductID.Location = new Point(695, 27);
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.Size = new Size(100, 23);
            textBoxProductID.TabIndex = 26;
            textBoxProductID.KeyPress += TextBoxNumerical_KeyPressNotNumber;
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(898, 450);
            Controls.Add(textBoxProductID);
            Controls.Add(buttonCancel);
            Controls.Add(listViewBuyProducts);
            Controls.Add(numericUpDownAmount);
            Controls.Add(labelAmount);
            Controls.Add(numericUpDownCash);
            Controls.Add(labelMoneyChangeBuyer);
            Controls.Add(labelCash);
            Controls.Add(textBoxMoneyChangeBuyer);
            Controls.Add(labelRevenue);
            Controls.Add(textBoxRevenue);
            Controls.Add(buttonSell);
            Controls.Add(buttonAddProduct);
            Controls.Add(labelCashierName);
            Controls.Add(textBoxCashierName);
            Controls.Add(labelProductID);
            Controls.Add(labelPayMethod);
            Controls.Add(comboBoxOperationMethod);
            Controls.Add(labelDiscount);
            Controls.Add(comboBoxDiscount);
            Controls.Add(textBoxPrice);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SellForm";
            Text = "CashierARM";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCash).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPrice;
        private ComboBox comboBoxDiscount;
        private Label labelDiscount;
        private Label labelPayMethod;
        private ComboBox comboBoxOperationMethod;
        private Label labelProductID;
        private TextBox textBoxCashierName;
        private Label labelCashierName;
        private Button buttonAddProduct;
        private Button buttonSell;
        private TextBox textBoxRevenue;
        private Label labelRevenue;
        private TextBox textBoxMoneyChangeBuyer;
        private Label labelCash;
        private Label labelMoneyChangeBuyer;
        private NumericUpDown numericUpDownCash;
        private ErrorProvider errorProviderProductID;
        private Label labelAmount;
        private NumericUpDown numericUpDownAmount;
        private ListView listViewBuyProducts;
        private ColumnHeader ColumnHeaderName;
        private ColumnHeader ColumnHeaderID;
        private ColumnHeader ColumnHeaderAmount;
        private ErrorProvider errorProviderAmount;
        private Button buttonCancel;
        private ColumnHeader ColumnHeaderPrice;
        private TextBox textBoxProductID;
    }
}