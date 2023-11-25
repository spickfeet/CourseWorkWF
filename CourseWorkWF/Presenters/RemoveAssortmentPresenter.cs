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
            if(AssortmentDictionary.Instance().ProductsAssortment.ContainsKey(_view.ProductID) == true)
            {
                AssortmentDictionary.Instance().RemoveProductsInAssortment(_view.ProductID, _view.Amount);
                return true;
            }
            return false;
        }
    }
}
