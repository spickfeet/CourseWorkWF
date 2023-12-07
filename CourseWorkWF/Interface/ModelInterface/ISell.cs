﻿using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface ISell 
    {
        int SellID { get; set; }
        IEnumerable<ProductsCollectionItem> Products { get; set; }
        IMoneyOperation MoneyOperation { get; set; }
    }
}
