using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;

namespace CourseWorkWF.Interface.ModelInterface
{
    public interface ISell 
    {
        public IDictionary<long, IProductsCollectionItem> Products { get; set; }
        public IMoneyOperation MoneyOperation { get; set; }
        public IDiscount Discount { get; set; }
    }
}
