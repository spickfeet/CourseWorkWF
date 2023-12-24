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
    public class RefundInfoDataBase : IRefundInfoDataBase
    {
        public void Add(IRefundInfo refundInfo)
        {
            if (refundInfo == null) throw new ArgumentException("Передан пустой объект");
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var refundsInfo = File.Exists("RefundsInfo.json") ?
                JsonConvert.DeserializeObject<IDictionary<int, IRefundInfo>>(File.ReadAllText("RefundsInfo.json"), settings) :
                new Dictionary<int, IRefundInfo>();
            refundsInfo[refundInfo.OperationNumber] = refundInfo;
            File.WriteAllText("RefundsInfo.json", JsonConvert.SerializeObject(refundsInfo, Formatting.Indented, settings));
        }

        public IDictionary<int, IRefundInfo> Load()
        {
            if (File.Exists("RefundsInfo.json"))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var refundsInfo = JsonConvert.DeserializeObject<IDictionary<int, IRefundInfo>>(File.ReadAllText("RefundsInfo.json"), settings);
                return refundsInfo;
            }
            else
            {
                return new Dictionary<int, IRefundInfo>();
            }
        }
    }
}
