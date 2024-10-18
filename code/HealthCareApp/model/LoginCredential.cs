using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareApp.model
{
    public class LoginCredential
    {
        public string Username { get; }
        public string Password { get; }

        public LoginCredential(string username, string password)
        {
            this.Username = username ?? throw new ArgumentNullException(nameof(username));
            this.Password = password ?? throw new ArgumentNullException(nameof(password));
        }
    }
}
