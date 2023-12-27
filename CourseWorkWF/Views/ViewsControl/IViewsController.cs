using CourseWorkWF.Interface.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Views.ViewsControl
{
    public interface IViewsController
    {
        public IView CurrentView { get; }
        public IView PrevView { get; }
        public void Register(ViewKey key, IView view);
        public void SetCurrentView(ViewKey key);
        public void ShowDialog(ViewKey key);
        public void Run();
        public void Closed();
    }
}
