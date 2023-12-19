using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface IRefundFormView
    {
        public string SellInfo { set; }
        public int ReceiptNumber { get; }
        public int SelectedReceiptNumber { get; }
        public DateTime DateFrom { get; }
        public DateTime DateTo { get; }
        public int ProductID { get; }       
        public OperationMethod OperationType { get; }
        public int Amount { get; }
        public string Reason { get; }
    }
}
