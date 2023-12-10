using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface ISellReceipt
    {
        int SellReceiptID { get; set; }
        IDiscount discount { get; set; }
        IFullName fullName { get; set; }
        DateTime SellTime { get; set; }
    }
}
