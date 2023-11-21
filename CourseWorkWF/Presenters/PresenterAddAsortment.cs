using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkWF
{
    internal class PresenterAddAsortment
    {
        private AddAssortment _view;

        public PresenterAddAsortment(AddAssortment form)
        {
            _view = form;
            _view.addAssortmentEvent += Handler1;
        }
        public void Handler1(object sender, EventArgs e)
        {
            AssortmentList.Instance().AddProductInAssortment((int)_view.numericUpDownProductID.Value, textBoxProductName.Text, (double)numericUpDownProductPrice.Value, (int)numericUpDownAmount.Value);
        }
    }
}
