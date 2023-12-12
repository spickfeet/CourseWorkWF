using CourseWorkWF.Interface.ModelInterface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models
{
    public class SellInfo : ISellInfo
    {
        private int _operationNumber;
        private ISell _sell;
        private IEmployee _employee;
        public ISell Sell { 
            get { return _sell; }
            set { if (value == null) throw new ArgumentNullException("Sell не может быть null"); _sell = value; }
        }
        public DateTime OperationTime { get; set; }
        public IEmployee Employee
        {
            get { return _employee; }
            set { if (value == null) throw new ArgumentNullException("Employee не может быть null"); _employee = value; }
        }
        public int OperationNumber {
            get { return _operationNumber; }
            set { if (value < 1) throw new ArgumentOutOfRangeException("OperationNumber не может быть меньше 1"); _operationNumber = value; }
        }

        public SellInfo(int operationNumber, ISell sell , IEmployee employee, DateTime operationTime )
        {
            OperationNumber = operationNumber;
            Sell = sell;
            Employee = employee;
            OperationTime = operationTime;
        }
    }
}
