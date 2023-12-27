using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF.Interface.ViewInterface
{
    public interface IView
    {
        public bool Visible { get; set; }
        public DialogResult ShowDialog();
        public void Hide();
        public void Close();
        public event FormClosedEventHandler FormClosed;
    }
}
