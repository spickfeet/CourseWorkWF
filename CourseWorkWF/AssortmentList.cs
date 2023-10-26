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
        private static AssortmentList? instance = null;

        private List<Product> _productsAssortment;
        public List<Product> ProductsAssortment { get { return _productsAssortment; } set { _productsAssortment = value; } }
        private AssortmentList(List<Product> productsAssortment)
        {
            ProductsAssortment = productsAssortment;
            instance = this;
        }
        public static AssortmentList Instance(List<Product> productsAssortment)
        {
            instance = new AssortmentList(productsAssortment);
            return instance;
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
