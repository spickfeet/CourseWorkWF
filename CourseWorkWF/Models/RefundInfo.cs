using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models
{
    public class RefundInfo : IRefundInfo
    {
        private int _operationNumber;
        private IEmployee _employee;
        private IRefund _refund;
        public DateTime OperationTime { get; set; }
        public IRefund Refund 
        {
            get { return _refund; }
            private set { if (value == null) throw new ArgumentNullException("Refund не может быть null"); _refund = value; }
        }
        public IEmployee Employee
        {
            get { return _employee; }
            private set { if (value == null) throw new ArgumentNullException("Employee не может быть null"); _employee = value; }
        }
        public int OperationNumber
        {
            get { return _operationNumber; }
            private set { if (value < 1) throw new ArgumentOutOfRangeException("OperationNumber не может быть меньше 1"); _operationNumber = value; }
        }
        public RefundInfo(int operationNumber, IRefund refund, IEmployee employee, DateTime operationTime)
        {
            OperationNumber = operationNumber;
            Refund = refund;
            Employee = employee;
            OperationTime = operationTime;
        }
    }
}
