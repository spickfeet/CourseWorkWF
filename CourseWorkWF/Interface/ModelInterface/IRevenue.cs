using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IRevenue
    {
        public decimal Proceeds { get; }
        public DateTime Date { get; }
        public void ChangeRevenue(IRevenueChanger revenueChanger);
    }
}
