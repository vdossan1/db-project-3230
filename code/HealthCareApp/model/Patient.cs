// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024

namespace HealthCareApp.model;

/// <summary>
///     The Patient Class.
/// </summary>
public class Patient
{
    #region Properties

    /// <summary>
    ///     Gets or sets the Id of the patient.
    /// </summary>
    public int PatientId { get; set; }

    /// <summary>
    ///     Gets or sets the first name of the patient.
    /// </summary>
    public string FirstName { get; }

    /// <summary>
    ///     Gets or sets the last name of the patient.
    /// </summary>
    public string LastName { get; }

    /// <summary>
    ///     Gets or sets the date of birth of the patient.
    /// </summary>
    public DateTime DateOfBirth { get; }

    /// <summary>
    ///     Gets or sets the sex of the patient.
    /// </summary>
    public string Sex { get; set; }

    /// <summary>
    ///     Gets or sets the primary address of the patient.
    /// </summary>
    public string Address1 { get; }

    /// <summary>
    ///     Gets or sets the secondary address of the patient (optional).
    /// </summary>
    public string? Address2 { get; }

    /// <summary>
    ///     Gets or sets the city of the patient.
    /// </summary>
    public string City { get; }

    /// <summary>
    ///     Gets or sets the state of the patient.
    /// </summary>
    public string State { get; }

    /// <summary>
    ///     Gets or sets the zip code of the patient.
    /// </summary>
    public string ZipCode { get; }

    /// <summary>
    ///     Gets or sets the phone number of the patient.
    /// </summary>
    public string PhoneNumber { get; }

    /// <summary>
    ///     Gets or sets the social security number of the patient.
    /// </summary>
    public string Ssn { get; }

    /// <summary>
    ///     Gets or sets the status of the patient (active or inactive).
    /// </summary>
    public bool Status { get; }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Patient" /> class with the specified details.
    /// </summary>
    public Patient(string firstName, string lastName, DateTime dateOfBirth, string sex,
        string address1, string? address2, string city, string state, string zipCode, string phoneNumber,
        string ssn, bool status)
    {
        this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
        this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        this.DateOfBirth = dateOfBirth;
        this.Sex = sex ?? throw new ArgumentNullException(nameof(sex));
        this.Address1 = address1 ?? throw new ArgumentNullException(nameof(address1));
        this.Address2 = address2;
        this.City = city ?? throw new ArgumentNullException(nameof(city));
        this.State = state ?? throw new ArgumentNullException(nameof(state));
        this.ZipCode = zipCode ?? throw new ArgumentNullException(nameof(zipCode));
        this.PhoneNumber = phoneNumber;
        this.Ssn = ssn ?? throw new ArgumentNullException(nameof(ssn));
        this.Status = status;
    }

    #endregion
}