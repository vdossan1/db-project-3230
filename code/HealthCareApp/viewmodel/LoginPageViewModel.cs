using HealthCareApp.DAL;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel
{
	/// <summary>
	/// ViewModel for the login page, responsible for handling user authentication 
	/// and storing user credentials.
	/// </summary>
	public class LoginPageViewModel
	{
		/// <summary>
		/// Gets or sets the username of the authenticated user.
		/// </summary>
		public string Username { get; set; }

		/// <summary>
		/// Gets or sets the full name of the authenticated user.
		/// </summary>
		public string UserFullName { get; set; }

		/// <summary>
		/// Authenticates the user with the provided username and password.
		/// </summary>
		/// <param name="username">The username of the user attempting to log in.</param>
		/// <param name="password">The password of the user attempting to log in.</param>
		/// <returns>True if authentication is successful; otherwise, false.</returns>
		public bool AuthenticateUser(string username, string password)
		{
			return LoginCredentialDal.AuthenticateUser(username, password);
		}

		/// <summary>
		/// Stores the user's login credentials, including the username and full name.
		/// </summary>
		/// <param name="username">The username of the authenticated user.</param>
		public void StoreLoginCredentials(string username)
		{
			this.Username = username;
			this.UserFullName = LoginCredentialDal.GetFullName(username);
		}
	}

}
