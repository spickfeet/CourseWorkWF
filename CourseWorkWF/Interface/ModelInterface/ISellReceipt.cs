using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface ISellReceipt
    {
        public int SellReceiptID { get; set; }
        public IDiscount discount { get; set; }
        public IFullName fullName { get; set; }
        public DateTime SellTime { get; set; }
    }
}
