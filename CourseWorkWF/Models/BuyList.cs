namespace CourseWorkWF
{
    public class BuyProductsList
    {
        private List<Product> _buyProductsList = new();
        public List<Product> BuyProductList { get { return _buyProductsList; } set { _buyProductsList = value; } }
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
