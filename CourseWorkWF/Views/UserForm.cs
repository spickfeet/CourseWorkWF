using CourseWorkWF.Models;

namespace CourseWorkWF.Views
{
    public partial class UserForm : Form
    {
        private Form _prevForm;
        public UserForm(Form prev)
        {
            _prevForm = prev;
            _prevForm.Hide();
            FormClosed += OnClosed;
            InitializeComponent();
        }
        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
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