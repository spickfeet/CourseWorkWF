using CourseWorkWF.Interface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Presenters
{
    public class SellPresenter
    {
        private ISell _view;
        private BuyProductsDictionary _buyProducts = new();
        public SellPresenter(ISell view)
        {
            _view = view;
            _view.AddProductEvent += AddProduct;
            _view.SellEvent += SellOut;
            _view.DiscountEvent += DiscountUse;
            _view.CancelDiscountEvent += CancelDiscount;
            _view.CashEvent += GetMoneyChangeBuyer;
            _view.CancelBuyProductsEvent += CancelBuyProducts;
        }


        public event EventHandler? AmountErrorEvent;
        public event EventHandler? ProductIDErrorEvent;

        private void CancelBuyProducts(object? sender, EventArgs e)
        {
            _buyProducts.BuyProductDictionary.Clear();
        }

        public BuyProductsDictionary GetBuyProductsList()
        {
            return _buyProducts;
        }
        private void GetMoneyChangeBuyer(object? sender, EventArgs e)
        {
            _view.MoneyChangeBuyer = Math.Round(_view.Cash - _view.Price, 2);
        }

        private void CancelDiscount(object? sender, EventArgs e)
        {
            _view.Price = Math.Round(_view.Price / (100 - _view.Discount) * 100, 2); // Отмена скидки
        }

        private void DiscountUse(object? sender, EventArgs e)
        {
            _view.Price = Math.Round(_view.Price - _view.Price / 100 * _view.Discount, 2); // Применение скидки
        }

        private void AddProduct(object? sender, EventArgs e)
        {
            if(AssortmentDictionary.Instance().ProductsAssortment.ContainsKey(_view.ProductID) == true)
            {
                if (AssortmentDictionary.Instance().ProductsAssortment[_view.ProductID].Amount < _view.Amount)
                {
                    AmountErrorEvent?.Invoke(this, EventArgs.Empty);
                    return;
                }
                if(_buyProducts.BuyProductDictionary.ContainsKey(_view.ProductID) == true)
                {
                    if ((AssortmentDictionary.Instance().ProductsAssortment[_view.ProductID].Amount - _buyProducts.BuyProductDictionary[_view.ProductID].Amount - _view.Amount) < 0)
                    {
                        AmountErrorEvent?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                }
                
                _buyProducts.AddProducts(_view.ProductID, new ProductCollectionItem(AssortmentDictionary.Instance().ProductsAssortment[_view.ProductID].Product,_view.Amount)); // Добавляем продукты в список покупок
                _view.Price += AssortmentDictionary.Instance().ProductsAssortment[_view.ProductID].Product.Price * _view.Amount; // подсчет цены
                return;
            }
            ProductIDErrorEvent?.Invoke(this, EventArgs.Empty);
        }
        private void SellOut(object? sender, EventArgs e)
        {
            Sell buy = new Sell(_buyProducts.BuyProductDictionary, _view.TransactionMethod, _view.Price, _view.CashierName, _view.Discount);

            _view.Revenue += buy.MoneyAmount; // Увеличение выручки

            AssortmentDictionary.Instance().RemoveProductsListInAssortment(_buyProducts.BuyProductDictionary);
            _buyProducts.BuyProductDictionary.Clear(); // Отчистка списка купленных продуктов
        }
    }
}
