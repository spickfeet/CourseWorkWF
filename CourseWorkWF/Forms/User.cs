namespace CourseWorkWF
{
    public partial class User : Form
    {
        private AssortmentList _assortment;
        public User()
        {
            InitializeComponent();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            Assortment assortment = new Assortment(this);
            assortment.ShowDialog();
        }

        private void ButtonCashier_Click(object sender, EventArgs e)
        {
            Sell cashierARM = new Sell(this);
            cashierARM.ShowDialog();
        }
    }
}