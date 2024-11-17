using HealthCareApp.DAL;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.model;

/// <summary>
///     The Appointment Class.
/// </summary>
public class Appointment
{
    #region Properties

    /// <summary>
    ///     Gets or sets the Appointment Id for the appointment.
    /// </summary>
    public int AppointmentId { get; set; }

    /// <summary>
    ///     Gets or sets the Patient Id for the appointment.
    /// </summary>
    public int PatientId { get; }

    /// <summary>
    ///     Gets or sets the Patient name for the appointment.
    /// </summary>
    public string PatientName { get; set; }

    /// <summary>
    ///     Gets or sets the Doctor Id for the appointment.
    /// </summary>
    public int DoctorId { get; }

    /// <summary>
    ///     Gets or sets the Doctor name for the appointment.
    /// </summary>
    public string DoctorName { get; set; }

    /// <summary>
    ///     Gets or sets the date of the appointment.
    /// </summary>
    public DateTime AppointmentDate { get; }

    /// <summary>
    ///     Gets or sets the reason for the appointment.
    /// </summary>
    public string Reason { get; }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Appointment" /> class with the specified details.
    /// </summary>
    public Appointment(int patientId, int doctorId, DateTime? date, string reason)
    {
        this.PatientId = patientId;
        this.DoctorId = doctorId;
        this.setPatientName(patientId);
        this.setDoctorName(doctorId);
        this.AppointmentDate = date ?? throw new ArgumentNullException(nameof(date));
        this.Reason = reason ?? throw new ArgumentNullException(nameof(reason));
    }

    #endregion

    #region Methods

    private void setPatientName(int patientId)
    {
        var patient = PatientDal.GetPatientById(patientId);
        this.PatientName = $"{patient.FirstName} {patient.LastName}";
    }

    private void setDoctorName(int doctorId)
    {
        var doctor = DoctorDal.GetDoctorById(doctorId);
        this.DoctorName = $"{doctor.FirstName} {doctor.LastName}";
    }

    #endregion
}