namespace CourseWorkWF
{
    public class AssortmentList
    {
        private static AssortmentList? _instance = null;

        private List<ProductListItem> _productsAssortment;
        public List<ProductListItem> ProductsAssortment { get { return _productsAssortment; } set { _productsAssortment = value; } }
        private AssortmentList()
        {
            ProductsAssortment = new List<ProductListItem>();
        }
        public static AssortmentList Instance() // Можно убрать параметры тк _productsAssortment = new()
        {
            if (_instance == null)
                _instance = new AssortmentList();
            return _instance;
        }

        public void AddProducts(int productID, string name, decimal price, int amount)
        {
            IProduct product = new Product(productID, name, price);

            foreach (ProductListItem productInAssortment in ProductsAssortment)
            {
                if(productInAssortment.Product.ProductID == product.ProductID)
                {
                    productInAssortment.Amount += amount;
                    return;
                }               
            }
            ProductsAssortment.Add(new ProductListItem(product,amount));
        }
        public void RemoveProductsInAssortment(IProduct product, decimal amount)
        {
            foreach(ProductListItem productInAssortment in ProductsAssortment)
            {
                if (productInAssortment.Product.ProductID == product.ProductID)
                {
                    if (productInAssortment.Amount > amount)
                        productInAssortment.Amount -= amount;
                    else ProductsAssortment.Remove(productInAssortment);
                }
            }
        }

        public void RemoveProductsListInAssortment(List<ProductListItem> products)
        {
            foreach (ProductListItem productListItem in products)
            {
                RemoveProductsInAssortment(productListItem.Product, productListItem.Amount);
            }

        }
    }
}
