using CourseWorkWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IRefund
    {
        public IMoneyOperation MoneyOperation { get; }
        public IDictionary<long, IProductsCollectionItem> Products { get; }
        public string Reason { get; } 
    }
}
