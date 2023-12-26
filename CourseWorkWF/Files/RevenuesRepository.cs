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
    public class RevenuesRepository : IRepository<DateTime, IRevenue>
    {
        private string _pathName;
        private Dictionary<DateTime, IRevenue> _revenues;

        public RevenuesRepository(string pathName) 
        {
            _pathName = pathName;
            _revenues = Load();
        }
        public bool Create(IRevenue revenue)
        {
            if (revenue == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            _revenues.Add(revenue.Date, revenue);
            File.WriteAllText(_pathName, JsonConvert.SerializeObject(_revenues, Formatting.Indented, settings));
            return true;
        }
        public bool Delete(IRevenue revenue)
        {
            if (revenue == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (_revenues.ContainsKey(revenue.Date))
            {
                if (revenue.Date.AddYears(5) <= DateTime.Now)
                {
                    _revenues.Remove(revenue.Date);
                    File.WriteAllText(_pathName, JsonConvert.SerializeObject(_revenues, Formatting.Indented, settings));
                    return true;
                }
            }
            return false;
        }
        public bool Update(IRevenue revenue)
        {
            if (revenue == null) return false;
            if (_revenues.ContainsKey(revenue.Date))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                _revenues[revenue.Date] = revenue;
                File.WriteAllText(_pathName, JsonConvert.SerializeObject(_revenues, Formatting.Indented, settings));
                return true;
            }
            return false;
        }
        public Dictionary<DateTime, IRevenue> Load()
        {
            if (File.Exists(_pathName))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var revenues = JsonConvert.DeserializeObject<Dictionary<DateTime, IRevenue>>(File.ReadAllText(_pathName), settings);
                if(revenues != null)
                {
                    return revenues;
                }
            }
            return new Dictionary<DateTime, IRevenue>();
        }
        public IReadOnlyDictionary<DateTime, IRevenue> ReadAll()
        {
            return _revenues;
        }
    }
}
