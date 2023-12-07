using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models
{
    public class Proceeds : IRevenue
    {
        public decimal Revenue { get; set; }
        public Proceeds(decimal revenue)
        {
            Revenue = revenue;
        }
        public void ChangeRevenue(IRevenueChanger revenueChenger)
        {
            Revenue = revenueChenger.ChangeRevenue(Revenue);
        }
    }
}
