using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesIterface;
using CourseWorkWF.Interface.ModelInterface;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace CourseWorkWF.Models
{
    public class AssortmentDictionary: IAssortment
    {
        private IAssortmentDataBase _assortmentDataBase;
        private static AssortmentDictionary? _instance = null;

        private IDictionary<int, IProductsCollectionItem> _productsAssortment;
        public IDictionary<int, IProductsCollectionItem> ProductsAssortment { get { return _productsAssortment; } set { _productsAssortment = value; } }
        private AssortmentDictionary()
        {
            _assortmentDataBase = new AssortmentDataBase();
            if(_assortmentDataBase.Load() == null)
            {
                ProductsAssortment = new Dictionary<int, IProductsCollectionItem>();
            }
            else
                ProductsAssortment = _assortmentDataBase.Load();
        }
        public static AssortmentDictionary Instance() // Можно убрать параметры тк _productsAssortment = new()
        {
            if (_instance == null)
                _instance = new AssortmentDictionary();
            return _instance;
        }

        public void AddProducts(int productID, string name, decimal price, int amount)
        {
            _assortmentDataBase.Add(new ProductsCollectionItem(new Product(name, price, amount), amount));
            ProductsAssortment = _assortmentDataBase.Load();
        }
        public void RemoveProducts(int productID, decimal amount)
        {
            _assortmentDataBase.Delete(productID, amount);
            ProductsAssortment = _assortmentDataBase.Load();
        }
    }
}
