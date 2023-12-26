using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseWorkWF.Files
{
    public class AssortmentRepository : IRepository<long, IProductsCollectionItem>
    {
        private Dictionary<long, IProductsCollectionItem> _assortment;
        private string _pathName;
        public AssortmentRepository(string pathName)
        {
            _assortment = Load();
            _pathName = pathName;
        }
        public bool Create(IProductsCollectionItem productsCollectionItem)
        {
            if (productsCollectionItem == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (_assortment.ContainsKey(productsCollectionItem.Product.ProductID))
                _assortment[productsCollectionItem.Product.ProductID].Amount += productsCollectionItem.Amount;
            else
                _assortment[productsCollectionItem.Product.ProductID] = productsCollectionItem;
            File.WriteAllText(_pathName, JsonConvert.SerializeObject(_assortment, Formatting.Indented, settings));
            return true;

        }
        public bool Update(IProductsCollectionItem productsCollectionItem)
        {
            if (productsCollectionItem == null) return false;
            if (_assortment.ContainsKey(productsCollectionItem.Product.ProductID))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                _assortment[productsCollectionItem.Product.ProductID] = productsCollectionItem;
                File.WriteAllText(_pathName, JsonConvert.SerializeObject(_assortment, Formatting.Indented, settings));
                return true;
            }
            else
                return false;
        }
        public bool Delete(IProductsCollectionItem productsCollectionItem)
        {
            if (productsCollectionItem == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (_assortment.ContainsKey(productsCollectionItem.Product.ProductID))
            {
                if (_assortment[productsCollectionItem.Product.ProductID].Amount - productsCollectionItem.Amount < 1)
                    _assortment.Remove(productsCollectionItem.Product.ProductID);
                else
                    _assortment[productsCollectionItem.Product.ProductID].Amount -= productsCollectionItem.Product.ProductID;
            }
            else 
                return false;              
            File.WriteAllText(_pathName, JsonConvert.SerializeObject(_assortment, Formatting.Indented, settings));
            return true;
        }
        public Dictionary<long, IProductsCollectionItem> Load()
        {
            if (File.Exists(_pathName))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var assortment = JsonConvert.DeserializeObject<Dictionary<long, IProductsCollectionItem>>(File.ReadAllText(_pathName), settings);
                if(assortment != null)
                {
                    return assortment;
                }
            }
            return new Dictionary<long, IProductsCollectionItem>();
        }
        public IReadOnlyDictionary<long, IProductsCollectionItem> ReadAll()
        {
            return _assortment;
        }
    }
}
