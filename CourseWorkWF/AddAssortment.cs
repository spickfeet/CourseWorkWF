using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkWF
{
    public partial class AddAssortment : Form
    {
        public AddAssortment()
        {
            InitializeComponent();
        }

        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            // Product product = new Product(Int32.Parse(TextBoxProductID.Text), TextBoxProductName.Text, Double.Parse(TextBoxProductPrice.Text),DateTimePickerExDate.Value);
            
            Close();
        }
    }
}
