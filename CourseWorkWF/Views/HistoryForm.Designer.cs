namespace CourseWorkWF.Views
{
    partial class HistoryForm
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
            listViewSelesInfo = new ListView();
            columnHeaderSellOperationNumber = new ColumnHeader();
            columnHeaderSellAmountMoney = new ColumnHeader();
            columnHeaderSellName = new ColumnHeader();
            columnHeaderSellSurname = new ColumnHeader();
            columnHeaderSellOperationType = new ColumnHeader();
            columnHeaderSellDate = new ColumnHeader();
            listViewRevenues = new ListView();
            columnHeaderRevenue = new ColumnHeader();
            columnHeaderRevenueDate = new ColumnHeader();
            listViewRefundsInfo = new ListView();
            columnHeaderRefundOperationNumber = new ColumnHeader();
            columnHeaderRefundAmountMoney = new ColumnHeader();
            columnHeaderRefundName = new ColumnHeader();
            columnHeaderRefundSurname = new ColumnHeader();
            columnHeaderRefundOperationType = new ColumnHeader();
            columnHeaderRefundDate = new ColumnHeader();
            dateTimePickerSellInfoDateFrom = new DateTimePicker();
            buttonFindSelesInfoByDate = new Button();
            buttonRefundsInfoDate = new Button();
            buttonRevenueInfoDate = new Button();
            dateTimePickerRefundInfoDateFrom = new DateTimePicker();
            dateTimePickerRevenueDateTo = new DateTimePicker();
            dateTimePickerRevenueDateFrom = new DateTimePicker();
            dateTimePickerRefundInfoDateTo = new DateTimePicker();
            dateTimePickerSellInfoDateTo = new DateTimePicker();
            labelSellInfoDateFrom = new Label();
            labelRefundInfoDateFrom = new Label();
            labelRevenueDateFrom = new Label();
            labelRevenueDateTo = new Label();
            labelRefundInfoDateTo = new Label();
            labelSellInfoDateTo = new Label();
            labelSell = new Label();
            labelRefund = new Label();
            labelRevenue = new Label();
            buttonGetSellInfo = new Button();
            listViewSellProducts = new ListView();
            columnHeaderSellProductID = new ColumnHeader();
            columnHeaderSellProductName = new ColumnHeader();
            columnHeaderSellProductPrice = new ColumnHeader();
            columnHeaderSellProductAmount = new ColumnHeader();
            listViewRefundProducts = new ListView();
            columnHeaderRefundProductID = new ColumnHeader();
            columnHeaderRefundproductName = new ColumnHeader();
            columnHeaderRefundProductPrice = new ColumnHeader();
            columnHeaderRefundProductAmount = new ColumnHeader();
            buttonGetRefundInfo = new Button();
            errorProviderSelectSellNumber = new ErrorProvider(components);
            errorProviderSelectRefundNumber = new ErrorProvider(components);
            richTextBoxReason = new RichTextBox();
            labelReason = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderSelectSellNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSelectRefundNumber).BeginInit();
            SuspendLayout();
            // 
            // listViewSelesInfo
            // 
            listViewSelesInfo.Columns.AddRange(new ColumnHeader[] { columnHeaderSellOperationNumber, columnHeaderSellAmountMoney, columnHeaderSellName, columnHeaderSellSurname, columnHeaderSellOperationType, columnHeaderSellDate });
            listViewSelesInfo.Location = new Point(14, 95);
            listViewSelesInfo.Name = "listViewSelesInfo";
            listViewSelesInfo.Size = new Size(524, 187);
            listViewSelesInfo.TabIndex = 0;
            listViewSelesInfo.UseCompatibleStateImageBehavior = false;
            listViewSelesInfo.View = View.Details;
            // 
            // columnHeaderSellOperationNumber
            // 
            columnHeaderSellOperationNumber.Text = "Номер чека";
            columnHeaderSellOperationNumber.Width = 80;
            // 
            // columnHeaderSellAmountMoney
            // 
            columnHeaderSellAmountMoney.Text = "Цена";
            columnHeaderSellAmountMoney.Width = 90;
            // 
            // columnHeaderSellName
            // 
            columnHeaderSellName.Text = "Имя продавца";
            columnHeaderSellName.Width = 90;
            // 
            // columnHeaderSellSurname
            // 
            columnHeaderSellSurname.Text = "Фамилия продавца";
            columnHeaderSellSurname.Width = 90;
            // 
            // columnHeaderSellOperationType
            // 
            columnHeaderSellOperationType.Text = "Тип операции";
            columnHeaderSellOperationType.Width = 90;
            // 
            // columnHeaderSellDate
            // 
            columnHeaderSellDate.Text = "Дата";
            columnHeaderSellDate.Width = 100;
            // 
            // listViewRevenues
            // 
            listViewRevenues.Columns.AddRange(new ColumnHeader[] { columnHeaderRevenue, columnHeaderRevenueDate });
            listViewRevenues.Location = new Point(12, 643);
            listViewRevenues.Name = "listViewRevenues";
            listViewRevenues.Size = new Size(309, 187);
            listViewRevenues.TabIndex = 1;
            listViewRevenues.UseCompatibleStateImageBehavior = false;
            listViewRevenues.View = View.Details;
            // 
            // columnHeaderRevenue
            // 
            columnHeaderRevenue.Text = "Выручка";
            columnHeaderRevenue.Width = 150;
            // 
            // columnHeaderRevenueDate
            // 
            columnHeaderRevenueDate.Text = "Дата";
            columnHeaderRevenueDate.Width = 150;
            // 
            // listViewRefundsInfo
            // 
            listViewRefundsInfo.Columns.AddRange(new ColumnHeader[] { columnHeaderRefundOperationNumber, columnHeaderRefundAmountMoney, columnHeaderRefundName, columnHeaderRefundSurname, columnHeaderRefundOperationType, columnHeaderRefundDate });
            listViewRefundsInfo.Location = new Point(10, 369);
            listViewRefundsInfo.Name = "listViewRefundsInfo";
            listViewRefundsInfo.Size = new Size(527, 187);
            listViewRefundsInfo.TabIndex = 2;
            listViewRefundsInfo.UseCompatibleStateImageBehavior = false;
            listViewRefundsInfo.View = View.Details;
            // 
            // columnHeaderRefundOperationNumber
            // 
            columnHeaderRefundOperationNumber.Text = "Номер чека";
            columnHeaderRefundOperationNumber.Width = 80;
            // 
            // columnHeaderRefundAmountMoney
            // 
            columnHeaderRefundAmountMoney.Text = "Сумма возврата";
            columnHeaderRefundAmountMoney.Width = 90;
            // 
            // columnHeaderRefundName
            // 
            columnHeaderRefundName.Text = "Имя продавца";
            columnHeaderRefundName.Width = 90;
            // 
            // columnHeaderRefundSurname
            // 
            columnHeaderRefundSurname.Text = "Фамилия продавца";
            columnHeaderRefundSurname.Width = 90;
            // 
            // columnHeaderRefundOperationType
            // 
            columnHeaderRefundOperationType.Text = "Тип Операции";
            columnHeaderRefundOperationType.Width = 90;
            // 
            // columnHeaderRefundDate
            // 
            columnHeaderRefundDate.Text = "Дата";
            columnHeaderRefundDate.Width = 100;
            // 
            // dateTimePickerSellInfoDateFrom
            // 
            dateTimePickerSellInfoDateFrom.Location = new Point(12, 64);
            dateTimePickerSellInfoDateFrom.Name = "dateTimePickerSellInfoDateFrom";
            dateTimePickerSellInfoDateFrom.Size = new Size(202, 23);
            dateTimePickerSellInfoDateFrom.TabIndex = 3;
            // 
            // buttonFindSelesInfoByDate
            // 
            buttonFindSelesInfoByDate.Location = new Point(426, 46);
            buttonFindSelesInfoByDate.Name = "buttonFindSelesInfoByDate";
            buttonFindSelesInfoByDate.Size = new Size(112, 43);
            buttonFindSelesInfoByDate.TabIndex = 8;
            buttonFindSelesInfoByDate.Text = "Найти";
            buttonFindSelesInfoByDate.UseVisualStyleBackColor = true;
            buttonFindSelesInfoByDate.Click += ButtonFindSelesInfoByDate_Click;
            // 
            // buttonRefundsInfoDate
            // 
            buttonRefundsInfoDate.Location = new Point(425, 322);
            buttonRefundsInfoDate.Name = "buttonRefundsInfoDate";
            buttonRefundsInfoDate.Size = new Size(112, 41);
            buttonRefundsInfoDate.TabIndex = 9;
            buttonRefundsInfoDate.Text = "Найти";
            buttonRefundsInfoDate.UseVisualStyleBackColor = true;
            buttonRefundsInfoDate.Click += ButtonRefundsInfoDate_Click;
            // 
            // buttonRevenueInfoDate
            // 
            buttonRevenueInfoDate.Location = new Point(327, 643);
            buttonRevenueInfoDate.Name = "buttonRevenueInfoDate";
            buttonRevenueInfoDate.Size = new Size(87, 41);
            buttonRevenueInfoDate.TabIndex = 10;
            buttonRevenueInfoDate.Text = "Найти";
            buttonRevenueInfoDate.UseVisualStyleBackColor = true;
            buttonRevenueInfoDate.Click += ButtonRevenueInfoDate_Click;
            // 
            // dateTimePickerRefundInfoDateFrom
            // 
            dateTimePickerRefundInfoDateFrom.Location = new Point(10, 340);
            dateTimePickerRefundInfoDateFrom.Name = "dateTimePickerRefundInfoDateFrom";
            dateTimePickerRefundInfoDateFrom.Size = new Size(203, 23);
            dateTimePickerRefundInfoDateFrom.TabIndex = 11;
            // 
            // dateTimePickerRevenueDateTo
            // 
            dateTimePickerRevenueDateTo.Location = new Point(170, 614);
            dateTimePickerRevenueDateTo.Name = "dateTimePickerRevenueDateTo";
            dateTimePickerRevenueDateTo.Size = new Size(151, 23);
            dateTimePickerRevenueDateTo.TabIndex = 12;
            // 
            // dateTimePickerRevenueDateFrom
            // 
            dateTimePickerRevenueDateFrom.Location = new Point(13, 614);
            dateTimePickerRevenueDateFrom.Name = "dateTimePickerRevenueDateFrom";
            dateTimePickerRevenueDateFrom.Size = new Size(151, 23);
            dateTimePickerRevenueDateFrom.TabIndex = 15;
            // 
            // dateTimePickerRefundInfoDateTo
            // 
            dateTimePickerRefundInfoDateTo.Location = new Point(219, 340);
            dateTimePickerRefundInfoDateTo.Name = "dateTimePickerRefundInfoDateTo";
            dateTimePickerRefundInfoDateTo.Size = new Size(200, 23);
            dateTimePickerRefundInfoDateTo.TabIndex = 14;
            // 
            // dateTimePickerSellInfoDateTo
            // 
            dateTimePickerSellInfoDateTo.Location = new Point(220, 64);
            dateTimePickerSellInfoDateTo.Name = "dateTimePickerSellInfoDateTo";
            dateTimePickerSellInfoDateTo.Size = new Size(200, 23);
            dateTimePickerSellInfoDateTo.TabIndex = 13;
            // 
            // labelSellInfoDateFrom
            // 
            labelSellInfoDateFrom.AutoSize = true;
            labelSellInfoDateFrom.Location = new Point(12, 46);
            labelSellInfoDateFrom.Name = "labelSellInfoDateFrom";
            labelSellInfoDateFrom.Size = new Size(53, 15);
            labelSellInfoDateFrom.TabIndex = 16;
            labelSellInfoDateFrom.Text = "с какого";
            // 
            // labelRefundInfoDateFrom
            // 
            labelRefundInfoDateFrom.AutoSize = true;
            labelRefundInfoDateFrom.Location = new Point(13, 322);
            labelRefundInfoDateFrom.Name = "labelRefundInfoDateFrom";
            labelRefundInfoDateFrom.Size = new Size(55, 15);
            labelRefundInfoDateFrom.TabIndex = 17;
            labelRefundInfoDateFrom.Text = "С какого";
            // 
            // labelRevenueDateFrom
            // 
            labelRevenueDateFrom.AutoSize = true;
            labelRevenueDateFrom.Location = new Point(11, 596);
            labelRevenueDateFrom.Name = "labelRevenueDateFrom";
            labelRevenueDateFrom.Size = new Size(55, 15);
            labelRevenueDateFrom.TabIndex = 18;
            labelRevenueDateFrom.Text = "С какого";
            // 
            // labelRevenueDateTo
            // 
            labelRevenueDateTo.AutoSize = true;
            labelRevenueDateTo.Location = new Point(170, 596);
            labelRevenueDateTo.Name = "labelRevenueDateTo";
            labelRevenueDateTo.Size = new Size(57, 15);
            labelRevenueDateTo.TabIndex = 21;
            labelRevenueDateTo.Text = "По какое";
            // 
            // labelRefundInfoDateTo
            // 
            labelRefundInfoDateTo.AutoSize = true;
            labelRefundInfoDateTo.Location = new Point(219, 322);
            labelRefundInfoDateTo.Name = "labelRefundInfoDateTo";
            labelRefundInfoDateTo.Size = new Size(57, 15);
            labelRefundInfoDateTo.TabIndex = 20;
            labelRefundInfoDateTo.Text = "По какое";
            // 
            // labelSellInfoDateTo
            // 
            labelSellInfoDateTo.AutoSize = true;
            labelSellInfoDateTo.Location = new Point(220, 46);
            labelSellInfoDateTo.Name = "labelSellInfoDateTo";
            labelSellInfoDateTo.Size = new Size(55, 15);
            labelSellInfoDateTo.TabIndex = 19;
            labelSellInfoDateTo.Text = "по какое";
            // 
            // labelSell
            // 
            labelSell.AutoSize = true;
            labelSell.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelSell.Location = new Point(11, 9);
            labelSell.Name = "labelSell";
            labelSell.Size = new Size(133, 37);
            labelSell.TabIndex = 22;
            labelSell.Text = "Продажи";
            // 
            // labelRefund
            // 
            labelRefund.AutoSize = true;
            labelRefund.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelRefund.Location = new Point(10, 285);
            labelRefund.Name = "labelRefund";
            labelRefund.Size = new Size(134, 37);
            labelRefund.TabIndex = 23;
            labelRefund.Text = "Возвраты";
            // 
            // labelRevenue
            // 
            labelRevenue.AutoSize = true;
            labelRevenue.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            labelRevenue.Location = new Point(10, 559);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(122, 37);
            labelRevenue.TabIndex = 24;
            labelRevenue.Text = "Выручка";
            // 
            // buttonGetSellInfo
            // 
            buttonGetSellInfo.Location = new Point(544, 46);
            buttonGetSellInfo.Name = "buttonGetSellInfo";
            buttonGetSellInfo.Size = new Size(422, 41);
            buttonGetSellInfo.TabIndex = 25;
            buttonGetSellInfo.Text = "Получить дополнительную информацию";
            buttonGetSellInfo.UseVisualStyleBackColor = true;
            buttonGetSellInfo.Click += ButtonGetSellProducts_Click;
            // 
            // listViewSellProducts
            // 
            listViewSellProducts.Columns.AddRange(new ColumnHeader[] { columnHeaderSellProductID, columnHeaderSellProductName, columnHeaderSellProductPrice, columnHeaderSellProductAmount });
            listViewSellProducts.Location = new Point(544, 93);
            listViewSellProducts.Name = "listViewSellProducts";
            listViewSellProducts.Size = new Size(422, 187);
            listViewSellProducts.TabIndex = 26;
            listViewSellProducts.UseCompatibleStateImageBehavior = false;
            listViewSellProducts.View = View.Details;
            // 
            // columnHeaderSellProductID
            // 
            columnHeaderSellProductID.Text = "ID";
            columnHeaderSellProductID.Width = 100;
            // 
            // columnHeaderSellProductName
            // 
            columnHeaderSellProductName.Text = "Товар";
            columnHeaderSellProductName.Width = 120;
            // 
            // columnHeaderSellProductPrice
            // 
            columnHeaderSellProductPrice.Text = "Цена";
            columnHeaderSellProductPrice.Width = 100;
            // 
            // columnHeaderSellProductAmount
            // 
            columnHeaderSellProductAmount.Text = "Колличество";
            columnHeaderSellProductAmount.Width = 90;
            // 
            // listViewRefundProducts
            // 
            listViewRefundProducts.Columns.AddRange(new ColumnHeader[] { columnHeaderRefundProductID, columnHeaderRefundproductName, columnHeaderRefundProductPrice, columnHeaderRefundProductAmount });
            listViewRefundProducts.Location = new Point(544, 369);
            listViewRefundProducts.Name = "listViewRefundProducts";
            listViewRefundProducts.Size = new Size(422, 187);
            listViewRefundProducts.TabIndex = 28;
            listViewRefundProducts.UseCompatibleStateImageBehavior = false;
            listViewRefundProducts.View = View.Details;
            // 
            // columnHeaderRefundProductID
            // 
            columnHeaderRefundProductID.Text = "ID";
            columnHeaderRefundProductID.Width = 100;
            // 
            // columnHeaderRefundproductName
            // 
            columnHeaderRefundproductName.Text = "Товар";
            columnHeaderRefundproductName.Width = 120;
            // 
            // columnHeaderRefundProductPrice
            // 
            columnHeaderRefundProductPrice.Text = "Цена";
            columnHeaderRefundProductPrice.Width = 100;
            // 
            // columnHeaderRefundProductAmount
            // 
            columnHeaderRefundProductAmount.Text = "Колличество";
            columnHeaderRefundProductAmount.Width = 90;
            // 
            // buttonGetRefundInfo
            // 
            buttonGetRefundInfo.Location = new Point(544, 320);
            buttonGetRefundInfo.Name = "buttonGetRefundInfo";
            buttonGetRefundInfo.Size = new Size(422, 41);
            buttonGetRefundInfo.TabIndex = 27;
            buttonGetRefundInfo.Text = "Получить дополнительную информацию";
            buttonGetRefundInfo.UseVisualStyleBackColor = true;
            buttonGetRefundInfo.Click += ButtonGetRefundProducts_Click;
            // 
            // errorProviderSelectSellNumber
            // 
            errorProviderSelectSellNumber.ContainerControl = this;
            // 
            // errorProviderSelectRefundNumber
            // 
            errorProviderSelectRefundNumber.ContainerControl = this;
            // 
            // richTextBoxReason
            // 
            richTextBoxReason.Location = new Point(972, 369);
            richTextBoxReason.Name = "richTextBoxReason";
            richTextBoxReason.ReadOnly = true;
            richTextBoxReason.Size = new Size(196, 187);
            richTextBoxReason.TabIndex = 29;
            richTextBoxReason.Text = "";
            // 
            // labelReason
            // 
            labelReason.AutoSize = true;
            labelReason.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelReason.Location = new Point(972, 338);
            labelReason.Name = "labelReason";
            labelReason.Size = new Size(91, 25);
            labelReason.TabIndex = 30;
            labelReason.Text = "Причина";
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1176, 847);
            Controls.Add(labelReason);
            Controls.Add(richTextBoxReason);
            Controls.Add(listViewRefundProducts);
            Controls.Add(buttonGetRefundInfo);
            Controls.Add(listViewSellProducts);
            Controls.Add(buttonGetSellInfo);
            Controls.Add(labelRevenue);
            Controls.Add(labelRefund);
            Controls.Add(labelSell);
            Controls.Add(labelRevenueDateTo);
            Controls.Add(labelRefundInfoDateTo);
            Controls.Add(labelSellInfoDateTo);
            Controls.Add(labelRevenueDateFrom);
            Controls.Add(labelRefundInfoDateFrom);
            Controls.Add(labelSellInfoDateFrom);
            Controls.Add(dateTimePickerRevenueDateFrom);
            Controls.Add(dateTimePickerRefundInfoDateTo);
            Controls.Add(dateTimePickerSellInfoDateTo);
            Controls.Add(dateTimePickerRevenueDateTo);
            Controls.Add(dateTimePickerRefundInfoDateFrom);
            Controls.Add(buttonRevenueInfoDate);
            Controls.Add(buttonRefundsInfoDate);
            Controls.Add(buttonFindSelesInfoByDate);
            Controls.Add(dateTimePickerSellInfoDateFrom);
            Controls.Add(listViewRefundsInfo);
            Controls.Add(listViewRevenues);
            Controls.Add(listViewSelesInfo);
            Name = "HistoryForm";
            Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)errorProviderSelectSellNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSelectRefundNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewSelesInfo;
        private ListView listViewRevenues;
        private ListView listViewRefundsInfo;
        private DateTimePicker dateTimePickerSellInfoDateFrom;
        private Button buttonFindSelesInfoByDate;
        private Button buttonRefundsInfoDate;
        private Button buttonRevenueInfoDate;
        private DateTimePicker dateTimePickerRefundInfoDateFrom;
        private DateTimePicker dateTimePickerRevenueDateTo;
        private DateTimePicker dateTimePickerRevenueDateFrom;
        private DateTimePicker dateTimePickerRefundInfoDateTo;
        private DateTimePicker dateTimePickerSellInfoDateTo;
        private Label labelSellInfoDateFrom;
        private Label labelRefundInfoDateFrom;
        private Label labelRevenueDateFrom;
        private Label labelRevenueDateTo;
        private Label labelRefundInfoDateTo;
        private Label labelSellInfoDateTo;
        private Label labelSell;
        private Label labelRefund;
        private Label labelRevenue;
        private Button buttonGetSellInfo;
        private ListView listViewSellProducts;
        private ListView listViewRefundProducts;
        private Button buttonGetRefundInfo;
        private ColumnHeader columnHeaderSellOperationNumber;
        private ColumnHeader columnHeaderSellAmountMoney;
        private ColumnHeader columnHeaderSellName;
        private ColumnHeader columnHeaderSellSurname;
        private ColumnHeader columnHeaderSellOperationType;
        private ColumnHeader columnHeaderSellDate;
        private ColumnHeader columnHeaderRefundOperationNumber;
        private ColumnHeader columnHeaderRefundAmountMoney;
        private ColumnHeader columnHeaderRefundName;
        private ColumnHeader columnHeaderRefundSurname;
        private ColumnHeader columnHeaderRefundOperationType;
        private ColumnHeader columnHeaderRefundDate;
        private ColumnHeader columnHeaderRevenue;
        private ColumnHeader columnHeaderRevenueDate;
        private ColumnHeader columnHeaderSellProductID;
        private ColumnHeader columnHeaderSellProductName;
        private ColumnHeader columnHeaderSellProductPrice;
        private ColumnHeader columnHeaderRefundProductID;
        private ColumnHeader columnHeaderRefundproductName;
        private ColumnHeader columnHeaderRefundProductPrice;
        private ColumnHeader columnHeaderSellProductAmount;
        private ColumnHeader columnHeaderRefundProductAmount;
        private ErrorProvider errorProviderSelectSellNumber;
        private ErrorProvider errorProviderSelectRefundNumber;
        private Label labelReason;
        private RichTextBox richTextBoxReason;
    }
}