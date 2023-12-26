using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using Inf_Bez;
using System.Security.Policy;

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
            IRepository<long, IProductsCollectionItem> assortmentRepository = new AssortmentRepository("Assortment.json");
            IRepository<int, ISellInfo> salesInfoRepository = new SalesInfoRepository("SalesInfo.json");
            IRepository<int, IRefundInfo> RefundsInfoRepository = new RefundsInfoRepository("RefundsInfo.json");
            IRepository<DateTime, IRevenue> RevenuesRepository = new RevenuesRepository("Revenues.json");
            IRepository<string, IUser> UsersRepository = new UsersRepository("Users.json");
            DataManager dataManager = new(assortmentRepository, salesInfoRepository, RefundsInfoRepository, RevenuesRepository, UsersRepository);


            ApplicationConfiguration.Initialize();
            
            Application.Run(new LogInForm());
        }
    }
}