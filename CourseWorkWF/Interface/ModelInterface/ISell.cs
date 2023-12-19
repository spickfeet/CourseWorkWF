using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface ISell 
    {
        public IDictionary<int, IProductsCollectionItem> Products { get; set; }
        public IMoneyOperation MoneyOperation { get; set; }
    }
}
