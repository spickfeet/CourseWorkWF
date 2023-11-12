﻿namespace CourseWorkWF
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
            buttonAddProductInAssortment = new Button();
            labelProductID = new Label();
            labelProductName = new Label();
            textBoxProductName = new TextBox();
            lableProductPrice = new Label();
            labelAmount = new Label();
            numericUpDownProductID = new NumericUpDown();
            numericUpDownProductPrice = new NumericUpDown();
            numericUpDownAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // buttonAddProductInAssortment
            // 
            buttonAddProductInAssortment.Location = new Point(215, 32);
            buttonAddProductInAssortment.Margin = new Padding(3, 4, 3, 4);
            buttonAddProductInAssortment.Name = "buttonAddProductInAssortment";
            buttonAddProductInAssortment.Size = new Size(119, 93);
            buttonAddProductInAssortment.TabIndex = 0;
            buttonAddProductInAssortment.Text = "Добавить";
            buttonAddProductInAssortment.UseVisualStyleBackColor = true;
            buttonAddProductInAssortment.Click += AddProductInAssortmentButton_Click;
            // 
            // labelProductID
            // 
            labelProductID.AutoSize = true;
            labelProductID.Location = new Point(14, 8);
            labelProductID.Name = "labelProductID";
            labelProductID.Size = new Size(91, 20);
            labelProductID.TabIndex = 3;
            labelProductID.Text = "ID продукта";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(14, 67);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(77, 20);
            labelProductName.TabIndex = 5;
            labelProductName.Text = "Название";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(14, 95);
            textBoxProductName.Margin = new Padding(3, 4, 3, 4);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(165, 27);
            textBoxProductName.TabIndex = 4;
            // 
            // lableProductPrice
            // 
            lableProductPrice.AutoSize = true;
            lableProductPrice.Location = new Point(14, 129);
            lableProductPrice.Name = "lableProductPrice";
            lableProductPrice.Size = new Size(45, 20);
            lableProductPrice.TabIndex = 7;
            lableProductPrice.Text = "Цена";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(14, 192);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(90, 20);
            labelAmount.TabIndex = 8;
            labelAmount.Text = "Количество";
            // 
            // numericUpDownProductID
            // 
            numericUpDownProductID.Location = new Point(14, 32);
            numericUpDownProductID.Margin = new Padding(3, 4, 3, 4);
            numericUpDownProductID.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            numericUpDownProductID.Name = "numericUpDownProductID";
            numericUpDownProductID.Size = new Size(166, 27);
            numericUpDownProductID.TabIndex = 10;
            numericUpDownProductID.ValueChanged += NumericUpDownProductID_ValueChanged;
            // 
            // numericUpDownProductPrice
            // 
            numericUpDownProductPrice.DecimalPlaces = 2;
            numericUpDownProductPrice.Location = new Point(14, 157);
            numericUpDownProductPrice.Margin = new Padding(3, 4, 3, 4);
            numericUpDownProductPrice.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownProductPrice.Name = "numericUpDownProductPrice";
            numericUpDownProductPrice.Size = new Size(166, 27);
            numericUpDownProductPrice.TabIndex = 11;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(14, 216);
            numericUpDownAmount.Margin = new Padding(3, 4, 3, 4);
            numericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(166, 27);
            numericUpDownAmount.TabIndex = 12;
            // 
            // AddAssortment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(347, 279);
            Controls.Add(numericUpDownAmount);
            Controls.Add(numericUpDownProductPrice);
            Controls.Add(numericUpDownProductID);
            Controls.Add(labelAmount);
            Controls.Add(lableProductPrice);
            Controls.Add(labelProductName);
            Controls.Add(textBoxProductName);
            Controls.Add(labelProductID);
            Controls.Add(buttonAddProductInAssortment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAssortment";
            Text = "AddAssortment";
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddProductInAssortment;
        private Label labelProductID;
        private Label labelProductName;
        private TextBox textBoxProductName;
        private Label lableProductPrice;
        private Label labelAmount;
        private NumericUpDown numericUpDownProductID;
        private NumericUpDown numericUpDownProductPrice;
        private NumericUpDown numericUpDownAmount;
    }
}