﻿namespace CourseWorkWF.Forms
{
    partial class RemoveAssortment
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
            numericUpDownProductID = new NumericUpDown();
            buttonRemoveProduct = new Button();
            labelProductID = new Label();
            ErrorProviderProductID = new ErrorProvider(components);
            numericUpDownAmount = new NumericUpDown();
            labelAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownProductID
            // 
            numericUpDownProductID.Location = new Point(12, 40);
            numericUpDownProductID.Margin = new Padding(3, 4, 3, 4);
            numericUpDownProductID.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            numericUpDownProductID.Name = "numericUpDownProductID";
            numericUpDownProductID.Size = new Size(137, 27);
            numericUpDownProductID.TabIndex = 0;
            // 
            // buttonRemoveProduct
            // 
            buttonRemoveProduct.Location = new Point(192, 16);
            buttonRemoveProduct.Margin = new Padding(3, 4, 3, 4);
            buttonRemoveProduct.Name = "buttonRemoveProduct";
            buttonRemoveProduct.Size = new Size(110, 71);
            buttonRemoveProduct.TabIndex = 1;
            buttonRemoveProduct.Text = "Удалить";
            buttonRemoveProduct.UseVisualStyleBackColor = true;
            buttonRemoveProduct.Click += ButtonRemoveProduct_Click;
            // 
            // labelProductID
            // 
            labelProductID.AutoSize = true;
            labelProductID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductID.Location = new Point(11, 16);
            labelProductID.Name = "labelProductID";
            labelProductID.Size = new Size(91, 20);
            labelProductID.TabIndex = 2;
            labelProductID.Text = "ID продукта";
            // 
            // ErrorProviderProductID
            // 
            ErrorProviderProductID.ContainerControl = this;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(14, 94);
            numericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(137, 27);
            numericUpDownAmount.TabIndex = 3;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(12, 71);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(90, 20);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "Количество";
            // 
            // RemoveAssortment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(315, 187);
            Controls.Add(labelAmount);
            Controls.Add(numericUpDownAmount);
            Controls.Add(labelProductID);
            Controls.Add(buttonRemoveProduct);
            Controls.Add(numericUpDownProductID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RemoveAssortment";
            Text = "RemoveAssortment";
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownProductID;
        private Button buttonRemoveProduct;
        private Label labelProductID;
        private ErrorProvider ErrorProviderProductID;
        private NumericUpDown numericUpDownAmount;
        private Label labelAmount;
    }
}