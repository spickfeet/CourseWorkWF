using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseWorkWF.Files
{
    public class AssortmentDataBase : IAssortmentDataBase
    {

        public void Add(IProductsCollectionItem productsCollectionItem)
        {
            if (productsCollectionItem == null) throw new ArgumentException("Передан пустой объект");
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var assortment = File.Exists("Assortment.json") ? 
                JsonConvert.DeserializeObject<IDictionary<long, IProductsCollectionItem>>(File.ReadAllText("Assortment.json"), settings) : 
                new Dictionary<long, IProductsCollectionItem>();
            if (assortment.ContainsKey(productsCollectionItem.Product.ProductID))
                assortment[productsCollectionItem.Product.ProductID].Amount += productsCollectionItem.Amount;
            else
                assortment[productsCollectionItem.Product.ProductID] = productsCollectionItem;
            File.WriteAllText("Assortment.json", JsonConvert.SerializeObject(assortment,Formatting.Indented, settings));            
        }

        public void Delete(IProductsCollectionItem productsCollectionItem)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var assortment = File.Exists("Assortment.json") ?
                JsonConvert.DeserializeObject<IDictionary<long, IProductsCollectionItem>>(File.ReadAllText("Assortment.json"), settings) :
                throw new Exception("Файл не существует");
            if (assortment.ContainsKey(productsCollectionItem.Product.ProductID))
            {
                if (assortment[productsCollectionItem.Product.ProductID].Amount - productsCollectionItem.Amount < 1)
                    assortment.Remove(productsCollectionItem.Product.ProductID);
                else
                    assortment[productsCollectionItem.Product.ProductID].Amount -= productsCollectionItem.Product.ProductID;
            }
            else
                throw new ArgumentException("В ассортименте нет этого продукта");
                
            File.WriteAllText("Assortment.json", JsonConvert.SerializeObject(assortment, Formatting.Indented, settings));
        }
        public IDictionary<long, IProductsCollectionItem> Load()
        {
            if (File.Exists("Assortment.json"))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var assortment = JsonConvert.DeserializeObject<IDictionary<long, IProductsCollectionItem>>(File.ReadAllText("Assortment.json"), settings);
                return assortment;
            }
            else
            {
                return new Dictionary<long, IProductsCollectionItem>();
            }
        }
    }
}
