using CourseWorkWF.Interface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Views
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
            IProduct product1 = new Product("��� ������ 1�", 99, 110011);
            IProduct product2 = new Product("���", 105, 119901);
            IProduct product3 = new Product("������ 1�", 79, 133301);
            IProduct product4 = new Product("�����", 56, 197801);
            IProduct product5 = new Product("�������", 105, 219901);
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