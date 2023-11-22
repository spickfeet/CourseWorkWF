namespace CourseWorkWF.Presenters
{
    public class PresenterSell
    {
        private ISell _view;
        private BuyProductsList _buyList;
        public PresenterSell(ISell view, BuyProductsList buyList)
        {
            _view = view;
            _buyList = buyList;
            _view.AddProductEvent += AddProduct;
            _view.SellEvent += SellOut;
        }


        public event EventHandler? AmountErrorEvent;
        public event EventHandler? ProductIDErrorEvent;

        private void AddProduct(object? sender, EventArgs e)
        {
            foreach (Product product in AssortmentList.Instance().ProductsAssortment) // Обход ассортимента 
            {
                if (product.ProductID == _view.ProductID) // поиск по ID
                {
                    if (product.Amount < _view.Amount) // Проверяем колличество товара
                    {
                        AmountErrorEvent?.Invoke(sender, e);
                        return;
                    }
                    for (int i = 0; i < _buyList.BuyProductList.Count; i++) // Проверяем колличество товара при условии, что список покупок не пуст
                    {
                        if (_buyList.BuyProductList[i].ProductID == product.ProductID)
                        {
                            if ((product.Amount - _buyList.BuyProductList[i].Amount - _view.Amount) < 0)
                            {
                                AmountErrorEvent?.Invoke(sender, e);
                                return;
                            }
                        }
                    }
                    _buyList.AddProducts(product, _view.Amount); // Добавляем продукты в список покупок
                    _view.Price += product.Price * _view.Amount; // подсчет цены
                    return;
                }
            }
            ProductIDErrorEvent?.Invoke(sender, e);
        }
        private void SellOut(object? sender, EventArgs e)
        {
            Buy buy = new Buy(_view.TransactionMethod, _view.Price, _view.CashierName,
                _buyList.BuyProductList, _view.Discount);

            _view.Revenue += buy.MoneyAmount; // Увеличение выручки

            AssortmentList.Instance().RemoveProductsListInAssortment(_buyList.BuyProductList);
            _buyList.BuyProductList.Clear(); // Отчистка списка купленных продуктов
        }
    }
}
