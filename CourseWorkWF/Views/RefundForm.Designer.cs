namespace CourseWorkWF.Views
{
    partial class RefundForm
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
            listViewSeles = new ListView();
            columnHeaderNumber = new ColumnHeader();
            columnHeaderPrice = new ColumnHeader();
            columnHeaderDate = new ColumnHeader();
            richTextBoxSellInfo = new RichTextBox();
            dateTimePickerToDate = new DateTimePicker();
            buttonFind = new Button();
            buttonInfo = new Button();
            richTextBoxReason = new RichTextBox();
            listViewRefundList = new ListView();
            columnHeaderRefundProductID = new ColumnHeader();
            columnHeaderRefundProductName = new ColumnHeader();
            columnHeadercolumnHeaderRefundProductUnitPrice = new ColumnHeader();
            columnHeaderRefundAmount = new ColumnHeader();
            labelSeles = new Label();
            labelSellInfo = new Label();
            labelReason = new Label();
            labelProductsRefundList = new Label();
            buttonRefund = new Button();
            labelReceiptNumber = new Label();
            buttonAddProductRefundList = new Button();
            comboBoxOperationMethod = new ComboBox();
            labelOperationMethod = new Label();
            dateTimePickerFromDate = new DateTimePicker();
            labelFromDate = new Label();
            labelToDate = new Label();
            checkBoxFindByDate = new CheckBox();
            textBoxReceiptNumber = new TextBox();
            errorProviderNumber = new ErrorProvider(components);
            listViewBuyList = new ListView();
            columnHeaderProductID = new ColumnHeader();
            columnHeaderProductName = new ColumnHeader();
            columnHeaderProductUnitPrice = new ColumnHeader();
            columnHeaderAmount = new ColumnHeader();
            labelBuyList = new Label();
            labelProductID = new Label();
            textBoxProductID = new TextBox();
            numericUpDownAmount = new NumericUpDown();
            labelAmount = new Label();
            errorProviderAmount = new ErrorProvider(components);
            errorProviderProductID = new ErrorProvider(components);
            errorProviderSellInfo = new ErrorProvider(components);
            errorProviderReason = new ErrorProvider(components);
            errorProviderOperationMethod = new ErrorProvider(components);
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProviderNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSellInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderReason).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderOperationMethod).BeginInit();
            SuspendLayout();
            // 
            // listViewSeles
            // 
            listViewSeles.Columns.AddRange(new ColumnHeader[] { columnHeaderNumber, columnHeaderPrice, columnHeaderDate });
            listViewSeles.Location = new Point(173, 24);
            listViewSeles.Margin = new Padding(3, 2, 3, 2);
            listViewSeles.MultiSelect = false;
            listViewSeles.Name = "listViewSeles";
            listViewSeles.Size = new Size(245, 176);
            listViewSeles.TabIndex = 1;
            listViewSeles.UseCompatibleStateImageBehavior = false;
            listViewSeles.View = View.Details;
            // 
            // columnHeaderNumber
            // 
            columnHeaderNumber.Text = "Номер";
            // 
            // columnHeaderPrice
            // 
            columnHeaderPrice.Text = "Цена";
            columnHeaderPrice.Width = 100;
            // 
            // columnHeaderDate
            // 
            columnHeaderDate.Text = "Дата";
            columnHeaderDate.Width = 160;
            // 
            // richTextBoxSellInfo
            // 
            richTextBoxSellInfo.Location = new Point(424, 25);
            richTextBoxSellInfo.Margin = new Padding(3, 2, 3, 2);
            richTextBoxSellInfo.Name = "richTextBoxSellInfo";
            richTextBoxSellInfo.ReadOnly = true;
            richTextBoxSellInfo.Size = new Size(206, 176);
            richTextBoxSellInfo.TabIndex = 2;
            richTextBoxSellInfo.Text = "";
            // 
            // dateTimePickerToDate
            // 
            dateTimePickerToDate.Location = new Point(10, 135);
            dateTimePickerToDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerToDate.Name = "dateTimePickerToDate";
            dateTimePickerToDate.Size = new Size(156, 23);
            dateTimePickerToDate.TabIndex = 3;
            dateTimePickerToDate.Visible = false;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.OliveDrab;
            buttonFind.Location = new Point(10, 74);
            buttonFind.Margin = new Padding(3, 2, 3, 2);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(156, 22);
            buttonFind.TabIndex = 4;
            buttonFind.Text = "Найти чек";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += ButtonFind_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.OliveDrab;
            buttonInfo.Location = new Point(173, 204);
            buttonInfo.Margin = new Padding(3, 2, 3, 2);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(245, 47);
            buttonInfo.TabIndex = 5;
            buttonInfo.Text = "Получить информацию о чеке";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += ButtonInfo_Click;
            // 
            // richTextBoxReason
            // 
            richTextBoxReason.Location = new Point(1254, 24);
            richTextBoxReason.Margin = new Padding(3, 2, 3, 2);
            richTextBoxReason.Name = "richTextBoxReason";
            richTextBoxReason.Size = new Size(168, 176);
            richTextBoxReason.TabIndex = 6;
            richTextBoxReason.Text = "";
            // 
            // listViewRefundList
            // 
            listViewRefundList.Columns.AddRange(new ColumnHeader[] { columnHeaderRefundProductID, columnHeaderRefundProductName, columnHeadercolumnHeaderRefundProductUnitPrice, columnHeaderRefundAmount });
            listViewRefundList.Location = new Point(1005, 25);
            listViewRefundList.Margin = new Padding(3, 2, 3, 2);
            listViewRefundList.Name = "listViewRefundList";
            listViewRefundList.Size = new Size(243, 176);
            listViewRefundList.TabIndex = 8;
            listViewRefundList.UseCompatibleStateImageBehavior = false;
            listViewRefundList.View = View.Details;
            // 
            // columnHeaderRefundProductID
            // 
            columnHeaderRefundProductID.Text = "ID";
            // 
            // columnHeaderRefundProductName
            // 
            columnHeaderRefundProductName.Text = "Товар";
            // 
            // columnHeadercolumnHeaderRefundProductUnitPrice
            // 
            columnHeadercolumnHeaderRefundProductUnitPrice.Text = "Цена за еденицу";
            // 
            // columnHeaderRefundAmount
            // 
            columnHeaderRefundAmount.Text = "Колличество";
            // 
            // labelSeles
            // 
            labelSeles.AutoSize = true;
            labelSeles.Location = new Point(173, 7);
            labelSeles.Name = "labelSeles";
            labelSeles.Size = new Size(99, 15);
            labelSeles.TabIndex = 9;
            labelSeles.Text = "История продаж";
            // 
            // labelSellInfo
            // 
            labelSellInfo.AutoSize = true;
            labelSellInfo.Location = new Point(424, 8);
            labelSellInfo.Name = "labelSellInfo";
            labelSellInfo.Size = new Size(142, 15);
            labelSellInfo.TabIndex = 10;
            labelSellInfo.Text = "Информация о продаже";
            // 
            // labelReason
            // 
            labelReason.AutoSize = true;
            labelReason.Location = new Point(1254, 7);
            labelReason.Name = "labelReason";
            labelReason.Size = new Size(108, 15);
            labelReason.TabIndex = 11;
            labelReason.Text = "Причина возврата";
            // 
            // labelProductsRefundList
            // 
            labelProductsRefundList.AutoSize = true;
            labelProductsRefundList.Location = new Point(1005, 8);
            labelProductsRefundList.Name = "labelProductsRefundList";
            labelProductsRefundList.Size = new Size(168, 15);
            labelProductsRefundList.TabIndex = 13;
            labelProductsRefundList.Text = "Список товаров для возврата";
            // 
            // buttonRefund
            // 
            buttonRefund.BackColor = Color.OliveDrab;
            buttonRefund.Location = new Point(1254, 247);
            buttonRefund.Margin = new Padding(3, 2, 3, 2);
            buttonRefund.Name = "buttonRefund";
            buttonRefund.Size = new Size(167, 47);
            buttonRefund.TabIndex = 14;
            buttonRefund.Text = "Вернуть деньги";
            buttonRefund.UseVisualStyleBackColor = false;
            buttonRefund.Click += ButtonRefund_Click;
            // 
            // labelReceiptNumber
            // 
            labelReceiptNumber.AutoSize = true;
            labelReceiptNumber.Location = new Point(10, 7);
            labelReceiptNumber.Name = "labelReceiptNumber";
            labelReceiptNumber.Size = new Size(73, 15);
            labelReceiptNumber.TabIndex = 16;
            labelReceiptNumber.Text = "Номер чека";
            // 
            // buttonAddProductRefundList
            // 
            buttonAddProductRefundList.BackColor = Color.OliveDrab;
            buttonAddProductRefundList.Location = new Point(636, 289);
            buttonAddProductRefundList.Margin = new Padding(3, 2, 3, 2);
            buttonAddProductRefundList.Name = "buttonAddProductRefundList";
            buttonAddProductRefundList.Size = new Size(188, 47);
            buttonAddProductRefundList.TabIndex = 18;
            buttonAddProductRefundList.Text = "Добавить продукт в список для возврата";
            buttonAddProductRefundList.UseVisualStyleBackColor = false;
            buttonAddProductRefundList.Click += ButtonAddProductRefundList_Click;
            // 
            // comboBoxOperationMethod
            // 
            comboBoxOperationMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOperationMethod.FormattingEnabled = true;
            comboBoxOperationMethod.Items.AddRange(new object[] { "Карта", "Наличные" });
            comboBoxOperationMethod.Location = new Point(1254, 221);
            comboBoxOperationMethod.Margin = new Padding(3, 2, 3, 2);
            comboBoxOperationMethod.Name = "comboBoxOperationMethod";
            comboBoxOperationMethod.Size = new Size(168, 23);
            comboBoxOperationMethod.TabIndex = 20;
            // 
            // labelOperationMethod
            // 
            labelOperationMethod.AutoSize = true;
            labelOperationMethod.Location = new Point(1251, 204);
            labelOperationMethod.Name = "labelOperationMethod";
            labelOperationMethod.Size = new Size(133, 15);
            labelOperationMethod.TabIndex = 21;
            labelOperationMethod.Text = "Способ возврата денег";
            // 
            // dateTimePickerFromDate
            // 
            dateTimePickerFromDate.Location = new Point(10, 92);
            dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            dateTimePickerFromDate.Size = new Size(156, 23);
            dateTimePickerFromDate.TabIndex = 22;
            dateTimePickerFromDate.Visible = false;
            // 
            // labelFromDate
            // 
            labelFromDate.AutoSize = true;
            labelFromDate.Location = new Point(10, 74);
            labelFromDate.Name = "labelFromDate";
            labelFromDate.Size = new Size(51, 15);
            labelFromDate.TabIndex = 23;
            labelFromDate.Text = "С какго ";
            labelFromDate.Visible = false;
            // 
            // labelToDate
            // 
            labelToDate.AutoSize = true;
            labelToDate.Location = new Point(10, 118);
            labelToDate.Name = "labelToDate";
            labelToDate.Size = new Size(57, 15);
            labelToDate.TabIndex = 24;
            labelToDate.Text = "По какое";
            labelToDate.Visible = false;
            // 
            // checkBoxFindByDate
            // 
            checkBoxFindByDate.AutoSize = true;
            checkBoxFindByDate.Location = new Point(10, 52);
            checkBoxFindByDate.Name = "checkBoxFindByDate";
            checkBoxFindByDate.Size = new Size(103, 19);
            checkBoxFindByDate.TabIndex = 25;
            checkBoxFindByDate.Text = "Найти по дате";
            checkBoxFindByDate.UseVisualStyleBackColor = true;
            checkBoxFindByDate.CheckedChanged += CheckBoxFindByDate_CheckedChanged;
            // 
            // textBoxReceiptNumber
            // 
            textBoxReceiptNumber.Location = new Point(10, 25);
            textBoxReceiptNumber.Name = "textBoxReceiptNumber";
            textBoxReceiptNumber.Size = new Size(156, 23);
            textBoxReceiptNumber.TabIndex = 27;
            textBoxReceiptNumber.KeyPress += TextBoxNumerical_KeyPressNotNumber;
            // 
            // errorProviderNumber
            // 
            errorProviderNumber.ContainerControl = this;
            // 
            // listViewBuyList
            // 
            listViewBuyList.Columns.AddRange(new ColumnHeader[] { columnHeaderProductID, columnHeaderProductName, columnHeaderProductUnitPrice, columnHeaderAmount });
            listViewBuyList.Location = new Point(636, 24);
            listViewBuyList.Name = "listViewBuyList";
            listViewBuyList.Size = new Size(363, 176);
            listViewBuyList.TabIndex = 28;
            listViewBuyList.UseCompatibleStateImageBehavior = false;
            listViewBuyList.View = View.Details;
            // 
            // columnHeaderProductID
            // 
            columnHeaderProductID.Text = "ID";
            columnHeaderProductID.Width = 80;
            // 
            // columnHeaderProductName
            // 
            columnHeaderProductName.Text = "Товар";
            columnHeaderProductName.Width = 100;
            // 
            // columnHeaderProductUnitPrice
            // 
            columnHeaderProductUnitPrice.Text = "Цена за еденицу";
            columnHeaderProductUnitPrice.Width = 120;
            // 
            // columnHeaderAmount
            // 
            columnHeaderAmount.Text = "Колличество";
            // 
            // labelBuyList
            // 
            labelBuyList.AutoSize = true;
            labelBuyList.Location = new Point(636, 6);
            labelBuyList.Name = "labelBuyList";
            labelBuyList.Size = new Size(97, 15);
            labelBuyList.TabIndex = 29;
            labelBuyList.Text = "Список покупок";
            // 
            // labelProductID
            // 
            labelProductID.AutoSize = true;
            labelProductID.Location = new Point(636, 200);
            labelProductID.Name = "labelProductID";
            labelProductID.Size = new Size(74, 15);
            labelProductID.TabIndex = 19;
            labelProductID.Text = "ID продукта ";
            // 
            // textBoxProductID
            // 
            textBoxProductID.Location = new Point(636, 217);
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.Size = new Size(189, 23);
            textBoxProductID.TabIndex = 26;
            textBoxProductID.KeyPress += TextBoxNumerical_KeyPressNotNumber;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(636, 261);
            numericUpDownAmount.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(188, 23);
            numericUpDownAmount.TabIndex = 30;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(636, 243);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(79, 15);
            labelAmount.TabIndex = 31;
            labelAmount.Text = "Колличество";
            // 
            // errorProviderAmount
            // 
            errorProviderAmount.ContainerControl = this;
            // 
            // errorProviderProductID
            // 
            errorProviderProductID.ContainerControl = this;
            // 
            // errorProviderSellInfo
            // 
            errorProviderSellInfo.ContainerControl = this;
            // 
            // errorProviderReason
            // 
            errorProviderReason.ContainerControl = this;
            errorProviderReason.RightToLeft = true;
            // 
            // errorProviderOperationMethod
            // 
            errorProviderOperationMethod.ContainerControl = this;
            errorProviderOperationMethod.RightToLeft = true;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Location = new Point(12, 328);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(165, 71);
            buttonCancel.TabIndex = 32;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // RefundForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1432, 411);
            Controls.Add(buttonCancel);
            Controls.Add(labelAmount);
            Controls.Add(numericUpDownAmount);
            Controls.Add(labelBuyList);
            Controls.Add(listViewBuyList);
            Controls.Add(textBoxReceiptNumber);
            Controls.Add(textBoxProductID);
            Controls.Add(checkBoxFindByDate);
            Controls.Add(labelToDate);
            Controls.Add(labelFromDate);
            Controls.Add(dateTimePickerFromDate);
            Controls.Add(labelOperationMethod);
            Controls.Add(comboBoxOperationMethod);
            Controls.Add(labelProductID);
            Controls.Add(buttonAddProductRefundList);
            Controls.Add(labelReceiptNumber);
            Controls.Add(buttonRefund);
            Controls.Add(labelProductsRefundList);
            Controls.Add(labelReason);
            Controls.Add(labelSellInfo);
            Controls.Add(labelSeles);
            Controls.Add(listViewRefundList);
            Controls.Add(richTextBoxReason);
            Controls.Add(buttonInfo);
            Controls.Add(buttonFind);
            Controls.Add(dateTimePickerToDate);
            Controls.Add(richTextBoxSellInfo);
            Controls.Add(listViewSeles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RefundForm";
            Text = "MyARM";
            ((System.ComponentModel.ISupportInitialize)errorProviderNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSellInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderReason).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderOperationMethod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewSeles;
        private RichTextBox richTextBoxSellInfo;
        private DateTimePicker dateTimePickerToDate;
        private Button buttonFind;
        private Button buttonInfo;
        private RichTextBox richTextBoxReason;
        private ListView listViewRefundList;
        private Label labelSeles;
        private Label labelSellInfo;
        private Label labelReason;
        private Label labelProductsRefundList;
        private Button buttonRefund;
        private NumericUpDown numericUpDownAmount;
        private Label labelReceiptNumber;
        private Button buttonAddProductRefundList;
        private ComboBox comboBoxOperationMethod;
        private Label labelOperationMethod;
        private DateTimePicker dateTimePickerFromDate;
        private Label labelFromDate;
        private Label labelToDate;
        private CheckBox checkBoxFindByDate;
        private TextBox textBoxReceiptNumber;
        private ColumnHeader columnHeaderNumber;
        private ColumnHeader columnHeaderPrice;
        private ColumnHeader columnHeaderDate;
        private ErrorProvider errorProviderNumber;
        private ListView listViewBuyList;
        private Label labelBuyList;
        private TextBox textBoxProductID;
        private Label labelProductID;
        private ColumnHeader columnHeaderProductName;
        private ColumnHeader columnHeaderAmount;
        private ColumnHeader columnHeaderProductID;
        private ColumnHeader columnHeaderProductUnitPrice;
        private Label labelAmount;
        private ColumnHeader columnHeaderRefundProductID;
        private ColumnHeader columnHeaderRefundProductName;
        private ColumnHeader columnHeadercolumnHeaderRefundProductUnitPrice;
        private ColumnHeader columnHeaderRefundAmount;
        private ErrorProvider errorProviderAmount;
        private ErrorProvider errorProviderProductID;
        private ErrorProvider errorProviderSellInfo;
        private ErrorProvider errorProviderReason;
        private ErrorProvider errorProviderOperationMethod;
        private Button buttonCancel;
    }
}