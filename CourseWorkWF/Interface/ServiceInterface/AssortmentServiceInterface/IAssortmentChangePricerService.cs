using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface.AssortmentServiceInterface
{
    public interface IAssortmentChangerPriceService
    {
        public bool ChangePrice(long productID, decimal price);
    }
}
