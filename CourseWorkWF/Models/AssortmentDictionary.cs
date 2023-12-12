//using CourseWorkWF.Files;
//using CourseWorkWF.Interface.FilesIterface;
//using CourseWorkWF.Interface.ModelInterface;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Xml.Linq;

//namespace CourseWorkWF.Models
//{
//    public class AssortmentDictionary: IAssortment
//    {
//        private IAssortmentDataBase _assortmentDataBase;
//        private IDictionary<int, IProductsCollectionItem> _productsAssortment;
//        public IAssortmentDataBase AssortmentDataBase { get { return _assortmentDataBase; } }
//        public IDictionary<int, IProductsCollectionItem> ProductsAssortment { get { return _productsAssortment; } set { _productsAssortment = value; } }
//        public AssortmentDictionary()
//        {
//            _assortmentDataBase = new AssortmentDataBase();
//            UpdateAssortment();
//        }
//        public void AddProducts(int productID, string name, decimal price, int amount)
//        {
//            _assortmentDataBase.Add(new ProductsCollectionItem(new Product(name, price, productID), amount));
//            UpdateAssortment();
//        }
//        public void RemoveProducts(int productID, decimal amount)
//        {
//            _assortmentDataBase.Delete(productID, amount);
//            UpdateAssortment();
//        }

//        public void UpdateAssortment()
//        {
//            ProductsAssortment = _assortmentDataBase.Load();
//        }
//    }
//}
