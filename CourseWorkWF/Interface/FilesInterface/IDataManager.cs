using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.FilesInterface
{
    public interface IDataManager
    {
        public IUser CurrentUser { get; set; }
        public IRevenue CurrentRevenue { get; }
        public IRepository<long, IProductsCollectionItem> AssortmentRepository { get; }
        public IRepository<int, ISellInfo> SalesRepository { get; }
        public IRepository<int, IRefundInfo> RefundsRepository { get; }
        public IRepository<DateTime, IRevenue> RevenueRepository { get; }
        public IRepository<string, IUser> UserRepository { get; }
    }
}
