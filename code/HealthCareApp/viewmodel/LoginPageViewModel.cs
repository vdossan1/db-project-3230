using HealthCareApp.DAL;

namespace HealthCareApp.viewmodel
{
    public class LoginPageViewModel
    {
		public string Username { get; set; }
		public string UserFullName { get; set; }

		public bool AuthenticateUser(string username, string password)
        {
            return LoginCredentialDal.AuthenticateUser(username, password);
        }

		public void StoreLoginCredentials(string username)
		{
			this.Username = username;
			this.UserFullName = LoginCredentialDal.GetFullName(username);
		}
    }
}
