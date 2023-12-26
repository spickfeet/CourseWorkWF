using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Files
{
    public class DataManager
    {
        public IUser CurrentUser { get; private set; }
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
        public bool LogIn(string login, string password)
        {
            foreach (var user in UserRepository.ReadAll())
            {
                if (user.Key == login && user.Value.Password == HashCodeConvertor.ConvertToHashCode(password + user.Value.Salt))
                {
                    CurrentUser = user.Value;
                    return true;
                }
            }
            return false;
        }
    }
}
