using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareApp.model
{
    public class Nurse
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string Gender { get; }
        public string SSN { get; }
        public string Address1 { get; }
        public string Address2 { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string PhoneNumber { get; }
        public string Username { get; }

        public Nurse(int id, string firstName, string lastName, DateTime dateOfBirth, string gender, string ssn,
            string address1, string address2, string city, string state, string zipCode, string phoneNumber,
            string username)
        {
            Id = id;
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            DateOfBirth = dateOfBirth;
            Gender = gender ?? throw new ArgumentNullException(nameof(gender));
            SSN = ssn ?? throw new ArgumentNullException(nameof(ssn));
            Address1 = address1 ?? throw new ArgumentNullException(nameof(address1));
            Address2 = address2;
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
            PhoneNumber = phoneNumber;
            Username = username ?? throw new ArgumentNullException( nameof(username));
        }
    }
}
