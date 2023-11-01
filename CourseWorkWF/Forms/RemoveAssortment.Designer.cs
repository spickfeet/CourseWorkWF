namespace CourseWorkWF.Forms
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
            NumericUpDownProductID = new NumericUpDown();
            ButtonRemoveProduct = new Button();
            LabelProductID = new Label();
            ErrorProviderProductID = new ErrorProvider(components);
            NumericUpDownAmount = new NumericUpDown();
            LabelAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // NumericUpDownProductID
            // 
            NumericUpDownProductID.Location = new Point(12, 40);
            NumericUpDownProductID.Margin = new Padding(3, 4, 3, 4);
            NumericUpDownProductID.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            NumericUpDownProductID.Name = "NumericUpDownProductID";
            NumericUpDownProductID.Size = new Size(137, 27);
            NumericUpDownProductID.TabIndex = 0;
            // 
            // ButtonRemoveProduct
            // 
            ButtonRemoveProduct.Location = new Point(192, 16);
            ButtonRemoveProduct.Margin = new Padding(3, 4, 3, 4);
            ButtonRemoveProduct.Name = "ButtonRemoveProduct";
            ButtonRemoveProduct.Size = new Size(110, 71);
            ButtonRemoveProduct.TabIndex = 1;
            ButtonRemoveProduct.Text = "Удалить";
            ButtonRemoveProduct.UseVisualStyleBackColor = true;
            ButtonRemoveProduct.Click += ButtonRemoveProduct_Click;
            // 
            // LabelProductID
            // 
            LabelProductID.AutoSize = true;
            LabelProductID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelProductID.Location = new Point(11, 16);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(91, 20);
            LabelProductID.TabIndex = 2;
            LabelProductID.Text = "ID продукта";
            // 
            // ErrorProviderProductID
            // 
            ErrorProviderProductID.ContainerControl = this;
            // 
            // NumericUpDownAmount
            // 
            NumericUpDownAmount.Location = new Point(14, 94);
            NumericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            NumericUpDownAmount.Name = "NumericUpDownAmount";
            NumericUpDownAmount.Size = new Size(137, 27);
            NumericUpDownAmount.TabIndex = 3;
            // 
            // LabelAmount
            // 
            LabelAmount.AutoSize = true;
            LabelAmount.Location = new Point(12, 71);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(90, 20);
            LabelAmount.TabIndex = 4;
            LabelAmount.Text = "Количество";
            // 
            // RemoveAssortment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 187);
            Controls.Add(LabelAmount);
            Controls.Add(NumericUpDownAmount);
            Controls.Add(LabelProductID);
            Controls.Add(ButtonRemoveProduct);
            Controls.Add(NumericUpDownProductID);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RemoveAssortment";
            Text = "RemoveAssortment";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumericUpDownProductID;
        private Button ButtonRemoveProduct;
        private Label LabelProductID;
        private ErrorProvider ErrorProviderProductID;
        private NumericUpDown NumericUpDownAmount;
        private Label LabelAmount;
    }
}