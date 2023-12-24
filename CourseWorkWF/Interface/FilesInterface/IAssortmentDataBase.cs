using CourseWorkWF.Interface.ModelInterface;
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
        public bool Create(IProductsCollectionItem productsCollectionItem);
        public IReadOnlyDictionary<long, IProductsCollectionItem> ReadAll();
        public bool Update(IProductsCollectionItem productsCollectionItem);
        public bool Delete(IProductsCollectionItem productsCollectionItem);
        public Dictionary<long, IProductsCollectionItem> Load();
    }
}
