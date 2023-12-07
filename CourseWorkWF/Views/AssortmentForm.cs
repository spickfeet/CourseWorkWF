using CourseWorkWF.Models;

namespace CourseWorkWF.Views
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
            int column = 0;
            foreach (KeyValuePair<int, ProductsCollectionItem> productCollectionItem in AssortmentDictionary.Instance().ProductsAssortment)
            {
                listViewAssortment.Items.Add(productCollectionItem.Value.Product.Name);
                listViewAssortment.Items[column].SubItems.Add(productCollectionItem.Key.ToString());
                listViewAssortment.Items[column].SubItems.Add(productCollectionItem.Value.Product.Price.ToString());
                listViewAssortment.Items[column].SubItems.Add(productCollectionItem.Value.Amount.ToString());
                column++;
            }
        }
    }
}
