namespace CourseWorkWF
{
    public class RemoveAssortmentPresenter
    {
        private IRemoveAssortmentFormView _view;
        public RemoveAssortmentPresenter(IRemoveAssortmentFormView view)
        {
            _view = view;
        }
        public bool RemoveProduct() 
        {
            foreach (ProductListItem productListItem in AssortmentList.Instance().ProductsAssortment)
            {
                if (productListItem.Product.ProductID == _view.ProductID)
                {
                    AssortmentList.Instance().RemoveProductsInAssortment(productListItem.Product, _view.Amount);
                    return true;
                }
            }
            return false;
        }
    }
}
