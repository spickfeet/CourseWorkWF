using CourseWorkWF.Models;

namespace CourseWorkWF.Views
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            AssortmentForm assortment = new AssortmentForm(this);
            assortment.ShowDialog();
        }

        private void ButtonCashier_Click(object sender, EventArgs e)
        {
            SellForm cashierARM = new SellForm(this);
            cashierARM.ShowDialog();
        }
    }
}