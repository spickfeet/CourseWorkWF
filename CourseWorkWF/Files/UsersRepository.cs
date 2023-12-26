using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Files
{
    public class UsersRepository : IRepository<string, IUser>
    {
        private Dictionary<string, IUser> _users;
        private string _pathName;
        public UsersRepository(string pathName) 
        {
            _pathName = pathName;
            _users = Load();
        }
        public bool Create(IUser user)
        {
            if (user == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (_users.ContainsKey(user.Login))
            {
                return false;
            }
            _users.Add(user.Login, user);
            File.WriteAllText(_pathName, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));
            return true;
        }
        public bool Update(IUser user)
        {
            if (user == null) return false;
            if (_users.ContainsKey(user.Login))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                _users[user.Login] = user;
                File.WriteAllText(_pathName, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));
                return true;
            }
            else
                return false;
        }
        public bool Delete(IUser user)
        {
            if (user == null) return false;
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            if (_users.ContainsKey(user.Login))
            {
                _users.Remove(user.Login);
                File.WriteAllText(_pathName, JsonConvert.SerializeObject(_users, Formatting.Indented, settings));
                return true;
            }
            return false;
        }
        public Dictionary<string, IUser> Load()
        {
            if (File.Exists(_pathName))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var users = JsonConvert.DeserializeObject<Dictionary<string, IUser>>(File.ReadAllText(_pathName), settings);
                if (users != null)
                {
                    return users;
                }
            }
            return new Dictionary<string, IUser>();
        }
        public IReadOnlyDictionary<string, IUser> ReadAll()
        {
            return _users;
        }
    }
}
