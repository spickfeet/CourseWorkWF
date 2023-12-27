using CourseWorkWF.Interface.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Views.ViewsControl
{
    public class ViewsController
    {
        private Dictionary<ViewKey, IView> _views;

        private IView _currentView;
        private IView _prevView;

        public IView CurrentView { get { return _currentView; } }
        public IView PrevView { get { return _prevView; } }

        public ViewsController()
        {
            _views = new();
        }
        public void Register(ViewKey key, IView view)
        {
            _views.Add(key, view);
        }
        public void SetCurrentView(ViewKey key)
        {
            if (!_views.ContainsKey(key)) return;

            _currentView = _views[key];
        }

        public void ShowDialog(ViewKey key)
        {
            if (!_views.ContainsKey(key)) return;
            if (_currentView != null)
            {
                _prevView = _currentView;
            }
            _currentView = _views[key];

            _currentView.ShowDialog();
        }

        public void Run()
        {
            _views.Clear();
        }

    }
}
