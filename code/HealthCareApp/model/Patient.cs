namespace HealthCareApp.model
{
	/// <summary>
	/// The Patient Class.
	/// </summary>
	public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set;  }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set;  }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Ssn { get; set; }
		public bool Status { get; set; }

        public Patient(string firstName, string lastName, DateTime dateOfBirth, string sex,
            string address1, string? address2, string city, string state, string zipCode, string phoneNumber,
			string ssn, bool status)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            DateOfBirth = dateOfBirth;
            Sex = sex ?? throw new ArgumentNullException(nameof(sex));
            Address1 = address1 ?? throw new ArgumentNullException(nameof(address1));
            Address2 = address2;
            City = city ?? throw new ArgumentNullException(nameof(city));
            State = state ?? throw new ArgumentNullException(nameof(state));
            ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
            PhoneNumber = phoneNumber;
            Ssn = ssn ?? throw new ArgumentNullException(nameof(ssn));
			Status = status;
        }
    }
}
