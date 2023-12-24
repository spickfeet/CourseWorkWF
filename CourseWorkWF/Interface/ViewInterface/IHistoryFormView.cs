﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface IHistoryFormView
    {
        public string Reason { set; }
        public DateTime SellInfoDateFrom { get; }
        public DateTime SellInfoDateTo { get; }
        public int SelectSellNumber { get; }
        public DateTime RefundInfoDateFrom { get; }
        public DateTime RefundInfoDateTo { get; }
        public int SelectRefundNumber { get; }
        public DateTime RevenueInfoDateFrom { get; }
        public DateTime RevenueInfoDateTo { get; }
    }
}
