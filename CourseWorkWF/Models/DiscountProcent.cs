using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models
{
    public class DiscountPercent : IDiscount
    {
        private decimal _discount;
        public decimal Discount { get { return _discount; } set { if (value < 0) throw new AccessViolationException("Скидка не может быть меньше отрицательной"); _discount = value; } }

        public decimal UseDiscount(int price)
        {
           return price - (_discount / 100 * price);
        }
    }
}
