using CourseWorkWF.Interface.ModelInterface;
using CourseWorkWF.Models;
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
            
            Application.Run(new LogInForm());
        }
    }
}