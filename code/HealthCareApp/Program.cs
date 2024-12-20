using System.Security.Cryptography;
using HealthCareApp.View;
using System.Text;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp;

public class Program
{
    #region Methods

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    public static void Main()
    {
        ApplicationConfiguration.Initialize();

        Application.Run(new LoginPage());
    }

    #endregion
}