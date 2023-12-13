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
            listViewSeles = new ListView();
            richTextBoxSellInfo = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            buttonFind = new Button();
            buttonInfo = new Button();
            richTextBoxReson = new RichTextBox();
            listView1 = new ListView();
            labelSeles = new Label();
            labelSellInfo = new Label();
            labelReson = new Label();
            labelProductsRefundList = new Label();
            buttonRefund = new Button();
            numericUpDown1 = new NumericUpDown();
            labelNumer = new Label();
            numericUpDown2 = new NumericUpDown();
            buttonAddProductRefundList = new Button();
            labelProductID = new Label();
            comboBox1 = new ComboBox();
            labelOperationMethod = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // listViewSeles
            // 
            listViewSeles.Location = new Point(198, 32);
            listViewSeles.Name = "listViewSeles";
            listViewSeles.Size = new Size(191, 234);
            listViewSeles.TabIndex = 1;
            listViewSeles.UseCompatibleStateImageBehavior = false;
            // 
            // richTextBoxSellInfo
            // 
            richTextBoxSellInfo.Location = new Point(395, 32);
            richTextBoxSellInfo.Name = "richTextBoxSellInfo";
            richTextBoxSellInfo.Size = new Size(190, 234);
            richTextBoxSellInfo.TabIndex = 2;
            richTextBoxSellInfo.Text = "";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // buttonFind
            // 
            buttonFind.Location = new Point(12, 98);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(178, 29);
            buttonFind.TabIndex = 4;
            buttonFind.Text = "Найти чек";
            buttonFind.UseVisualStyleBackColor = true;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(198, 272);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(191, 63);
            buttonInfo.TabIndex = 5;
            buttonInfo.Text = "Получить информацию о чеке";
            buttonInfo.UseVisualStyleBackColor = true;
            // 
            // richTextBoxReson
            // 
            richTextBoxReson.Location = new Point(812, 32);
            richTextBoxReson.Name = "richTextBoxReson";
            richTextBoxReson.Size = new Size(191, 234);
            richTextBoxReson.TabIndex = 6;
            richTextBoxReson.Text = "";
            // 
            // listView1
            // 
            listView1.Location = new Point(591, 32);
            listView1.Name = "listView1";
            listView1.Size = new Size(215, 234);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // labelSeles
            // 
            labelSeles.AutoSize = true;
            labelSeles.Location = new Point(198, 9);
            labelSeles.Name = "labelSeles";
            labelSeles.Size = new Size(126, 20);
            labelSeles.TabIndex = 9;
            labelSeles.Text = "История продаж";
            // 
            // labelSellInfo
            // 
            labelSellInfo.AutoSize = true;
            labelSellInfo.Location = new Point(395, 9);
            labelSellInfo.Name = "labelSellInfo";
            labelSellInfo.Size = new Size(181, 20);
            labelSellInfo.TabIndex = 10;
            labelSellInfo.Text = "Информация о продаже";
            // 
            // labelReson
            // 
            labelReson.AutoSize = true;
            labelReson.Location = new Point(812, 9);
            labelReson.Name = "labelReson";
            labelReson.Size = new Size(139, 20);
            labelReson.TabIndex = 11;
            labelReson.Text = "Причина возврата";
            // 
            // labelProductsRefundList
            // 
            labelProductsRefundList.AutoSize = true;
            labelProductsRefundList.Location = new Point(591, 9);
            labelProductsRefundList.Name = "labelProductsRefundList";
            labelProductsRefundList.Size = new Size(215, 20);
            labelProductsRefundList.TabIndex = 13;
            labelProductsRefundList.Text = "Список товаров для возврата";
            // 
            // buttonRefund
            // 
            buttonRefund.Location = new Point(812, 329);
            buttonRefund.Name = "buttonRefund";
            buttonRefund.Size = new Size(191, 63);
            buttonRefund.TabIndex = 14;
            buttonRefund.Text = "Вернуть деньги";
            buttonRefund.UseVisualStyleBackColor = true;
            buttonRefund.Click += buttonRefund_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 32);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(178, 27);
            numericUpDown1.TabIndex = 15;
            // 
            // labelNumer
            // 
            labelNumer.AutoSize = true;
            labelNumer.Location = new Point(12, 9);
            labelNumer.Name = "labelNumer";
            labelNumer.Size = new Size(92, 20);
            labelNumer.TabIndex = 16;
            labelNumer.Text = "Номер чека";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(591, 296);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(215, 27);
            numericUpDown2.TabIndex = 17;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // buttonAddProductRefundList
            // 
            buttonAddProductRefundList.Location = new Point(591, 329);
            buttonAddProductRefundList.Name = "buttonAddProductRefundList";
            buttonAddProductRefundList.Size = new Size(215, 63);
            buttonAddProductRefundList.TabIndex = 18;
            buttonAddProductRefundList.Text = "Добавить продукт в список для возврата";
            buttonAddProductRefundList.UseVisualStyleBackColor = true;
            // 
            // labelProductID
            // 
            labelProductID.AutoSize = true;
            labelProductID.Location = new Point(591, 272);
            labelProductID.Name = "labelProductID";
            labelProductID.Size = new Size(95, 20);
            labelProductID.TabIndex = 19;
            labelProductID.Text = "ID продукта ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(812, 295);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 28);
            comboBox1.TabIndex = 20;
            // 
            // labelOperationMethod
            // 
            labelOperationMethod.AutoSize = true;
            labelOperationMethod.Location = new Point(808, 272);
            labelOperationMethod.Name = "labelOperationMethod";
            labelOperationMethod.Size = new Size(171, 20);
            labelOperationMethod.TabIndex = 21;
            labelOperationMethod.Text = "Способ возврата денег";
            // 
            // RefundForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 502);
            Controls.Add(labelOperationMethod);
            Controls.Add(comboBox1);
            Controls.Add(labelProductID);
            Controls.Add(buttonAddProductRefundList);
            Controls.Add(numericUpDown2);
            Controls.Add(labelNumer);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonRefund);
            Controls.Add(labelProductsRefundList);
            Controls.Add(labelReson);
            Controls.Add(labelSellInfo);
            Controls.Add(labelSeles);
            Controls.Add(listView1);
            Controls.Add(richTextBoxReson);
            Controls.Add(buttonInfo);
            Controls.Add(buttonFind);
            Controls.Add(dateTimePicker1);
            Controls.Add(richTextBoxSellInfo);
            Controls.Add(listViewSeles);
            Name = "RefundForm";
            Text = "RefundForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listViewSeles;
        private RichTextBox richTextBoxSellInfo;
        private DateTimePicker dateTimePicker1;
        private Button buttonFind;
        private Button buttonInfo;
        private RichTextBox richTextBoxReson;
        private ListView listView1;
        private Label labelSeles;
        private Label labelSellInfo;
        private Label labelReson;
        private Label labelProductsRefundList;
        private Button buttonRefund;
        private NumericUpDown numericUpDown1;
        private Label labelNumer;
        private NumericUpDown numericUpDown2;
        private Button buttonAddProductRefundList;
        private Label labelProductID;
        private ComboBox comboBox1;
        private Label labelOperationMethod;
    }
}