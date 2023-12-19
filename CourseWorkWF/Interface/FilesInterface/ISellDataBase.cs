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
        public void Add(ISellInfo sell);
        public IDictionary<int,ISellInfo> Load();
    }
}
