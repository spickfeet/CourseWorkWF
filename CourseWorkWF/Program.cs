namespace CourseWorkWF
{
    public enum TransactionMethod
    {
        Card,
        Cash,
        SBP
    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //AssortmentList assortmentList = new AssortmentList(new List<Product>());
            ApplicationConfiguration.Initialize();
            Application.Run(new User());
        }
    }
}