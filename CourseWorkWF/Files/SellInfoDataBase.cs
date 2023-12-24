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
    public class SellInfoDataBase : ISellInfoDataBase
    {
        public void Add(ISellInfo sellInfo)
        {
            if (sellInfo == null) throw new ArgumentException("Передан пустой объект");
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var salesInfo = File.Exists("SelesInfo.json") ?
                JsonConvert.DeserializeObject<IDictionary<int, ISellInfo>>(File.ReadAllText("SelesInfo.json"), settings) :
                new Dictionary<int, ISellInfo>();
            salesInfo[sellInfo.OperationNumber] = sellInfo;
            File.WriteAllText("SelesInfo.json", JsonConvert.SerializeObject(salesInfo, Formatting.Indented, settings));
        }
        public void Delete(IRefundInfo refundInfo)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var refundsInfo = File.Exists("RefundsInfo.json") ?
                JsonConvert.DeserializeObject<IDictionary<int, IRefundInfo>>(File.ReadAllText("RefundsInfo.json"), settings) :
                throw new Exception("Файл не существует");
            if (refundsInfo.ContainsKey(refundInfo.OperationNumber))
            {
                refundsInfo.Remove(refundInfo.OperationNumber);
                File.WriteAllText("RefundsInfo.json", JsonConvert.SerializeObject(refundsInfo, Formatting.Indented, settings));
                return;
            }
            throw new ArgumentException("Возврата с таким номером чека не существует");
        }
        public IDictionary<int, ISellInfo> Load()
        {
            if (File.Exists("SelesInfo.json"))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var salesInfo = JsonConvert.DeserializeObject<IDictionary<int, ISellInfo>>(File.ReadAllText("SelesInfo.json"), settings);
                return salesInfo;
            }
            else
            {
                return new Dictionary<int, ISellInfo>();
            }
        }
    }
}
