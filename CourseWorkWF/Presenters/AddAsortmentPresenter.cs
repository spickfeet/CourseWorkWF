namespace CourseWorkWF
{
    public class AddAsortmentPresenter
    {
        private IAddAssortmentFormView _view;

        public AddAsortmentPresenter(IAddAssortmentFormView view)
        {
            _view = view;
            _view.AddProductEvent += AddProductInAssortment;
            _view.AutocompleteEvent += Autocomplete;
        }
        public void AddProductInAssortment(object sender, EventArgs e)
        {
            AssortmentList.Instance().AddProducts(_view.ProductID, _view.ProductName, _view.Price, _view.Amount);
        }
        public void Autocomplete(object sender, EventArgs e)
        {
            foreach (ProductListItem productListItem in AssortmentList.Instance().ProductsAssortment)
            {
                if (productListItem.Product.ProductID == _view.ProductID)
                {
                    _view.ProductName = productListItem.Product.Name;
                    _view.Price = productListItem.Product.Price;
                }
            }
        }
    }
}
