using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface;
using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models.Services
{
    public class SellService : ISellService
    {
        private IDataManager _dataManager;
        public IDictionary<long, IProductsCollectionItem> BuyProducts { get; private set; }
        public decimal Price { get; private set; }
        private IDiscount _discount;
        public SellService(IDataManager dataManager) 
        {
            Price = 0;
            _dataManager = dataManager;
            BuyProducts = new Dictionary<long, IProductsCollectionItem>();
            _discount = new DiscountPercent(0);
        }
        public void CancelBuyProducts()
        {
            BuyProducts.Clear();
            _discount.Discount = 0;
            Price = 0;
        }

        public decimal GetMoneyChangeBuyer(decimal cash, decimal price)
        {
            return Math.Round(cash - price, 2);
        }

        public void DiscountUse(decimal discount)
        {
            _discount.Discount = discount;
            foreach (var productsCollectionItem in BuyProducts.Values)
            {
                productsCollectionItem.Product.Price = _discount.UseDiscount(productsCollectionItem.Product.Price);
            }
            UpdatePrice();
        }

        public void AddProduct(long productID, decimal amount)
        {
            if (_dataManager.AssortmentRepository.ReadAll().ContainsKey(productID) == true)
            {
                if (_dataManager.AssortmentRepository.ReadAll()[productID].Amount < amount)
                {
                    throw new ArgumentException("В ассортименте нет столько продуктов");
                }
                if (BuyProducts.ContainsKey(productID) == true)
                {
                    if ((_dataManager.AssortmentRepository.ReadAll()[productID].Amount - BuyProducts[productID].Amount - amount) < 0)
                    {
                        throw new ArgumentException("В ассортименте нет столько продуктов");
                    }
                    BuyProducts[productID].Amount += amount;
                    Price += BuyProducts[productID].Product.Price * amount;
                    return;
                }

                BuyProducts[productID] = new ProductsCollectionItem(_dataManager.AssortmentRepository.ReadAll()[productID].Product.Clone(), amount); // Добавляем продукты в список покупок
                Price += BuyProducts[productID].Product.Price * BuyProducts[productID].Amount;
                return;
            }
            throw new ArgumentException("Нет продукта с таким ID");
        }
        public void SellOut(OperationMethod operationMethod)
        {
            Sell sell = new Sell(BuyProducts, new MoneyOperation(Price, operationMethod), _discount);

            int number = _dataManager.SalesRepository.ReadAll().Count + _dataManager.SalesRepository.ReadAll().Count + 1;

            ISellInfo sellInfo = new SellInfo(number, sell, _dataManager.CurrentUser, DateTime.Now);
            _dataManager.SalesRepository.Create(sellInfo);

            _dataManager.CurrentRevenue.ChangeRevenue(sell); // Увеличение выручки

            foreach (IProductsCollectionItem productsCollectionItem in BuyProducts.Values)
            {
                _dataManager.AssortmentRepository.Delete(productsCollectionItem);
            }
            BuyProducts = new Dictionary<long, IProductsCollectionItem>();
        }
        public void UpdatePrice()
        {
            decimal priceBuf = 0;
            foreach (var productsCollectionItem in BuyProducts.Values)
            {
                Price = priceBuf + productsCollectionItem.Product.Price * productsCollectionItem.Amount;
                priceBuf += productsCollectionItem.Product.Price * productsCollectionItem.Amount;
            }
            return;
        }
    }
}
