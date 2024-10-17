using System.Diagnostics;
using HealthCareApp.DAL;
using HealthCareApp.model;

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

            var dal = new PatientDal();

            var patients = dal.GetPatients();

            Debug.WriteLine("All the patients using the connected model:");
            PrintEmployees(patients);

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