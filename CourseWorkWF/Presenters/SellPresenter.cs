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
        private ISellFormView _view;
        private IDictionary<int,IProductsCollectionItem> _assortment;
        private ISellDataBase _sellInfoData;
        private IDiscount _discount;
        private IRefundInfoDataBase _refundInfo;
        private IAssortmentDataBase _assortmentDataBase;
        private IEmployee _employee;
        private IDictionary<int, IProductsCollectionItem> _buyProducts;
        private IRevenue _revenue;
        public SellPresenter(ISellFormView view,IEmployee employee, IRevenue revenue)
        {
            _buyProducts = new Dictionary<int,IProductsCollectionItem>();
            _refundInfo = new RefundInfoDataBase();
            _sellInfoData = new SellInfoDataBase();
            _assortmentDataBase = new AssortmentDataBase();
            _discount = new DiscountPercent(0);
            _assortment = _assortmentDataBase.Load();
            _revenue = revenue;
            _employee = employee;
            _view = view;
            _view.AddProductEvent += AddProduct;
            _view.SellEvent += SellOut;
            _view.DiscountEvent += DiscountUse;
            _view.CashEvent += GetMoneyChangeBuyer;
            _view.CancelBuyProductsEvent += CancelBuyProducts;
        }


        public event EventHandler? AmountErrorEvent;
        public event EventHandler? ProductIDErrorEvent;

        private void CancelBuyProducts(object? sender, EventArgs e)
        {
            _assortment = _assortmentDataBase.Load();
            _buyProducts.Clear();
            _discount.Discount = 0;
        }

        public IDictionary<int, IProductsCollectionItem> GetBuyProductsList()
        {
            return _buyProducts;
        }
        private void GetMoneyChangeBuyer(object? sender, EventArgs e)
        {
            _view.MoneyChangeBuyer = Math.Round(_view.Cash - _view.Price, 2);
        }

        private void DiscountUse(object? sender, EventArgs e)
        {
            _discount.Discount = _view.Discount;
            foreach(var item in _buyProducts.Values)
            {
                item.Product.Price = _discount.UseDiscount(item.Product.Price);
            }
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
            Sell sell = new Sell(_buyProducts, new MoneyOperation(_view.Price, _view.OperationMethod),_discount);

            int number = _sellInfoData.Load().Count + _refundInfo.Load().Count + 1;

            ISellInfo sellInfo = new SellInfo(number, sell, _employee, DateTime.Now);

            _sellInfoData.Add(sellInfo);

            _revenue.ChangeRevenue(sell); // Увеличение выручки
           
            foreach(var item in _buyProducts)
            {
                _assortmentDataBase.Delete(item.Value.Product.ProductID, item.Value.Amount);
            }
            _assortment = _assortmentDataBase.Load();
            _buyProducts.Clear(); // Отчистка списка купленных продуктов
            _discount.Discount = 0;
        }
    }
}
