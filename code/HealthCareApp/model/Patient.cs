// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.model
{
	/// <summary>
	/// The Patient Class.
	/// </summary>
	public class Patient
    {
		/// <summary>
		/// Gets or sets the first name of the patient.
		/// </summary>
		public string FirstName { get; }

		/// <summary>
		/// Gets or sets the last name of the patient.
		/// </summary>
		public string LastName { get; }

		/// <summary>
		/// Gets or sets the date of birth of the patient.
		/// </summary>
		public DateTime? DateOfBirth { get; }

		/// <summary>
		/// Gets or sets the sex of the patient.
		/// </summary>
		public string Sex { get; set; }

		/// <summary>
		/// Gets or sets the primary address of the patient.
		/// </summary>
		public string Address1 { get; }

		/// <summary>
		/// Gets or sets the secondary address of the patient (optional).
		/// </summary>
		public string? Address2 { get; }

		/// <summary>
		/// Gets or sets the city of the patient.
		/// </summary>
		public string City { get; }

		/// <summary>
		/// Gets or sets the state of the patient.
		/// </summary>
		public string State { get; }

		/// <summary>
		/// Gets or sets the zip code of the patient.
		/// </summary>
		public string ZipCode { get; }

		/// <summary>
		/// Gets or sets the phone number of the patient.
		/// </summary>
		public string PhoneNumber { get; }

		/// <summary>
		/// Gets or sets the social security number of the patient.
		/// </summary>
		public string Ssn { get; }

		/// <summary>
		/// Gets or sets the status of the patient (active or inactive).
		/// </summary>
		public bool Status { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="Patient"/> class with the specified details.
		/// </summary>
		public Patient(string firstName, string lastName, DateTime? dateOfBirth, string sex,
            string address1, string? address2, string city, string state, string zipCode, string phoneNumber,
			string ssn, bool status)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            DateOfBirth = dateOfBirth ?? throw new ArgumentNullException(nameof(dateOfBirth)); ;
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
