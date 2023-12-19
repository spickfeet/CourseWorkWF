﻿using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models
{
    public class Revenue : IRevenue
    {
        public decimal Proceeds { get; set; }
        public Revenue(decimal poceeds)
        {
            Proceeds = poceeds;
        }
        public void ChangeRevenue(IRevenueChanger revenueChanger)
        {
            Proceeds = revenueChanger.ChangeRevenue(Proceeds);
        }
    }
}
