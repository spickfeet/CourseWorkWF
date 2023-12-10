using CourseWorkWF.Interface.FilesIterface;
using CourseWorkWF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface IAssortment
    {
        IAssortmentDataBase AssortmentDataBase { get; }
        IDictionary<int, IProductsCollectionItem> ProductsAssortment { get; set; }
        void AddProducts(int productID, string name, decimal price, int amount);
        void RemoveProducts(int productID, decimal amount);
        void UpdateAssortment();

    }
}
