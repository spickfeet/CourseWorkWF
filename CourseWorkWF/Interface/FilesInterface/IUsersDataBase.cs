using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.FilesInterface
{
    internal interface IUsersDataBase
    {
        public void Add(IUser user);
        public void Delete(string login);
        public IDictionary<string, IUser> Load();
    }
}
