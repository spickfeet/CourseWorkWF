using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IRevenue
    {
        decimal Revenue { get; set; }
        void ChangeRevenue(IRevenueChanger revenueChenger);
    }
}
