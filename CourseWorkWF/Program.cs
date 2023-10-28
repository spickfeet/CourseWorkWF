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
            List<Product> products = new List<Product>();
            Product product1 = new Product(110011, "Сок добрый 1Л", 99);
            Product product2 = new Product(119901, "Сыр", 105);
            Product product3 = new Product(133301, "Молоко 1Л", 79);
            Product product4 = new Product(197801, "Чипсы", 56);
            Product product5 = new Product(219901, "Шоколад", 105);
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
            AssortmentList.Instance().ProductsAssortment = products;


            ApplicationConfiguration.Initialize();

            Application.Run(new User());
        }
    }
}