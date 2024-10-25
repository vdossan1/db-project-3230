// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel
{
	/// <summary>
	/// ViewModel for the main page, responsible for storing user information 
	/// such as username and full name.
	/// </summary>
	public class MainPageViewModel
	{
		/// <summary>
		/// Gets or sets the username of the user logged into the application.
		/// </summary>
		public string Username { get; set; }

		/// <summary>
		/// Gets or sets the full name of the user logged into the application.
		/// </summary>
		public string UserFullName { get; set; }
	}
}
