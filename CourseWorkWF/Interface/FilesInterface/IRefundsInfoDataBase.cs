using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.FilesInterface
{
    internal interface IRefundInfoDataBase
    {
        public void Add(IRefundInfo sell);
        public IDictionary<int, IRefundInfo> Load();
    }
}
