using HealthCareApp.View;

namespace HealthCareApp
{
    public class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();

            Application.Run(new LoginPage());

        }
    }
}