// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024

namespace HealthCareApp.model;

/// <summary>
///     Represents a visit record in the healthcare system, storing patient health data and diagnoses associated with an
///     appointment.
/// </summary>
public class Visit
{
    #region Properties

    /// <summary>
    ///     Gets or sets the unique identifier for the visit.
    /// </summary>
    public int VisitId { get; set; }

    /// <summary>
    ///     Gets or sets the identifier for the appointment associated with this visit.
    /// </summary>
    public int AppointmentId { get; set; }

    /// <summary>
    ///     Gets or sets the identifier for the nurse who conducted the visit.
    /// </summary>
    public int NurseId { get; set; }

    /// <summary>
    ///     Gets or sets the systolic blood pressure recorded during the visit.
    /// </summary>
    public int BloodPressureSystolic { get; set; }

    /// <summary>
    ///     Gets or sets the diastolic blood pressure recorded during the visit.
    /// </summary>
    public int BloodPressureDiastolic { get; set; }

    /// <summary>
    ///     Gets or sets the body temperature of the patient recorded during the visit.
    /// </summary>
    public decimal BodyTemp { get; set; }

    /// <summary>
    ///     Gets or sets the weight of the patient recorded during the visit.
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    ///     Gets or sets the height of the patient recorded during the visit.
    /// </summary>
    public decimal Height { get; set; }

    /// <summary>
    ///     Gets or sets the pulse rate of the patient recorded during the visit.
    /// </summary>
    public int PulseRate { get; set; }

    /// <summary>
    ///     Gets or sets the symptoms reported by the patient during the visit.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown if the value is null.</exception>
    public string Symptoms { get; set; }

    /// <summary>
    ///     Gets or sets the initial diagnoses made by the nurse or healthcare provider during the visit.
    /// </summary>
    /// <exception cref="ArgumentNullException">Thrown if the value is null.</exception>
    public string InitialDiagnoses { get; set; }

    /// <summary>
    ///     Gets or sets the final diagnoses made after further evaluation or treatment.
    /// </summary>
    public string FinalDiagnoses { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="Visit" /> class with the specified appointment ID, nurse ID, and
    ///     health data.
    /// </summary>
    public Visit(int appointmentId, int nurseId, int bloodPressureSystolic, int bloodPressureDiastolic,
        decimal bodyTemp, decimal weight, decimal height, int pulseRate, string symptoms, string initialDiagnoses,
        string finalDiagnoses)
    {
        this.AppointmentId = appointmentId;
        this.NurseId = nurseId;
        this.BloodPressureSystolic = bloodPressureSystolic;
        this.BloodPressureDiastolic = bloodPressureDiastolic;
        this.BodyTemp = bodyTemp;
        this.Weight = weight;
        this.Height = height;
        this.PulseRate = pulseRate;
        this.Symptoms = symptoms ?? throw new ArgumentNullException(nameof(symptoms));
        this.InitialDiagnoses = initialDiagnoses ?? throw new ArgumentNullException(nameof(initialDiagnoses));
        this.FinalDiagnoses = finalDiagnoses;
    }

    #endregion
}