using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Views;

namespace CourseWorkWF.Presenters
{
    public class SellPresenter
    {
        private ISellFormView _view;
        private Dictionary<int,ProductsCollectionItem> _buyProducts = new();
        public SellPresenter(ISellFormView view)
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
            _buyProducts.Clear();
        }

        public Dictionary<int, ProductsCollectionItem> GetBuyProductsList()
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
                if(_buyProducts.ContainsKey(_view.ProductID) == true)
                {
                    if ((AssortmentDictionary.Instance().ProductsAssortment[_view.ProductID].Amount - _buyProducts[_view.ProductID].Amount - _view.Amount) < 0)
                    {
                        AmountErrorEvent?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                    _buyProducts[_view.ProductID].Amount += _view.Amount;
                    _view.Price += _buyProducts[_view.ProductID].Product.Price * _view.Amount;
                    return;
                }
                
                _buyProducts[_view.ProductID] = new ProductsCollectionItem(AssortmentDictionary.Instance().ProductsAssortment[_view.ProductID].Product,_view.Amount); // Добавляем продукты в список покупок
                _view.Price += _buyProducts[_view.ProductID].Product.Price * _view.Amount; // подсчет цены
                return;
            }
            ProductIDErrorEvent?.Invoke(this, EventArgs.Empty);
        }
        private void SellOut(object? sender, EventArgs e)
        {
            List<ProductsCollectionItem> products = new List<ProductsCollectionItem>();
            foreach(var item in _buyProducts) 
            {
                products.Add(item.Value);
            }
            Sell sell = new Sell(1, products, _view.Price, _view.OperationMethod);

            Program.revenue.ChangeRevenue(sell); // Увеличение выручки

            AssortmentDictionary.Instance().RemoveProductsListInAssortment(_buyProducts);
            _buyProducts.Clear(); // Отчистка списка купленных продуктов
        }
    }
}
