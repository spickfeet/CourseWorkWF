namespace CourseWorkWF
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Assortment assortment = new Assortment(this);
            assortment.ShowDialog();
        }
    }
}