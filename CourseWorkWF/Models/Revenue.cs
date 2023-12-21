using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models
{
    public class Revenue : IRevenue
    {
        public decimal Proceeds { get; private set; }
        public DateTime Date { get; private set; }
        public Revenue(decimal proceeds, DateTime date)
        {
            Proceeds = proceeds;
            Date = date;
        }
        public void ChangeRevenue(IRevenueChanger revenueChanger)
        {
            Proceeds = revenueChanger.ChangeRevenue(Proceeds);
        }
    }
}
