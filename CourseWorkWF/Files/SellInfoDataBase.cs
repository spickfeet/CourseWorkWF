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
    public class SellInfoDataBase : ISellDataBase
    {
        public void Add(ISellInfo sellInfo)
        {
            if (sellInfo == null) throw new ArgumentException("Передан пустой объект");
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var salesInfo = File.Exists("SelesInfo.json") ?
                JsonConvert.DeserializeObject<IList<ISellInfo>>(File.ReadAllText("SelesInfo.json"), settings) :
                new List<ISellInfo>();
            salesInfo.Add(sellInfo);
            File.WriteAllText("SelesInfo.json", JsonConvert.SerializeObject(salesInfo, Formatting.Indented, settings));
        }

        public IList<ISellInfo> Load()
        {
            if (File.Exists("SelesInfo.json"))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var salesInfo = JsonConvert.DeserializeObject<IList<ISellInfo>>(File.ReadAllText("SelesInfo.json"), settings);
                return salesInfo;
            }
            else
            {
                return new List<ISellInfo>();
            }
        }
    }
}
