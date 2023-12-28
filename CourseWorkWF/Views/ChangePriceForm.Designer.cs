namespace CourseWorkWF.Views
{
    partial class ChangePriceForm
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
            textBoxProductID = new TextBox();
            labelProductID = new Label();
            labelPrice = new Label();
            numericUpDownPrice = new NumericUpDown();
            buttonChangePrice = new Button();
            errorProviderProductID = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductID).BeginInit();
            SuspendLayout();
            // 
            // textBoxProductID
            // 
            textBoxProductID.Location = new Point(12, 27);
            textBoxProductID.Name = "textBoxProductID";
            textBoxProductID.Size = new Size(135, 23);
            textBoxProductID.TabIndex = 0;
            textBoxProductID.KeyPress += TextBoxNumerical_KeyPressNotNumber;
            // 
            // labelProductID
            // 
            labelProductID.AutoSize = true;
            labelProductID.Location = new Point(12, 9);
            labelProductID.Name = "labelProductID";
            labelProductID.Size = new Size(18, 15);
            labelProductID.TabIndex = 1;
            labelProductID.Text = "ID";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 53);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(35, 15);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Цена";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(12, 70);
            numericUpDownPrice.Maximum = new decimal(new int[] { 500000000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(135, 23);
            numericUpDownPrice.TabIndex = 4;
            // 
            // buttonChangePrice
            // 
            buttonChangePrice.BackColor = Color.Turquoise;
            buttonChangePrice.Location = new Point(153, 27);
            buttonChangePrice.Name = "buttonChangePrice";
            buttonChangePrice.Size = new Size(118, 66);
            buttonChangePrice.TabIndex = 5;
            buttonChangePrice.Text = "Изменить цену";
            buttonChangePrice.UseVisualStyleBackColor = false;
            buttonChangePrice.Click += ButtonChangePrice_Click;
            // 
            // errorProviderProductID
            // 
            errorProviderProductID.ContainerControl = this;
            // 
            // ChangePriceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(283, 119);
            Controls.Add(buttonChangePrice);
            Controls.Add(numericUpDownPrice);
            Controls.Add(labelPrice);
            Controls.Add(labelProductID);
            Controls.Add(textBoxProductID);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePriceForm";
            Text = "MyARM";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderProductID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProductID;
        private Label labelProductID;
        private Label labelPrice;
        private NumericUpDown numericUpDownPrice;
        private Button buttonChangePrice;
        private ErrorProvider errorProviderProductID;
    }
}