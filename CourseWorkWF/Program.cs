using CourseWorkWF.Files;
using CourseWorkWF.Interface.FilesInterface;
using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Interface.ViewInterface;
using CourseWorkWF.Models;
using CourseWorkWF.Models.Managers;
using CourseWorkWF.Presenters;
using CourseWorkWF.Views.ViewsControl;
using Inf_Bez;
using System.Security.Policy;

namespace CourseWorkWF.Views
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            IRepository<long, IProductsCollectionItem> assortmentRepository = new AssortmentRepository("Assortment.json");
            IRepository<int, ISellInfo> salesInfoRepository = new SalesInfoRepository("SalesInfo.json");
            IRepository<int, IRefundInfo> RefundsInfoRepository = new RefundsInfoRepository("RefundsInfo.json");
            IRepository<DateTime, IRevenue> RevenuesRepository = new RevenuesRepository("Revenues.json");
            IRepository<string, IUser> UsersRepository = new UsersRepository("Users.json");
            IDataManager dataManager = new DataManager(assortmentRepository, salesInfoRepository, RefundsInfoRepository, RevenuesRepository, UsersRepository);

            dataManager.CurrentRevenue = new Revenue(0, DateTime.Now);

            ViewsController viewsController = new();

            AddAssortmentPresenter addAssortmentPresenter = new (dataManager);
            AssortmentPresenter assortmentPresenter = new (dataManager);
            ChangePricePresenter changePricePresenter = new (dataManager);
            HistoryPresenter historyPresenter = new (dataManager);
            LogInPresenter logInPresenter = new (dataManager);
            MainMenuPresenter mainMenuPresenter = new (dataManager);
            RefundPresenter refundPresenter = new (dataManager);
            RemoveAssortmentPresenter removeAssortmentPresenter = new (dataManager);
            SellPresenter sellPresenter = new (dataManager);
            SignUpPresenter signUpPresenter = new (dataManager);
            UserControllerPresenter userControllerPresenter = new(dataManager);


            IAddAssortmentFormView addAssortmentView = new AddAssortmentForm(viewsController, addAssortmentPresenter);
            addAssortmentPresenter.View = addAssortmentView;
            viewsController.Register(ViewKey.AddAssortment, addAssortmentView);

            IView assortmentView = new AssortmentForm(viewsController, assortmentPresenter);
            viewsController.Register(ViewKey.Assortment, assortmentView);

            IChangePriceFormView changePriceView = new ChangePriceForm(viewsController, changePricePresenter);
            changePricePresenter.View = changePriceView;
            viewsController.Register(ViewKey.ChangePrice, changePriceView);

            IHistoryFormView historyFormView = new HistoryForm(viewsController, historyPresenter);
            historyPresenter.View = historyFormView;
            viewsController.Register(ViewKey.History, historyFormView);

            ILogInFormView logInView = new LogInForm(viewsController, logInPresenter);
            logInPresenter.View = logInView;
            viewsController.Register(ViewKey.LogIn, logInView);

            IView mainMenu = new MainMenuForm(viewsController, mainMenuPresenter);
            viewsController.Register(ViewKey.MainMenu, mainMenu);

            IRefundFormView refundView = new RefundForm(viewsController, refundPresenter);
            refundPresenter.View = refundView;
            viewsController.Register(ViewKey.Refund, refundView);

            IRemoveAssortmentFormView removeAssortmentView = new RemoveAssortmentForm(viewsController, removeAssortmentPresenter);
            removeAssortmentPresenter.View = removeAssortmentView;
            viewsController.Register(ViewKey.RemoveAssortment, removeAssortmentView);

            ISellFormView sellView = new SellForm(viewsController, sellPresenter);
            sellPresenter.View = sellView;
            viewsController.Register(ViewKey.Sell, sellView);

            ISignUpFormView signUpView = new SignUpForm(viewsController, signUpPresenter);
            signUpPresenter.View = signUpView;
            viewsController.Register(ViewKey.SingUp, signUpView);

            IUserControllerFormView userControllerView = new UsersControllerForm(viewsController, userControllerPresenter);
            userControllerPresenter.View = userControllerView;
            viewsController.Register(ViewKey.UserController, userControllerView);

            viewsController.SetCurrentView(ViewKey.LogIn);
            
            Application.Run(viewsController.CurrentView as Form);
        }
    }
}