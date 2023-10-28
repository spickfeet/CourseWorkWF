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

        private List<Product> _productsAssortment/* = new()*/;
        public List<Product> ProductsAssortment { get { return _productsAssortment; } set { _productsAssortment = value; } }
        private AssortmentList(List<Product> productsAssortment)
        {
            ProductsAssortment = productsAssortment;
        }
        public static AssortmentList Instance(List<Product> productsAssortment) // Можно убрать параметры тк _productsAssortment = new()
        {
            if (_instance == null)
                _instance = new AssortmentList(productsAssortment);
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
        public void RemoveProductsInAssortment(List<Product> productList)
        {
            foreach (Product buyProduct in productList)
            {
                ProductsAssortment.Remove(buyProduct);

            }
        }
    }
}
