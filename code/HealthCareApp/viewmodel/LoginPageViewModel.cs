using System.Diagnostics;
using HealthCareApp.DAL;
using HealthCareApp.model;
using System.Security.Cryptography;
using System.Text;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel;

/// <summary>
///     ViewModel for the login page, responsible for handling user authentication
///     and storing user credentials.
/// </summary>
public class LoginPageViewModel
{
    #region Properties

    /// <summary>
    ///     Gets or sets the username of the authenticated user.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    ///     Gets or sets the full name of the authenticated user.
    /// </summary>
    public string UserFullName { get; set; }

    #endregion

    #region Methods

    /// <summary>
    ///     Authenticates the user with the provided username and password.
    /// </summary>
    /// <param name="username">The username of the user attempting to log in.</param>
    /// <param name="password">The password of the user attempting to log in.</param>
    /// <returns>True if authentication is successful; otherwise, false.</returns>
    public bool AuthenticateUser(string username, string password)
    {
        string salt = LoginCredentialDal.GetSaltForUsername(username);

        string hashedPassword = this.HashPassword(password, salt);

        return LoginCredentialDal.AuthenticateUser(username, hashedPassword);
    }

    /// <summary>
    ///     Stores the user's login credentials, including the username and full name.
    /// </summary>
    /// <param name="username">The username of the authenticated user.</param>
    public void StoreLoginCredentials(string username)
    {
        LoggedUser.Username = username;
        LoggedUser.FullName = LoginCredentialDal.GetFullName(username);
    }

    private string HashPassword(string password, string salt)
    {
        // Combine password and salt
        string saltedPassword = password + salt;

        // Hash the salted password with SHA-256
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
            string hashedPassword = Convert.ToBase64String(hashBytes);
            return hashedPassword;
        }
    }

    private string GenerateSalt()
    {
        byte[] saltBytes = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(saltBytes);
        }
        return Convert.ToBase64String(saltBytes);
    }

    #endregion
}