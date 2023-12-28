using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using CourseWorkWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface
{
    public interface ISellService
    {
        public IDictionary<long, IProductsCollectionItem> BuyProducts { get; }
        public decimal Price { get; }
        public void CancelBuyProducts();
        public decimal GetMoneyChangeBuyer(decimal moneyChangeBuyer, decimal price);
        public void DiscountUse(decimal discount);
        public void AddProduct(long productID, decimal amount);
        public void SellOut(OperationMethod operationMethod);
        public void UpdatePrice();
    }
}
