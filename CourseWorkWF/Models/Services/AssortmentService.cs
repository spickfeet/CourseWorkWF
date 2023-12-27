using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ServiceInterface.AssortmentServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models.Services
{
    public class AssortmentService : IAssortmentService
    {
        private IDataManager _dataManager;
        public AssortmentService(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }
        public bool Add(string productName, decimal price, long productID, decimal amount)
        {
            return _dataManager.AssortmentRepository.Create(new ProductsCollectionItem(new Product(productName, price, productID), amount));
        }

        public bool ChangePrice(long productID, decimal price)
        {
            if (_dataManager.AssortmentRepository.ReadAll().ContainsKey(productID))
            {
                _dataManager.AssortmentRepository.ReadAll()[productID].Product.Price = price;
                return true;
            }
            return false;
        }
        public bool RemoveProduct(long productID, decimal amount)
        {
            if (_dataManager.AssortmentRepository.ReadAll().ContainsKey(productID) == true)
            {
                _dataManager.AssortmentRepository.Delete(new ProductsCollectionItem(_dataManager.AssortmentRepository.ReadAll()[productID].Product, amount));
                return true;
            }
            return false;
        }
    }
}
