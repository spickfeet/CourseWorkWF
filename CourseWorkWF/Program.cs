namespace CourseWorkWF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dictionary<int, ProductCollectionItem> products = new Dictionary<int, ProductCollectionItem>();
            IProduct product1 = new Product("Сок добрый 1Л", 99);
            IProduct product2 = new Product("Сыр", 105);
            IProduct product3 = new Product("Молоко 1Л", 79);
            IProduct product4 = new Product("Чипсы", 56);
            IProduct product5 = new Product("Шоколад", 105);
            products[110011] = new ProductCollectionItem(product1, 100);
            products[119901] = new ProductCollectionItem(product2, 90);
            products[133301] = new ProductCollectionItem(product3, 80);
            products[197801] = new ProductCollectionItem(product4, 70);
            products[219901] = new ProductCollectionItem(product5, 60);
            AssortmentDictionary.Instance().ProductsAssortment = products;


            ApplicationConfiguration.Initialize();

            Application.Run(new UserForm());
        }
    }
}