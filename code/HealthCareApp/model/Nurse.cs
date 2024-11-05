// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024

namespace HealthCareApp.model;

/// <summary>
///     The Nurse Class.
/// </summary>
public class Nurse
{
    #region Properties

    /// <summary>
    ///     Gets or sets the Id of the nurse.
    /// </summary>
    public int NurseId { get; set; }

    /// <summary>
    ///     Gets the first name of the nurse.
    /// </summary>
    public string FirstName { get; }

    /// <summary>
    ///     Gets the last name of the nurse.
    /// </summary>
    public string LastName { get; }

    /// <summary>
    ///     Gets the date of birth of the nurse.
    /// </summary>
    public DateTime DateOfBirth { get; }

    /// <summary>
    ///     Gets the sex of the nurse.
    /// </summary>
    public string Sex { get; }

    /// <summary>
    ///     Gets the primary address of the nurse.
    /// </summary>
    public string Address1 { get; }

    /// <summary>
    ///     Gets the secondary address of the nurse (optional).
    /// </summary>
    public string? Address2 { get; }

    /// <summary>
    ///     Gets the city where the nurse resides.
    /// </summary>
    public string City { get; }

    /// <summary>
    ///     Gets the state where the nurse resides.
    /// </summary>
    public string State { get; }

    /// <summary>
    ///     Gets the zip code of the nurse's residence.
    /// </summary>
    public string ZipCode { get; }

    /// <summary>
    ///     Gets the phone number of the nurse.
    /// </summary>
    public string PhoneNumber { get; }

    /// <summary>
    ///     Gets the social security number of the nurse.
    /// </summary>
    public string Ssn { get; }

    /// <summary>
    ///     Gets the username used by the nurse for system login.
    /// </summary>
    public string Username { get; }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Nurse" /> class with the specified details.
    /// </summary>
    public Nurse(string firstName, string lastName, DateTime dateOfBirth, string sex,
        string address1, string address2, string city, string state, string zipCode, string phoneNumber,
        string ssn, string username)
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
        this.Username = username ?? throw new ArgumentNullException(nameof(username));
    }

    #endregion
}