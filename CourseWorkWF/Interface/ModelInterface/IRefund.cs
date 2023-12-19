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
        public IMoneyOperation MoneyOperation { get; set; }
        public IDictionary<int, IProductsCollectionItem> Products { get; set; }
        public string Reason { get; set; } 
    }
}
