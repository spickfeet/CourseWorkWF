using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Files
{
    public class SellDataBase : ISellDataBase
    {
        public void Add(ISell sell)
        {
            if (sell == null) throw new ArgumentException("Передан пустой объект");
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var sales = File.Exists("Seles.json") ?
                JsonConvert.DeserializeObject<IList<ISell>>(File.ReadAllText("Seles.json"), settings) :
                new List<ISell>();
            sales.Add(sell);
            File.WriteAllText("Seles.json", JsonConvert.SerializeObject(sales, Formatting.Indented, settings));
        }

        public IList<ISell> Load()
        {
            if (File.Exists("Seles.json"))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var sales = JsonConvert.DeserializeObject<IList<ISell>>(File.ReadAllText("Seles.json"), settings);
                return sales;
            }
            else
            {
                return new List<ISell>();
            }
        }
    }
}
