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

        public void AddProducts(int productID, string name, decimal price, int amount)
        {
            for (int i = 0; i < ProductsAssortment.Count; i++)
            {
                if (ProductsAssortment[i].ProductID == productID)
                {
                    ProductsAssortment[i].Amount += amount;
                    return;
                }
            }
            Product product = new Product(productID, name, price, amount);
            ProductsAssortment.Add(product);
        }
        public void RemoveProductsInAssortment(Product product, int amount)
        {
            int index = ProductsAssortment.FindIndex(0, ProductsAssortment.Count, x => x.ProductID == product.ProductID);
            if (ProductsAssortment[index].Amount > amount) ProductsAssortment[index].Amount -= amount;
            else ProductsAssortment.Remove(ProductsAssortment[index]);
        }

        public void RemoveProductsListInAssortment(List<Product> products)
        {
            foreach (Product product in products)
            {
                RemoveProductsInAssortment(product, product.Amount);
            }

        }
    }
}
