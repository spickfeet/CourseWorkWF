using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;

namespace CourseWorkWF.Views
{
    public partial class AssortmentForm : Form, IView
    {
        private Form _prevForm;
        private AssortmentPresenter _presenter;
        private ViewsController _viewsController;
        public AssortmentForm(ViewsController viewsController, AssortmentPresenter presenter)
        {
            _viewsController = viewsController;
            InitializeComponent();
            _presenter = presenter;
        }

        private void AddProductInAssortmentButton_Click(object sender, EventArgs e)
        {
            _viewsController.ShowDialog(ViewKey.AddAssortment);
            UpdateList();
        }

        private void ButtonLoadAssortment_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void ButtonRemoveProductInAssortment_Click(object sender, EventArgs e)
        {
            _viewsController.ShowDialog(ViewKey.RemoveAssortment);
            UpdateList();
        }

        private void ButtonChangePrice_Click(object sender, EventArgs e)
        {
            _viewsController.ShowDialog(ViewKey.ChangePrice);
            UpdateList();
        }

        private void UpdateList()
        {
            listViewAssortment.Items.Clear();
            int line = 0;
            foreach (var productCollectionItem in _presenter.Assortment)
            {
                listViewAssortment.Items.Add(productCollectionItem.Value.Product.ProductName);
                listViewAssortment.Items[line].SubItems.Add(productCollectionItem.Key.ToString());
                listViewAssortment.Items[line].SubItems.Add(productCollectionItem.Value.Product.Price.ToString());
                listViewAssortment.Items[line].SubItems.Add(productCollectionItem.Value.Amount.ToString());
                line++;
            }
        }
    }
}
