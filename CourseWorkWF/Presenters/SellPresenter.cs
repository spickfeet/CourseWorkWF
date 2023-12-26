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
        private IDictionary<long, IProductsCollectionItem> _assortment;
        private IDiscount _discount;
        private IRepository<int, IRefundInfo> _refundInfoData;
        private IRepository<int, ISellInfo> _sellInfoData;
        private IRepository<long, IProductsCollectionItem> _assortmentData;
        private IEmployee _employee;
        private IDictionary<long, IProductsCollectionItem> _buyProducts;
        private IRevenue _revenue;
        public SellPresenter(ISellFormView view, IEmployee employee, IRevenue revenue)
        {
            _buyProducts = new Dictionary<long, IProductsCollectionItem>();
            _refundInfoData = new RefundsInfoRepository("RefundsInfo.json");
            _sellInfoData = new SalesInfoRepository("SalesInfo.json");
            _assortmentData = new AssortmentRepository("Assortment.json");
            _discount = new DiscountPercent(0);
            _assortment = _assortmentData.Load();
            _revenue = revenue;
            _employee = employee;
            _view = view;
            _view.EmployeeFullName = employee.FullName.Name + " " + employee.FullName.Surname + " " + employee.FullName.Patronymic;
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
            _buyProducts.Clear();
            _discount.Discount = 0;
        }

        public IDictionary<long, IProductsCollectionItem> GetBuyProductsList()
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
            foreach(var productsCollectionItem in _buyProducts.Values)
            {
                productsCollectionItem.Product.Price = _discount.UseDiscount(productsCollectionItem.Product.Price);
            }
            UpdatePrice();
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

                _buyProducts[_view.ProductID] = new ProductsCollectionItem(_assortment[_view.ProductID].Product.Clone(), _view.Amount); // Добавляем продукты в список покупок
                UpdatePrice();
                return;
            }
            ProductIDErrorEvent?.Invoke(this, EventArgs.Empty);
        }
        private void SellOut(object? sender, EventArgs e)
        {
            Sell sell = new Sell(_buyProducts, new MoneyOperation(_view.Price, _view.OperationMethod),_discount);

            int number = _sellInfoData.Load().Count + _refundInfoData.Load().Count + 1;

            ISellInfo sellInfo = new SellInfo(number, sell, _employee, DateTime.Now);

            _sellInfoData.Create(sellInfo);

            _revenue.ChangeRevenue(sell); // Увеличение выручки
           
            foreach(IProductsCollectionItem productsCollectionItem in _buyProducts.Values)
            {
                _assortmentData.Delete(productsCollectionItem);
            }
            _assortment = _assortmentData.Load();
            _buyProducts.Clear(); // Отчистка списка купленных продуктов
        }
        private void UpdatePrice()
        {
            decimal priceBuf = 0;
            foreach (var item in _buyProducts)
            {
                _view.Price = priceBuf + item.Value.Product.Price * item.Value.Amount;
                priceBuf = item.Value.Product.Price * item.Value.Amount;
            }
            return;
        }
    }
}
