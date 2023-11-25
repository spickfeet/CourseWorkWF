namespace CourseWorkWF
{
    public partial class UserForm : Form
    {
        private AssortmentDictionary _assortment;
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