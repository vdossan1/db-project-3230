using System.Security.Cryptography;
using System.Text;

namespace HealthCareApp.utils
{
	public class CredentialHelper
	{
		public static string HashPassword(string password, string salt)
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

		public static string GenerateSalt()
		{
			byte[] saltBytes = new byte[16];
			using (var rng = RandomNumberGenerator.Create())
			{
				rng.GetBytes(saltBytes);
			}
			return Convert.ToBase64String(saltBytes);
		}
	}
}
