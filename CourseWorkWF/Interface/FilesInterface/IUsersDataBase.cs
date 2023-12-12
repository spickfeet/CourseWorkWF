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
        void Add(IUser user);
        void Delete(string login);
        IList<IUser> Load();
    }
}
