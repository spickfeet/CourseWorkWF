﻿using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.FilesInterface
{
    public interface IAssortmentDataBase
    {
        public void Add(IProductsCollectionItem productsCollectionItem);
        public void Delete(IProductsCollectionItem productsCollectionItem);
        public IDictionary<long, IProductsCollectionItem> Load();
    }
}
