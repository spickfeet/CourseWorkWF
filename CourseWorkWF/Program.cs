using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Views
{
    public enum OperationMethod
    {
        Cash,
        Card
    }
    internal static class Program
    {
        public static IRevenue revenue = new Proceeds(0);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dictionary<int, ProductsCollectionItem> products = new Dictionary<int, ProductsCollectionItem>();
            IProduct product1 = new Product("Сок добрый 1Л", 99, 110011);
            IProduct product2 = new Product("Сыр", 105, 119901);
            IProduct product3 = new Product("Молоко 1Л", 79, 133301);
            IProduct product4 = new Product("Чипсы", 56, 197801);
            IProduct product5 = new Product("Шоколад", 105, 219901);
            products[110011] = new ProductsCollectionItem("Сок добрый 1Л", 99, 110011, 100);
            products[119901] = new ProductsCollectionItem("Сыр", 105, 119901, 90);
            products[133301] = new ProductsCollectionItem("Молоко 1Л", 79, 133301, 80);
            products[197801] = new ProductsCollectionItem("Чипсы", 56, 197801, 70);
            products[219901] = new ProductsCollectionItem("Шоколад", 105, 219901, 60);
            AssortmentDictionary.Instance().ProductsAssortment = products;

            ApplicationConfiguration.Initialize();
            
            Application.Run(new UserForm());
        }
    }
}