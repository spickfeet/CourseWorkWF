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
        IMoneyOperation MoneyOperation { get; set; }
        IDictionary<int, IProductsCollectionItem> Products { get; set; }
        string Reason { get; set; } 
    }
}
