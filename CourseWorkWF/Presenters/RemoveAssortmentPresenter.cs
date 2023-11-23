namespace CourseWorkWF
{
    public class RemoveAssortmentPresenter
    {
        private IRemoveAssortmentFormView _view;
        public RemoveAssortmentPresenter(IRemoveAssortmentFormView view)
        {
            _view = view;
            _view.RemoveProductEvent += RemoveProduct;
        }

        public event EventHandler? ErrorEvent;
        public event EventHandler? CloseEvent;
        public void RemoveProduct(object sender, EventArgs e) 
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment)
            {
                if (product.ProductID == _view.ProductID)
                {
                    AssortmentList.Instance().RemoveProductsInAssortment(product, _view.Amount);
                    CloseEvent?.Invoke(sender, e);
                    return;
                }
            }
            ErrorEvent?.Invoke(sender, e);
        }
    }
}
