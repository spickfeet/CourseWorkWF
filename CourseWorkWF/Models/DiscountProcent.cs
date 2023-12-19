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
        public decimal Discount 
        { 
            get { return _discount; } 
            set { if (value < 0 || value > 100) throw new ArgumentOutOfRangeException("Discount должна быть в диапазоне от 0 до 100"); _discount = value; } 
        }

        public decimal UseDiscount(decimal price)
        {
           return price - (_discount / 100 * price);
        }
    }
}
