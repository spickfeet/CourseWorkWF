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
            List<ProductListItem> products = new List<ProductListItem>();
            IProduct product1 = new Product(110011, "Сок добрый 1Л", 99);
            IProduct product2 = new Product(119901, "Сыр", 105);
            IProduct product3 = new Product(133301, "Молоко 1Л", 79);
            IProduct product4 = new Product(197801, "Чипсы", 56);
            IProduct product5 = new Product(219901, "Шоколад", 105);
            products.Add(new ProductListItem(product1,100));
            products.Add(new ProductListItem(product2, 900));
            products.Add(new ProductListItem(product3, 80));
            products.Add(new ProductListItem(product4, 70));
            products.Add(new ProductListItem(product5, 60));
            AssortmentList.Instance().ProductsAssortment = products;


            ApplicationConfiguration.Initialize();

            Application.Run(new UserForm());
        }
    }
}