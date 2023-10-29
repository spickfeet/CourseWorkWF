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
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderProductID).BeginInit();
            SuspendLayout();
            // 
            // NumericUpDownProductID
            // 
            NumericUpDownProductID.Location = new Point(12, 42);
            NumericUpDownProductID.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            NumericUpDownProductID.Name = "NumericUpDownProductID";
            NumericUpDownProductID.Size = new Size(120, 23);
            NumericUpDownProductID.TabIndex = 0;
            // 
            // ButtonRemoveProduct
            // 
            ButtonRemoveProduct.Location = new Point(168, 12);
            ButtonRemoveProduct.Name = "ButtonRemoveProduct";
            ButtonRemoveProduct.Size = new Size(96, 53);
            ButtonRemoveProduct.TabIndex = 1;
            ButtonRemoveProduct.Text = "Удалить";
            ButtonRemoveProduct.UseVisualStyleBackColor = true;
            ButtonRemoveProduct.Click += ButtonRemoveProduct_Click;
            // 
            // LabelProductID
            // 
            LabelProductID.AutoSize = true;
            LabelProductID.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LabelProductID.Location = new Point(12, 12);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(114, 25);
            LabelProductID.TabIndex = 2;
            LabelProductID.Text = "ID продукта";
            // 
            // ErrorProviderProductID
            // 
            ErrorProviderProductID.ContainerControl = this;
            // 
            // RemoveAssortment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 140);
            Controls.Add(LabelProductID);
            Controls.Add(ButtonRemoveProduct);
            Controls.Add(NumericUpDownProductID);
            Name = "RemoveAssortment";
            Text = "RemoveAssortment";
            ((System.ComponentModel.ISupportInitialize)NumericUpDownProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderProductID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumericUpDownProductID;
        private Button ButtonRemoveProduct;
        private Label LabelProductID;
        private ErrorProvider ErrorProviderProductID;
    }
}