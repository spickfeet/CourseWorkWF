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
    public class RefundInfoRepository : IRepository<int, IRefundInfo>
    {
        private Dictionary<int, IRefundInfo> _refundInfo;
        private string _pathName;
        public RefundInfoRepository(string pathName)
        {
            _pathName = pathName;
            _refundInfo = Load();
        }
        public bool Create(IRefundInfo sellInfo)
        {
            if (sellInfo == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _refundInfo[sellInfo.OperationNumber] = sellInfo;
            File.WriteAllText(_pathName, JsonConvert.SerializeObject(_refundInfo, Formatting.Indented, settings));
            return true;
        }
        public bool Update(IRefundInfo sellInfo)
        {
            if (sellInfo == null) return false;
            if (_refundInfo.ContainsKey(sellInfo.OperationNumber))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                _refundInfo[sellInfo.OperationNumber] = sellInfo;
                File.WriteAllText(_pathName, JsonConvert.SerializeObject(_refundInfo, Formatting.Indented, settings));
                return true;
            }
            return false;
        }
        public bool Delete(IRefundInfo sellInfo)
        {
            if (sellInfo == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (_refundInfo.ContainsKey(sellInfo.OperationNumber))
            {
                if (sellInfo.OperationTime.AddYears(5) <= DateTime.Now)
                {
                    _refundInfo.Remove(sellInfo.OperationNumber);
                    File.WriteAllText(_pathName, JsonConvert.SerializeObject(_refundInfo, Formatting.Indented, settings));
                    return true;
                }
            }
            return false;
        }
        public Dictionary<int, IRefundInfo> Load()
        {
            if (File.Exists(_pathName))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var refundInfo = JsonConvert.DeserializeObject<Dictionary<int, IRefundInfo>>(File.ReadAllText(_pathName), settings);
                if (refundInfo != null)
                {
                    return refundInfo;
                }
            }
            return new Dictionary<int, IRefundInfo>();
        }
        public IReadOnlyDictionary<int, IRefundInfo> ReadAll()
        {
            return _refundInfo;
        }
    }
}
