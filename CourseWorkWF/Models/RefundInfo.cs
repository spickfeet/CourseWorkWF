﻿using CourseWorkWF.Interface.ModelInterface;
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
        private IRefund _refund;
        private IEmployee _employee;
        public DateTime OperationTime { get; set; }
        public IRefund Refund 
        {
            get { return _refund; }
            set { if (value == null) throw new ArgumentNullException("Refund не может быть null"); _refund = value; }
        }
        public IEmployee Employee
        {
            get { return _employee; }
            set { if (value == null) throw new ArgumentNullException("Employee не может быть null"); _employee = value; }
        }
        public int OperationNumber
        {
            get { return _operationNumber; }
            set { if (value < 1) throw new ArgumentOutOfRangeException("OperationNumber не может быть меньше 1"); _operationNumber = value; }
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