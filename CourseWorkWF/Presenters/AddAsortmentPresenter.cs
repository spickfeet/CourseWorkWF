namespace CourseWorkWF
{
    public class AddAsortmentPresenter
    {
        private IAddAssortmentFormView _view;

        public AddAsortmentPresenter(IAddAssortmentFormView view)
        {
            _view = view;
            //_view.AddProductEvent += AddProductInAssortment;
            _view.AutocompleteEvent += Autocomplete;
        }
        public void AddProductInAssortment()
        {
            AssortmentList.Instance().AddProducts(_view.ProductID, _view.ProductName, _view.Price, _view.Amount);
        }
        public void Autocomplete(object sender, EventArgs e)
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                if (product.ProductID == _view.ProductID)
                {
                    _view.ProductName = product.Name;
                    _view.Price = product.Price;
                }
            }
        }
    }
}
