using System.Diagnostics;
using HealthCareApp.model;
using HealthCareApp.view;
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

        private static void PrintEmployees(List<Patient> patients)
        {
            Debug.WriteLine("====================================");
            foreach (var patient in patients)
            {
                Debug.WriteLine(patient.FirstName + "\t\t" + patient.LastName + "\t\t" + patient.DateOfBirth);
            }
        }
    }
}