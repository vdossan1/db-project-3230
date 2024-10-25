// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.model
{
	/// <summary>
	/// The LoginCredential Class.
	/// </summary>
	public class LoginCredential
    {
	    /// <summary>
	    /// Gets the username used by the user for system login.
	    /// </summary>
		public string Username { get; }

        /// <summary>
        /// Gets the password used by the user for system login.
        /// </summary>
		public string Password { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCredential"/> class with the specified details.
        /// </summary>
		public LoginCredential(string username, string password)
        {
            this.Username = username ?? throw new ArgumentNullException(nameof(username));
            this.Password = password ?? throw new ArgumentNullException(nameof(password));
        }
    }
}
