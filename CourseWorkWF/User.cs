namespace CourseWorkWF
{
    public partial class User : Form
    {
        private AssortmentList _assortment;
        public User()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Assortment assortment = new Assortment(this, _assortment);
            assortment.ShowDialog();
        }
    }
}