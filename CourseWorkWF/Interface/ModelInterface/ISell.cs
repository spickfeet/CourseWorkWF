﻿using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface ISell 
    {
        IDictionary<int, IProductsCollectionItem> Products { get; set; }
        IMoneyOperation MoneyOperation { get; set; }
    }
}
