namespace CourseWorkWF
{
    public partial class RemoveAssortment : Form
    {
        public RemoveAssortment()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonRemoveProduct_Click(object sender, EventArgs e)
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                if (product.ProductID == numericUpDownProductID.Value)
                {
                    AssortmentList.Instance().RemoveProductsInAssortment(product, (int)numericUpDownAmount.Value);
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }
            }
            ErrorProviderProductID.SetError(numericUpDownProductID, "Нет продукта с таким ID");
        }
    }
}
