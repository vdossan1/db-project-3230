using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareApp.DAL;

namespace HealthCareApp.viewmodel
{
    public class LoginPageViewModel
    {

        public bool TryLogin(string username, string password)
        {
            return LoginCredentialDal.AuthenticateUser(username, password);
        }

        public string GetUserFullName(string username)
        {
            return LoginCredentialDal.GetFullName(username);
        }
    }
}
