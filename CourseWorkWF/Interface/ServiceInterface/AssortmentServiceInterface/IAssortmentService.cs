using CourseWorkWF.Interface.ServiceInterface.AssortmentServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface.AssortmentServiceInterface
{
    public interface IAssortmentService : IAssortmentAdderService, IAssortmentRemoverService, IAssortmentChangerPriceService
    {
    }
}
