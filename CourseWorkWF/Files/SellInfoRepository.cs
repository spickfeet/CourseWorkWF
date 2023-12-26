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
    public class SellInfoRepository : IRepository<int, ISellInfo>
    {
        private Dictionary<int, ISellInfo> _salesInfo;
        private string _pathName;
        public SellInfoRepository(string pathName)
        {
            _salesInfo = Load();
            _pathName = pathName;
        }
        public bool Create(ISellInfo sellInfo)
        {
            if (sellInfo == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _salesInfo[sellInfo.OperationNumber] = sellInfo;
            File.WriteAllText(_pathName, JsonConvert.SerializeObject(_salesInfo, Formatting.Indented, settings));
            return true;
        }
        public bool Update(ISellInfo sellInfo)
        {
            if (sellInfo == null) return false;
            if (_salesInfo.ContainsKey(sellInfo.OperationNumber))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                _salesInfo[sellInfo.OperationNumber] = sellInfo;
                File.WriteAllText(_pathName, JsonConvert.SerializeObject(_salesInfo, Formatting.Indented, settings));
                return true;
            }
            return false;
        }
        public bool Delete(ISellInfo sellInfo)
        {
            if (sellInfo == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (_salesInfo.ContainsKey(sellInfo.OperationNumber))
            {
                if(sellInfo.OperationTime.AddYears(5) <= DateTime.Now)
                {
                    _salesInfo.Remove(sellInfo.OperationNumber);
                    File.WriteAllText(_pathName, JsonConvert.SerializeObject(_salesInfo, Formatting.Indented, settings));
                    return true;
                }
            }
            return false;
        }
        public Dictionary<int, ISellInfo> Load()
        {
            if (File.Exists(_pathName))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var salesInfo = JsonConvert.DeserializeObject<Dictionary<int, ISellInfo>>(File.ReadAllText(_pathName), settings);
                if (salesInfo != null)
                {
                    return salesInfo;
                }
            }
            return new Dictionary<int, ISellInfo>();
        }
        public IReadOnlyDictionary<int, ISellInfo> ReadAll()
        {
            return _salesInfo;
        }
    }
}
