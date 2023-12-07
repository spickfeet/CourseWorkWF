namespace CourseWorkWF.Models
{
    public class BuyProductsDictionary
    {
        private Dictionary<int, ProductCollectionItem> _buyProductsDictionary = new();
        public Dictionary<int, ProductCollectionItem> BuyProductDictionary { get { return _buyProductsDictionary; } set { _buyProductsDictionary = value; } }
        public void AddProducts(int productID, ProductCollectionItem productListItem)
        {
            if(BuyProductDictionary.ContainsKey(productID) == true)
            {
                BuyProductDictionary[productID].Amount += productListItem.Amount;
                return;
            }
            BuyProductDictionary[productID] = productListItem; // Добавление продукта в список покупаемых продуктов
        }
    }
}
