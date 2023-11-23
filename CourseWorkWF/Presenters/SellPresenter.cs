namespace CourseWorkWF.Presenters
{
    public class SellPresenter
    {
        private ISell _view;
        private BuyProductsList _buyProductsList = new();
        public SellPresenter(ISell view)
        {
            _view = view;
            _view.AddProductEvent += AddProduct;
            _view.SellEvent += SellOut;
            _view.DiscountEvent += DiscountUse;
        }


        public event EventHandler? AmountErrorEvent;
        public event EventHandler? ProductIDErrorEvent;


        public BuyProductsList GetBuyProductsList()
        {
            return _buyProductsList;
        }

        private void DiscountUse(object? sender, EventArgs e)
        {
            _view.Price = Math.Round(_view.Price - _view.Price / 100 * _view.Discount, 2); // Применение скидки
        }

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
                    for (int i = 0; i < _buyProductsList.BuyProductList.Count; i++) // Проверяем колличество товара при условии, что список покупок не пуст
                    {
                        if (_buyProductsList.BuyProductList[i].ProductID == product.ProductID)
                        {
                            if ((product.Amount - _buyProductsList.BuyProductList[i].Amount - _view.Amount) < 0)
                            {
                                AmountErrorEvent?.Invoke(sender, e);
                                return;
                            }
                        }
                    }
                    _buyProductsList.AddProducts(product, _view.Amount); // Добавляем продукты в список покупок
                    _view.Price += product.Price * _view.Amount; // подсчет цены
                    return;
                }
            }
            ProductIDErrorEvent?.Invoke(sender, e);
        }
        private void SellOut(object? sender, EventArgs e)
        {
            Buy buy = new Buy(_view.TransactionMethod, _view.Price, _view.CashierName,
                _buyProductsList.BuyProductList, _view.Discount);

            _view.Revenue += buy.MoneyAmount; // Увеличение выручки

            AssortmentList.Instance().RemoveProductsListInAssortment(_buyProductsList.BuyProductList);
            _buyProductsList.BuyProductList.Clear(); // Отчистка списка купленных продуктов
        }
    }
}
