using CourseWorkWF.Interface.ModelInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.FilesInterface
{
    internal interface IRevenueDataBase
    {
        public void Add(IRevenue revenue);
        public IList<IRevenue> Load();
    }
}
