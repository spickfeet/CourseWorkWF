using CourseWorkWF.Interface.FilesInterface;
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
        public IAssortmentDataBase AssortmentDataBase { get; }
        public IDictionary<int, IProductsCollectionItem> ProductsAssortment { get; set; }
        public void AddProducts(int productID, string name, decimal price, int amount);
        public void RemoveProducts(int productID, decimal amount);
        public void UpdateAssortment();

    }
}
