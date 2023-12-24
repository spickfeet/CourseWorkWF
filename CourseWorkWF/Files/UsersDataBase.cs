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
    public class UsersDataBase : IUsersDataBase
    {
        public void Add(IUser user)
        {
            if (user == null) throw new ArgumentException("Передан пустой объект");
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var users = File.Exists("Users.json") ?
                JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText("Users.json"), settings) :
                new Dictionary<string, IUser>();
            if(users.ContainsKey(user.Login))
                throw new Exception("Пользователь с таким логином существует");
            users.Add(user.Login, user);
            File.WriteAllText("Users.json", JsonConvert.SerializeObject(users, Formatting.Indented, settings));
        }

        public void Delete(IUser user)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var users = File.Exists("Users.json") ?
                JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText("Users.json"), settings) :
                throw new Exception("Файл не существует");
            if (users.ContainsKey(user.Login))
            {
                users.Remove(user.Login);
                File.WriteAllText("Users.json", JsonConvert.SerializeObject(users, Formatting.Indented, settings));
                return;
            }
            throw new ArgumentException("Пользователь с таким логином не существует");
        }

        public IDictionary<string, IUser> Load()
        {
            if (File.Exists("Users.json"))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var users = JsonConvert.DeserializeObject<IDictionary<string, IUser>>(File.ReadAllText("Users.json"), settings);
                return users;
            }
            else
            {
                return new Dictionary<string, IUser>();
            }
        }
    }
}
