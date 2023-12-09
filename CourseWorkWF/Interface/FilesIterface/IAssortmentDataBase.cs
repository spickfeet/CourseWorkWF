using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.FilesIterface
{
    public interface IAssortmentDataBase
    {
        void Add(IProductsCollectionItem productsCollectionItem);
        void Delete(int productID, decimal amount);
        IDictionary<int, IProductsCollectionItem> Load();
    }
}
