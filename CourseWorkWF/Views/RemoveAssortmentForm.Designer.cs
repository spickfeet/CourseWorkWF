namespace CourseWorkWF.Views
{
    partial class RemoveAssortmentForm
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
            buttonRemoveProduct = new Button();
            labelProductID = new Label();
            errorProviderProductID = new ErrorProvider(components);
            numericUpDownAmount = new NumericUpDown();
            labelAmount = new Label();
            textBoxProductID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // buttonRemoveProduct
            // 
            buttonRemoveProduct.Location = new Point(168, 12);
            buttonRemoveProduct.Name = "buttonRemoveProduct";
            buttonRemoveProduct.Size = new Size(96, 53);
            buttonRemoveProduct.TabIndex = 1;
            buttonRemoveProduct.Text = "Удалить";
            buttonRemoveProduct.UseVisualStyleBackColor = true;
            buttonRemoveProduct.Click += ButtonRemoveProduct_Click;
            // 
            // labelProductID
            // 
            labelProductID.AutoSize = true;
            labelProductID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelProductID.Location = new Point(10, 12);
            labelProductID.Name = "labelProductID";
            labelProductID.Size = new Size(71, 15);
            labelProductID.TabIndex = 2;
            labelProductID.Text = "ID продукта";
            // 
            // errorProviderProductID
            // 
            errorProviderProductID.ContainerControl = this;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 3;
            numericUpDownAmount.Location = new Point(12, 70);
            numericUpDownAmount.Margin = new Padding(3, 2, 3, 2);
            numericUpDownAmount.Maximum = new decimal(new int[] { 2000000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(120, 23);
            numericUpDownAmount.TabIndex = 3;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(10, 53);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(72, 15);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "Количество";
            // 
            // textBoxProductID
            // 
            textBoxProductID.Location = new Point(10, 30);
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.Size = new Size(122, 23);
            textBoxProductID.TabIndex = 5;
            // 
            // RemoveAssortmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(276, 140);
            Controls.Add(textBoxProductID);
            Controls.Add(labelAmount);
            Controls.Add(numericUpDownAmount);
            Controls.Add(labelProductID);
            Controls.Add(buttonRemoveProduct);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RemoveAssortmentForm";
            Text = "RemoveAssortment";
            ((System.ComponentModel.ISupportInitialize)errorProviderProductID).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonRemoveProduct;
        private Label labelProductID;
        private ErrorProvider errorProviderProductID;
        private NumericUpDown numericUpDownAmount;
        private Label labelAmount;
        private TextBox textBoxProductID;
    }
}