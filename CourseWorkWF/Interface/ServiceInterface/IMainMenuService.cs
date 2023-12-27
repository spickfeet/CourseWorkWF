using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ServiceInterface
{
    public interface IMainMenuService
    {
        public bool TryOpenHistory();
        public bool TryOpenAssortment();
        public bool TryOpenRefund();
        public bool TryOpenUserController();
        public void CloseShift();
    }
}
