using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface.AssortmentServiceInterface
{
    public interface IAssortmentAdderService
    {
        public bool Add(string productName, decimal price, long productID, decimal amount);
    }
}
