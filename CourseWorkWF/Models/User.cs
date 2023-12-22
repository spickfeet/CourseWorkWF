using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Models
{
    public class User : IUser
    {
        private string _login;
        private string _password;
        private string _salt;
        public string Login 
        { 
            get { return _login; } 
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Login не может быть пустым"); _login = value; } 
        }
        public string Password 
        {
            get { return _password; } 
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Password не может быть пустым"); _password = value; } 
        }
        public string Salt
        {
            get { return _salt; }
            set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Salt не может быть пустым"); _salt = value; }
        }
        public IFullName FullName { get; set; }
        public JobTitle Post { get; set; }
        public User(string login, string password, IFullName fullName, JobTitle post, string salt)
        {
            Login = login;
            Password = password;
            FullName = fullName;
            Post = post;
            Salt = salt;
        }
    }
}
