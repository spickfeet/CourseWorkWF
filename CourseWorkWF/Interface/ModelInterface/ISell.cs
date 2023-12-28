using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface ISell 
    {
        public IDictionary<long, IProductsCollectionItem> Products { get; }
        public IMoneyOperation MoneyOperation { get; }
        public IDiscount Discount { get; }
    }
}
