using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.FilesInterface
{
    public interface ISellDataBase
    {
        void Add(ISellInfo sell);
        IList<ISellInfo> Load();
    }
}
