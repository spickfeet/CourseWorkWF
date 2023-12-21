using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Files
{
    public class RevenueDataBase : IRevenueDataBase 
    {
        public void Add(IRevenue revenue)
        {
            if (revenue == null) throw new ArgumentException("Передан пустой объект");
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var revenues = File.Exists("Revenues.json") ?
                JsonConvert.DeserializeObject<IList<IRevenue>>(File.ReadAllText("Revenues.json"), settings) :
                new List<IRevenue>();
            revenues.Add(revenue);
            File.WriteAllText("Revenues.json", JsonConvert.SerializeObject(revenues, Formatting.Indented, settings));
        }   
        public IList<IRevenue> Load()
        {
            if (File.Exists("Revenues.json"))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var revenues = JsonConvert.DeserializeObject<IList<IRevenue>>(File.ReadAllText("Revenues.json"), settings);
                return revenues;
            }
            else
            {
                return new List<IRevenue>();
            }
        }
    }
}
