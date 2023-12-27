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
        private IUser _currentUser;
        private IRevenue _currentRevenue;
        private IRepository<long, IProductsCollectionItem> _assortmentRepository;
        private IRepository<int, ISellInfo> _salesRepository;
        private IRepository<int, IRefundInfo> _refundsRepository;
        private IRepository<DateTime, IRevenue> _revenueRepository;
        private IRepository<string, IUser> _userRepository;

        public IUser CurrentUser 
        {
            get { return _currentUser; }
            set { if (value == null) throw new ArgumentNullException("CurrentUser не может быть равен null"); _currentUser = value; } 
        }
        public IRevenue CurrentRevenue 
        {
            get { return _currentRevenue; }
            private set { if (value == null) throw new ArgumentNullException("CurrentRevenue не может быть равен null"); _currentRevenue = value; }
        }
        public IRepository<long, IProductsCollectionItem> AssortmentRepository 
        {
            get { return _assortmentRepository; }
            private set { if (value == null) throw new ArgumentNullException("AssortmentRepository не может быть равен null"); _assortmentRepository = value; }
        }
        public IRepository<int, ISellInfo> SalesRepository 
        {
            get { return _salesRepository; }
            private set { if (value == null) throw new ArgumentNullException("SalesRepository не может быть равен null"); _salesRepository = value; }
        }
        public IRepository<int, IRefundInfo> RefundsRepository 
        {
            get { return _refundsRepository; }
            private set { if (value == null) throw new ArgumentNullException("RefundsRepository не может быть равен null"); _refundsRepository = value; }
        }
        public IRepository<DateTime, IRevenue> RevenueRepository 
        {
            get { return _revenueRepository; }
            private set { if (value == null) throw new ArgumentNullException("RevenueRepository не может быть равен null"); _revenueRepository = value; }
        }
        public IRepository<string, IUser> UserRepository 
        {
            get { return _userRepository; }
            private set { if (value == null) throw new ArgumentNullException("UserRepository не может быть равен null"); _userRepository = value; }
        }
        public DataManager(IRepository<long, IProductsCollectionItem> assortmentRepository, IRepository<int, ISellInfo> salesRepository,
            IRepository<int, IRefundInfo> refundsRepository, IRepository<DateTime, IRevenue> revenueRepository, IRepository<string, IUser> 
            userRepository,IRevenue revenue)
        {
            AssortmentRepository = assortmentRepository;
            SalesRepository = salesRepository;
            RefundsRepository = refundsRepository;
            RevenueRepository = revenueRepository;
            UserRepository = userRepository;
            CurrentRevenue = revenue;
        }
    }
}
