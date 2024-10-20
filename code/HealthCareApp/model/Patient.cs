namespace HealthCareApp.model
{
	/// <summary>
	/// The Patient Class.
	/// </summary>
	public class Patient
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime DateOfBirth { get; }
        public string Sex { get; }
        public string Address1 { get; }
        public string? Address2 { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string PhoneNumber { get; }
        public string Ssn { get; }
		public bool Status { get; }

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
