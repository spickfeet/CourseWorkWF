using CourseWorkWF.Interface.ModelInterface;
using System.Collections.Generic;

namespace CourseWorkWF.Models
{
    public class AssortmentDictionary
    {
        private static AssortmentDictionary? _instance = null;

        private Dictionary<int, ProductsCollectionItem> _productsAssortment;
        public Dictionary<int, ProductsCollectionItem> ProductsAssortment { get { return _productsAssortment; } set { _productsAssortment = value; } }
        private AssortmentDictionary()
        {
            ProductsAssortment = new Dictionary<int, ProductsCollectionItem>();
        }
        public static AssortmentDictionary Instance() // Можно убрать параметры тк _productsAssortment = new()
        {
            if (_instance == null)
                _instance = new AssortmentDictionary();
            return _instance;
        }

        public void AddProducts(int productID, string name, decimal price, int amount)
        {
            IProduct product = new Product(name, price, productID);
            if (ProductsAssortment.ContainsKey(productID) == true)
            {
                ProductsAssortment[productID].Amount += amount;
                return;
            }
            ProductsAssortment[productID] = new ProductsCollectionItem(product, amount);
        }
        public void RemoveProductsInAssortment(int productID, decimal amount)
        {
            if (ProductsAssortment.ContainsKey(productID) == true)
            {
                if (ProductsAssortment[productID].Amount > amount)
                    ProductsAssortment[productID].Amount -= amount;
                else ProductsAssortment.Remove(productID);
            }
        }

        public void RemoveProductsListInAssortment(Dictionary<int, ProductsCollectionItem> products)
        {
            foreach (KeyValuePair<int, ProductsCollectionItem> product in products)
            {
                RemoveProductsInAssortment(product.Key, product.Value.Amount);
            }

        }
    }
}
