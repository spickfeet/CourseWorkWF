namespace CourseWorkWF
{
    public partial class AssortmentForm : Form
    {
        private Form _prevForm;
        public AssortmentForm(Form prev)
        {
            _prevForm = prev;
            _prevForm.Hide();
            InitializeComponent();
            FormClosed += OnClosed;
        }

        private void OnClosed(object? sender, FormClosedEventArgs e)
        {
            _prevForm.Visible = true;
        }

        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            AddAssortmentForm addAssortment = new AddAssortmentForm();
            addAssortment.ShowDialog();
            UpdateList();
        }

        private void ButtonLoadAssortment_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void ButtonRemoveProductInAssortment_Click(object sender, EventArgs e)
        {
            RemoveAssortmentForm removeAssortment = new RemoveAssortmentForm();
            removeAssortment.ShowDialog();
            UpdateList();
        }

        private void UpdateList()
        {
            listViewAssortment.Items.Clear();
            for (int i = 0; i < AssortmentList.Instance().ProductsAssortment.Count; i++)
            {
                listViewAssortment.Items.Add(AssortmentList.Instance().ProductsAssortment[i].Name);
                listViewAssortment.Items[i].SubItems.Add(AssortmentList.Instance().ProductsAssortment[i].ProductID.ToString());
                listViewAssortment.Items[i].SubItems.Add(AssortmentList.Instance().ProductsAssortment[i].Price.ToString());
                listViewAssortment.Items[i].SubItems.Add(AssortmentList.Instance().ProductsAssortment[i].Amount.ToString());
            }
        }
    }
}
