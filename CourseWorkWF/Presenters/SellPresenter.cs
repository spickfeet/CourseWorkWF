using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Views;
using Microsoft.VisualBasic.ApplicationServices;

namespace CourseWorkWF.Presenters
{
    public class SellPresenter
    {
        private IDictionary<int,IProductsCollectionItem> _assortment;
        private ISellDataBase _sellData;
        private IAssortmentDataBase _assortmentDataBase;
        private ISellFormView _view;
        private IUser _user;
        private Dictionary<int,IProductsCollectionItem> _buyProducts = new();
        public SellPresenter(ISellFormView view,IUser user)
        {
            _sellData = new SellInfoDataBase();
            _assortmentDataBase = new AssortmentDataBase();
            _assortment = _assortmentDataBase.Load();
            _user = user;
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

        public Dictionary<int, IProductsCollectionItem> GetBuyProductsList()
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
            if (_assortment.ContainsKey(_view.ProductID) == true)
            {
                if (_assortment[_view.ProductID].Amount < _view.Amount)
                {
                    AmountErrorEvent?.Invoke(this, EventArgs.Empty);
                    return;
                }
                if(_buyProducts.ContainsKey(_view.ProductID) == true)
                {
                    if ((_assortment[_view.ProductID].Amount - _buyProducts[_view.ProductID].Amount - _view.Amount) < 0)
                    {
                        AmountErrorEvent?.Invoke(this, EventArgs.Empty);
                        return;
                    }
                    _buyProducts[_view.ProductID].Amount += _view.Amount;
                    _view.Price += _buyProducts[_view.ProductID].Product.Price * _view.Amount;
                    return;
                }
                
                _buyProducts[_view.ProductID] = new ProductsCollectionItem(_assortment[_view.ProductID].Product, _view.Amount); // Добавляем продукты в список покупок
                decimal priceBuf = 0;
                foreach (var item in _buyProducts)
                {
                    _view.Price = priceBuf + item.Value.Product.Price * item.Value.Amount;
                    priceBuf = item.Value.Product.Price * item.Value.Amount;
                }
                return;
            }
            ProductIDErrorEvent?.Invoke(this, EventArgs.Empty);
        }
        private void SellOut(object? sender, EventArgs e)
        {
            IList<IProductsCollectionItem> products = new List<IProductsCollectionItem>();
            foreach(var item in _buyProducts) 
            {
                products.Add(item.Value);
            }

            Sell sell = new Sell(products, new MoneyOperation(_view.Price, _view.OperationMethod));
            int num = _sellData.Load().Count + 1;

            ISellInfo sellInfo = new SellInfo(num, sell, _user,DateTime.Now);
            _sellData.Add(sellInfo);

            Program.revenue.ChangeRevenue(sell); // Увеличение выручки
           
            foreach(IProductsCollectionItem item in products)
            {
                _assortmentDataBase.Delete(item.Product.ProductID, item.Amount);
            }
            _assortment = _assortmentDataBase.Load();
            _buyProducts.Clear(); // Отчистка списка купленных продуктов
        }
    }
}
