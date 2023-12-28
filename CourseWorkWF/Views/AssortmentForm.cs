using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;

namespace CourseWorkWF.Views
{
    public partial class AssortmentForm : Form, IView
    {
        private AssortmentPresenter _presenter;
        private IViewsController _viewsController;
        public AssortmentForm(IViewsController viewsController, AssortmentPresenter presenter)
        {
            _viewsController = viewsController;
            InitializeComponent();
            _presenter = presenter;
            FormClosed += OnClosed;
        }
        private void OnClosed(object sender, EventArgs e)
        {
            listViewAssortment.Items.Clear();
            _viewsController.Closed();
            _viewsController.PrevView.Visible = true;
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
            int lineIndex = 0;
            foreach (var productCollectionItem in _presenter.Assortment)
            {
                listViewAssortment.Items.Add(productCollectionItem.Value.Product.ProductName);
                listViewAssortment.Items[lineIndex].SubItems.Add(productCollectionItem.Key.ToString());
                listViewAssortment.Items[lineIndex].SubItems.Add(productCollectionItem.Value.Product.Price.ToString());
                listViewAssortment.Items[lineIndex].SubItems.Add(productCollectionItem.Value.Amount.ToString());
                lineIndex++;
            }
        }
    }
}
