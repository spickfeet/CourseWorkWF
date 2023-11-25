namespace CourseWorkWF
{
    public class BuyProductsList
    {
        private List<ProductListItem> _buyProductsList = new();
        public List<ProductListItem> BuyProductList { get { return _buyProductsList; } set { _buyProductsList = value; } }
        public void AddProducts(IProduct product, decimal amount)
        {
            ProductListItem Buyproduct = new ProductListItem(product, amount);

            foreach (ProductListItem productInBuyList in BuyProductList)
            {
                if (productInBuyList.Product == Buyproduct.Product)
                {
                    productInBuyList.Amount += amount;
                    return;
                }
            }
            BuyProductList.Add(Buyproduct); // Добавление продукта в список покупаемых продуктов
        }
    }
}
