using CourseWorkWF.Interface.FilesIterface;
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
                JsonConvert.DeserializeObject<IList<IUser>>(File.ReadAllText("Users.json"), settings) :
                new List<IUser>();
            foreach (var item in users)
            {
                if(item.Login == user.Login)
                {
                    throw new Exception("Пользователь с таким логином существует");
                }
            }
            users.Add(user);
            File.WriteAllText("Users.json", JsonConvert.SerializeObject(users, Formatting.Indented, settings));
        }

        public void Delete(string login)
        {
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
            var users = File.Exists("Users.json") ?
                JsonConvert.DeserializeObject<IList<IUser>>(File.ReadAllText("Users.json"), settings) :
                throw new Exception("Файл не существует");
            foreach (var item in users)
            {
                if (item.Login == login)
                {
                    users.Remove(item);
                    File.WriteAllText("Assortment.json", JsonConvert.SerializeObject(users, Formatting.Indented, settings));
                    return;
                }
            }
            throw new Exception("Пользователь с таким логином не существует");
        }

        public IList<IUser> Load()
        {
            if (File.Exists("Users.json"))
            {
                var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };
                var users = JsonConvert.DeserializeObject<IList<IUser>>(File.ReadAllText("Users.json"), settings);
                return users;
            }
            else
            {
                return new List<IUser>();
            }
        }
    }
}
