using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareApp.model
{
    public class Patient
    {
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string Address1 { get; }
        public string Address2 { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string PhoneNumber { get; }
        public bool Status { get; }

        public Patient(int id, string firstName, string lastName, DateTime dateOfBirth, string address1,
            string address2, string city, string state, string zipCode, string phoneNumber, bool status)
        {
            this.Id = id;
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            this.DateOfBirth = dateOfBirth;
            this.Address1 = address1 ?? throw new ArgumentNullException(nameof(address1));
            this.Address2 = address2;
            this.City = city ?? throw new ArgumentNullException(nameof(city));
            this.State = state ?? throw new ArgumentNullException(nameof(state));
            this.ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
            this.PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            this.Status = status;
        }
    }
}
