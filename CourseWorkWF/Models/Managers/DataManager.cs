using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models.Managers
{
    public class DataManager : IDataManager
    {
        public IUser CurrentUser { get; set; }
        public IRevenue CurrentRevenue { get; set; }
        public IRepository<long, IProductsCollectionItem> AssortmentRepository { get; private set; }
        public IRepository<int, ISellInfo> SalesRepository { get; private set; }
        public IRepository<int, IRefundInfo> RefundsRepository { get; private set; }
        public IRepository<DateTime, IRevenue> RevenueRepository { get; private set; }
        public IRepository<string, IUser> UserRepository { get; private set; }
        public DataManager(IRepository<long, IProductsCollectionItem> assortmentRepository, IRepository<int, ISellInfo> salesRepository,
            IRepository<int, IRefundInfo> refundsRepository, IRepository<DateTime, IRevenue> revenueRepository, IRepository<string, IUser> userRepository)
        {
            AssortmentRepository = assortmentRepository;
            SalesRepository = salesRepository;
            RefundsRepository = refundsRepository;
            RevenueRepository = revenueRepository;
            UserRepository = userRepository;
        }
    }
}
