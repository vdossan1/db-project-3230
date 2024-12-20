﻿using System.ComponentModel;
using System.Text.RegularExpressions;
using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel;

public class ManageVisitDetailsPageViewModel : INotifyPropertyChanged
{
    #region Data members

    private const string CANNOT_BE_ZERO = "This field cannot be 0";
    private const string REQUIRED_FIELD = "This field is required";
    private const string INVALID_TEMP = "Invalid value.\nValid value example:\n102.5\n90.5";
    private const string INVALID_WEIGHT = "Invalid value.\nValid value example:\n90.21\n180";
    private const string INVALID_HEIGHT = "Invalid value.\nValid value example:\n5.3\n6.11";

    private List<int> apptIdList;

    private List<string> addedTests;

    private int appointmentId;

    private string doctorFullName;

    private string patientFullName;

    private int nurseId;

    private int bloodPressureSystolic;

    private int bloodPressureDiastolic;

    private decimal bodyTemp;

    private decimal weight;

    private decimal height;

    private int pulseRate;

    private string symptoms;

    private string initialDiagnoses;

    private string finalDiagnoses;

    private bool allowFinalDiag;

    #endregion

    #region Properties

    public Visit? SelectedVisit { get; set; }

    public BindingList<string> LabTests { get; private set; }

    public BindingList<string> SelectedTests { get; private set; }

    public string PatientFullName
    {
        get => this.patientFullName;
        set
        {
            if (this.patientFullName != value)
            {
                this.patientFullName = value;
                this.OnPropertyChanged(nameof(this.PatientFullName));
            }
        }
    }

    public string DoctorFullName
    {
        get => this.doctorFullName;
        set
        {
            if (this.doctorFullName != value)
            {
                this.doctorFullName = value;
                this.OnPropertyChanged(nameof(this.doctorFullName));
            }
        }
    }

    private string nurseFullName;

    public string NurseFullName
    {
        get => this.nurseFullName;
        set
        {
            if (this.nurseFullName != value)
            {
                this.nurseFullName = value;
                this.OnPropertyChanged(nameof(this.PatientFullName));
            }
        }
    }

    /// <summary>
    ///     Determines if the data entered by the user is valid.
    /// </summary>
    public bool IsValid { get; private set; }

    public bool AllowFinalDiag
    {
        get => this.allowFinalDiag;
        set
        {
            if (this.allowFinalDiag != value)
            {
                this.allowFinalDiag = value;
                this.OnPropertyChanged(nameof(this.AllowFinalDiag));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the appointment ID for the visit.
    /// </summary>
    public int AppointmentId
    {
        get => this.appointmentId;
        set
        {
            if (this.appointmentId != value)
            {
                this.appointmentId = value;
                this.OnPropertyChanged(nameof(this.AppointmentId));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the nurse ID for the visit.
    /// </summary>
    public int NurseId
    {
        get => this.nurseId;
        set
        {
            if (this.nurseId != value)
            {
                this.nurseId = value;
                this.OnPropertyChanged(nameof(this.NurseId));
            }
        }
    }

    private bool isVisitClosed;

    public bool IsVisitClosed
    {
        get => this.isVisitClosed;
        set
        {
            if (this.isVisitClosed != value)
            {
                this.isVisitClosed = value;
                this.OnPropertyChanged(nameof(this.IsVisitClosed));
            }
        }
    }

    public bool AllowSave => !this.isVisitClosed && this.IsValid;

    #endregion

    #region Fillable Fields

    /// <summary>
    ///     Gets or sets the systolic blood pressure for the visit.
    /// </summary>
    public int BloodPressureSystolic
    {
        get => this.bloodPressureSystolic;
        set
        {
            if (this.bloodPressureSystolic != value)
            {
                this.bloodPressureSystolic = value;
                this.OnPropertyChanged(nameof(this.BloodPressureSystolic));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the diastolic blood pressure for the visit.
    /// </summary>
    public int BloodPressureDiastolic
    {
        get => this.bloodPressureDiastolic;
        set
        {
            if (this.bloodPressureDiastolic != value)
            {
                this.bloodPressureDiastolic = value;
                this.OnPropertyChanged(nameof(this.BloodPressureDiastolic));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the body temperature for the visit.
    /// </summary>
    public decimal BodyTemp
    {
        get => this.bodyTemp;
        set
        {
            if (this.bodyTemp != value)
            {
                this.bodyTemp = value;
                this.OnPropertyChanged(nameof(this.BodyTemp));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the weight for the visit.
    /// </summary>
    public decimal Weight
    {
        get => this.weight;
        set
        {
            if (this.weight != value)
            {
                this.weight = value;
                this.OnPropertyChanged(nameof(this.Weight));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the height for the visit.
    /// </summary>
    public decimal Height
    {
        get => this.height;
        set
        {
            if (this.height != value)
            {
                this.height = value;
                this.OnPropertyChanged(nameof(this.Height));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the pulse rate for the visit.
    /// </summary>
    public int PulseRate
    {
        get => this.pulseRate;
        set
        {
            if (this.pulseRate != value)
            {
                this.pulseRate = value;
                this.OnPropertyChanged(nameof(this.PulseRate));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the symptoms for the visit.
    /// </summary>
    public string Symptoms
    {
        get => this.symptoms;
        set
        {
            if (this.symptoms != value)
            {
                this.symptoms = value;
                this.OnPropertyChanged(nameof(this.Symptoms));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the initial diagnosis for the visit.
    /// </summary>
    public string InitialDiagnoses
    {
        get => this.initialDiagnoses;
        set
        {
            if (this.initialDiagnoses != value)
            {
                this.initialDiagnoses = value;
                this.OnPropertyChanged(nameof(this.InitialDiagnoses));
            }
        }
    }

    /// <summary>
    ///     Gets or sets the final diagnosis for the visit.
    /// </summary>
    public string FinalDiagnoses
    {
        get => this.finalDiagnoses;
        set
        {
            if (this.finalDiagnoses != value)
            {
                this.finalDiagnoses = value;
                this.OnPropertyChanged(nameof(this.FinalDiagnoses));
            }
        }
    }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="ManageVisitDetailsPageViewModel" /> class.
    /// </summary>
    public ManageVisitDetailsPageViewModel(Visit? selectedVisit = null, int? apptId = null)
    {
        this.ValidationErrors = new Dictionary<string, string>();
        this.LabTests = new BindingList<string>();
        this.SelectedTests = new BindingList<string>();
        this.addedTests = new List<string>();

        this.SelectedVisit = selectedVisit;

        if (apptId != null)
        {
            this.AppointmentId = apptId.Value;
            this.apptIdList = [this.AppointmentId];
        }

        this.NurseId = NurseDal.GetIdFromUsername(LoggedUser.Username);
        this.NurseFullName = LoggedUser.FullName;
        this.PatientFullName = PatientDal.GetPatientNameWithApptId(this.AppointmentId);
        this.DoctorFullName = DoctorDal.GetDoctorNameWithApptId(this.AppointmentId);


        this.PopulateListBoxes();

        this.disableFinalDiagIfTestSelected();
        this.disableAllControlsIfTestClosed();
    }

    private void disableAllControlsIfTestClosed()
    {
        if (this.IsValid && this.checkTestsComplete() && !string.IsNullOrWhiteSpace(this.FinalDiagnoses))
        {
            this.AllowFinalDiag = false;
            this.IsVisitClosed = true;
        }
    }

    #endregion

    #region Events

    /// <summary>
    ///     Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    ///     Raises the <see cref="PropertyChanged" /> event for a property.
    /// </summary>
    /// <param name="propertyName">The name of the property that changed.</param>
    protected virtual void OnPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        this.ValidateFields();
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Saves the visit details to the database.
    /// </summary>
    public void SaveVisitDetails()
    {
        var newVisit = new Visit(this.AppointmentId, this.NurseId, this.BloodPressureSystolic,
            this.BloodPressureDiastolic, this.BodyTemp, this.Weight, this.Height, this.PulseRate, this.Symptoms,
            this.InitialDiagnoses, this.FinalDiagnoses);

        if (this.SelectedVisit == null)
        {
            VisitDal.CreateVisit(newVisit);
        }
        else
        {
            newVisit.VisitId = this.SelectedVisit.VisitId;
            VisitDal.EditVisit(newVisit);
        }
    }

    public void CreateLabTestResults()
    {
        var testCodes = new List<int>();

        foreach (var testName in this.addedTests)
        {
            var testCode = LabTestDal.GetLabTestCodeByTestName(testName);
            testCodes.Add(testCode);
        }

        var visitId = this.SelectedVisit.VisitId;

        foreach (var testCode in testCodes)
        {
            var newLabTestResult = new LabTestResult(visitId, testCode, null, null, null, false);
            LabTestResultDal.CreateLabTestResult(newLabTestResult);
        }
    }

    public void PopulateFields()
    {
        this.apptIdList = [this.SelectedVisit.AppointmentId];

        if (this.SelectedVisit != null)
        {
            this.PatientFullName = PatientDal.GetPatientNameWithApptId(this.SelectedVisit.AppointmentId);
            this.DoctorFullName = DoctorDal.GetDoctorNameWithApptId(this.SelectedVisit.AppointmentId);
        }

        this.BloodPressureSystolic = this.SelectedVisit.BloodPressureSystolic;
        this.BloodPressureDiastolic = this.SelectedVisit.BloodPressureDiastolic;
        this.Weight = this.SelectedVisit.Weight;
        this.Height = this.SelectedVisit.Height;
        this.PulseRate = this.SelectedVisit.PulseRate;
        this.BodyTemp = this.SelectedVisit.BodyTemp;
        this.Symptoms = this.SelectedVisit.Symptoms;
        this.InitialDiagnoses = this.SelectedVisit.InitialDiagnoses;
        this.finalDiagnoses = this.SelectedVisit.FinalDiagnoses;

        this.disableAllControlsIfTestClosed();
    }

    public void disableFinalDiagIfTestSelected()
    {
        if (this.checkTestsComplete())
        {
            this.AllowFinalDiag = true;
        }
        else
        {
            this.AllowFinalDiag = this.SelectedTests.Count == 0;
        }
    }

    private bool checkTestsComplete()
    {
        bool result = true;

        if (this.SelectedVisit != null)
        {
            BindingList<LabTestResult> labTests = LabTestResultDal.GetAllLabTestResultsForVisit(this.SelectedVisit.VisitId);

            foreach (var testResult in labTests)
            {
                if (testResult.Status == false)
                {
                    result = false;
                }
            }
        }

        return result;
    }

    private void PopulateListBoxes()
    {
        this.PopulateAvailableTests();

        if (this.SelectedVisit != null)
        {
            this.PopulateSelectedTests();
        }
    }

    private void PopulateAvailableTests()
    {
        this.LabTests = LabTestDal.GetAllTestsName();
    }

    private void PopulateSelectedTests()
    {
        var labTestsForVisit = LabTestDal.GetAllLabTestsForVisit(this.SelectedVisit.VisitId);

        foreach (var test in labTestsForVisit)
        {
            this.SelectedTests.Add(test);
            this.LabTests.Remove(test);
        }
    }

    #endregion

    #region Field Validation

    private bool isValidWeight(string weightString)
    {
        string pattern = @"^\d{1,3}(\.\d{1,2})?$";
        return Regex.IsMatch(weightString, pattern);
    }

    private bool isValidHeight(string heightString)
    {
        string pattern = @"^\d{1,3}(\.\d{1,2})?$";
        return Regex.IsMatch(heightString, pattern);
    }

    private bool isValidBodyTemperature(string bodyTempString)
    {
        // Regex to validate body temperature
        string pattern = @"^\d{1,3}(\.\d{1,2})?$";
        return Regex.IsMatch(bodyTempString, pattern);
    }

    /// <summary>
    ///     Validates the fields and updates the <see cref="ValidationErrors" /> dictionary with any validation errors.
    /// </summary>
    public void ValidateFields()
    {
        this.ValidationErrors.Clear();
        this.IsValid = true;

        if (this.BloodPressureSystolic == 0)
        {
            this.ValidationErrors[nameof(this.BloodPressureSystolic)] = CANNOT_BE_ZERO;
            this.IsValid = false;
        }

        if (this.BloodPressureDiastolic == 0)
        {
            this.ValidationErrors[nameof(this.BloodPressureDiastolic)] = CANNOT_BE_ZERO;
            this.IsValid = false;
        }

        if (this.Weight == 0)
        {
            this.ValidationErrors[nameof(this.Weight)] = CANNOT_BE_ZERO;
            this.IsValid = false;
        }

        if (this.isValidWeight(this.Weight.ToString()) == false)
        {
            this.ValidationErrors[nameof(this.Weight)] = INVALID_WEIGHT;
            this.IsValid = false;
        }

        if (this.Height == 0)
        {
            this.ValidationErrors[nameof(this.Height)] = CANNOT_BE_ZERO;
            this.IsValid = false;
        }

        if (this.isValidHeight(this.Height.ToString()) == false)
        {
            this.ValidationErrors[nameof(this.Height)] = INVALID_HEIGHT;
            this.IsValid = false;
        }

        if (this.PulseRate == 0)
        {
            this.ValidationErrors[nameof(this.PulseRate)] = CANNOT_BE_ZERO;
            this.IsValid = false;
        }

        if (this.BodyTemp == 0)
        {
            this.ValidationErrors[nameof(this.BodyTemp)] = CANNOT_BE_ZERO;
            this.IsValid = false;
        }

        if (this.isValidBodyTemperature(this.BodyTemp.ToString()) == false)
        {
            this.ValidationErrors[nameof(this.BodyTemp)] = INVALID_TEMP;
            this.IsValid = false;
        }

        if (string.IsNullOrWhiteSpace(this.Symptoms))
        {
            this.ValidationErrors[nameof(this.Symptoms)] = REQUIRED_FIELD;
            this.IsValid = false;
        }
    }

    #endregion

    #region Validation Properties

    /// <summary>
    ///     Gets the dictionary of validation error messages for form fields.
    /// </summary>
    public Dictionary<string, string> ValidationErrors { get; }

    /// <summary>
    ///     Gets the validation message for the Appointment ID field.
    /// </summary>
    public string AppointmentIdValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.AppointmentId))
        ? this.ValidationErrors[nameof(this.AppointmentId)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Systolic Blood Pressure field.
    /// </summary>
    public string BloodPressureSysValidationMessage =>
        this.ValidationErrors.ContainsKey(nameof(this.BloodPressureSystolic))
            ? this.ValidationErrors[nameof(this.BloodPressureSystolic)]
            : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Diastolic Blood Pressure field.
    /// </summary>
    public string BloodPressureDiasValidationMessage =>
        this.ValidationErrors.ContainsKey(nameof(this.BloodPressureDiastolic))
            ? this.ValidationErrors[nameof(this.BloodPressureDiastolic)]
            : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Weight field.
    /// </summary>
    public string WeightValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Weight))
        ? this.ValidationErrors[nameof(this.Weight)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Height field.
    /// </summary>
    public string HeightValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Height))
        ? this.ValidationErrors[nameof(this.Height)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Pulse Rate field.
    /// </summary>
    public string PulseValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.PulseRate))
        ? this.ValidationErrors[nameof(this.PulseRate)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Body Temperature field.
    /// </summary>
    public string BodyTempValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.BodyTemp))
        ? this.ValidationErrors[nameof(this.BodyTemp)]
        : string.Empty;

    /// <summary>
    ///     Gets the validation message for the Symptoms field.
    /// </summary>
    public string SymptomsValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.Symptoms))
        ? this.ValidationErrors[nameof(this.Symptoms)]
        : string.Empty;

    /// ///
    /// <summary>
    ///     Gets the validation message for the Initial Diagnosis field.
    /// </summary>
    public string InitialDiagValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.InitialDiagnoses))
        ? this.ValidationErrors[nameof(this.InitialDiagnoses)]
        : string.Empty;

    #endregion

    public void AddNewTest(string testName)
    {
        this.addedTests.Add(testName);
    }

    public void RemoveNewTest(string testName)
    {
        if (this.addedTests.Contains(testName))
        {
            this.addedTests.Remove(testName);
        }
    }
}