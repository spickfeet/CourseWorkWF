using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using Inf_Bez;
using System.Security.Policy;

namespace CourseWorkWF.Views
{
    internal static class Program
    {
        public static IRevenue revenue = new Revenue(0);
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dictionary<int, IProductsCollectionItem> products = new Dictionary<int, IProductsCollectionItem>();
            Product product1 = new("Сок добрый 1Л", 99, 110011);
            Product product2 = new("Сыр", 105, 119901);
            Product product3 = new("Молоко 1Л", 79, 133301);
            Product product4 = new("Чипсы", 56, 197801);
            Product product5 = new("Шоколад", 105, 219901);


            products[110011] = new ProductsCollectionItem(product1, 100);
            products[119901] = new ProductsCollectionItem(product2, 90);
            products[133301] = new ProductsCollectionItem(product3, 80);
            products[197801] = new ProductsCollectionItem(product4, 70);
            products[219901] = new ProductsCollectionItem(product5, 60);
            ApplicationConfiguration.Initialize();
            
            Application.Run(new SignUpForm(null));
        }
    }
}