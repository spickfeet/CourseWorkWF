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
        void Add(IRefundInfo sell);
        IDictionary<int, IRefundInfo> Load();
    }
}
