using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourseWorkWF
{
    public class AssortmentList
    {
        private static AssortmentList? _instance = null;

        private List<Product> _productsAssortment;
        public List<Product> ProductsAssortment { get { return _productsAssortment; } set { _productsAssortment = value; } }
        private AssortmentList()
        {
            ProductsAssortment = new List<Product>();
        }
        public static AssortmentList Instance() // Можно убрать параметры тк _productsAssortment = new()
        {
            if (_instance == null)
                _instance = new AssortmentList();
            return _instance;
        }

        public void AddProductInAssortment(Product product)
        {
            ProductsAssortment.Add(product);
        }
        public void RemoveProductInAssortment(Product product)
        {
            ProductsAssortment.Remove(product);
        }
    }
}
