using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF
{
    public class BuyList
    {
        private List<Product> _buyProductList = new();
        public List<Product> BuyProductList { get { return _buyProductList; } set { _buyProductList = value; } }
        public void AddProducts(Product product, int amount)
        {
            Product Buyproduct = new Product(product);
            Buyproduct.Amount = amount;
            foreach (Product productInBuyList in BuyProductList)
            {
                if (productInBuyList.ProductID == Buyproduct.ProductID)
                {
                    productInBuyList.Amount += amount;
                    return;
                }
            }
            BuyProductList.Add(Buyproduct); // Добавление продукта в список покупаемых продуктов
        }
    }
}
