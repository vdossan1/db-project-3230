using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel
{
    public class VisitDetailsPageViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;


        private List<int> apptIdList;

        /// <summary>
        /// Initializes a new instance of the <see cref="VisitDetailsPageViewModel"/> class.
        /// </summary>
        public VisitDetailsPageViewModel()
        {
            this.apptIdList = new List<int>(AppointmentDal.GetAllAppointmentsIdsWithNoVisits());
            this.ValidationErrors = new Dictionary<string, string>();
        }

        /// <summary>
        /// Raises the <see cref="PropertyChanged"/> event for a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            ValidateFields();
        }

        /// <summary>
        /// Saves the visit details to the database.
        /// </summary>
        public void SaveVisitDetails()
        {
            Visit newVisit = new Visit(AppointmentId, NurseId, BloodPressureSystolic, BloodPressureDiastolic,
                BodyTemp, Weight, Height, PulseRate, Symptoms, InitialDiagnoses, FinalDiagnoses);
            VisitDal.CreateVisit(newVisit);
        }

        #region Properties

        /// <summary>
        /// Gets the array of appointment IDs with no associated visits.
        /// </summary>
        public int[] ApptIdsArray => this.apptIdList.ToArray();


        private int appointmentId;
        /// <summary>
        /// Gets or sets the appointment ID for the visit.
        /// </summary>
        public int AppointmentId
        {
            get => appointmentId;
            set
            {
                if (appointmentId != value)
                {
                    appointmentId = value;
                    OnPropertyChanged(nameof(AppointmentId));
                }
            }
        }

        private int nurseId;
        /// <summary>
        /// Gets or sets the nurse ID for the visit.
        /// </summary>
        public int NurseId
        {
            get => nurseId;
            set
            {
                if (nurseId != value)
                {
                    nurseId = value;
                    OnPropertyChanged(nameof(NurseId));
                }
            }
        }

        private int bloodPressureSystolic;
        /// <summary>
        /// Gets or sets the systolic blood pressure for the visit.
        /// </summary>
        public int BloodPressureSystolic
        {
            get => bloodPressureSystolic;
            set
            {
                if (bloodPressureSystolic != value)
                {
                    bloodPressureSystolic = value;
                    OnPropertyChanged(nameof(BloodPressureSystolic));
                }
            }
        }

        private int bloodPressureDiastolic;
        /// <summary>
        /// Gets or sets the diastolic blood pressure for the visit.
        /// </summary>
        public int BloodPressureDiastolic
        {
            get => bloodPressureDiastolic;
            set
            {
                if (bloodPressureDiastolic != value)
                {
                    bloodPressureDiastolic = value;
                    OnPropertyChanged(nameof(BloodPressureDiastolic));
                }
            }
        }

        private decimal bodyTemp;
        /// <summary>
        /// Gets or sets the body temperature for the visit.
        /// </summary>
        public decimal BodyTemp
        {
            get => bodyTemp;
            set
            {
                if (bodyTemp != value)
                {
                    bodyTemp = value;
                    OnPropertyChanged(nameof(BodyTemp));
                }
            }
        }

        private decimal weight;
        /// <summary>
        /// Gets or sets the weight for the visit.
        /// </summary>
        public decimal Weight
        {
            get => weight;
            set
            {
                if (weight != value)
                {
                    weight = value;
                    OnPropertyChanged(nameof(Weight));
                }
            }
        }

        private decimal height;
        /// <summary>
        /// Gets or sets the height for the visit.
        /// </summary>
        public decimal Height
        {
            get => height;
            set
            {
                if (height != value)
                {
                    height = value;
                    OnPropertyChanged(nameof(Height));
                }
            }
        }

        private int pulseRate;
        /// <summary>
        /// Gets or sets the pulse rate for the visit.
        /// </summary>
        public int PulseRate
        {
            get => pulseRate;
            set
            {
                if (pulseRate != value)
                {
                    pulseRate = value;
                    OnPropertyChanged(nameof(PulseRate));
                }
            }
        }

        private string symptoms;
        /// <summary>
        /// Gets or sets the symptoms for the visit.
        /// </summary>
        public string Symptoms
        {
            get => symptoms;
            set
            {
                if (symptoms != value)
                {
                    symptoms = value;
                    OnPropertyChanged(nameof(Symptoms));
                }
            }
        }

        private string initialDiagnoses;
        /// <summary>
        /// Gets or sets the initial diagnosis for the visit.
        /// </summary>
        public string InitialDiagnoses
        {
            get => initialDiagnoses;
            set
            {
                if (initialDiagnoses != value)
                {
                    initialDiagnoses = value;
                    OnPropertyChanged(nameof(InitialDiagnoses));
                }
            }
        }

        private string finalDiagnoses;
        /// <summary>
        /// Gets or sets the final diagnosis for the visit.
        /// </summary>
        public string FinalDiagnoses
        {
            get => finalDiagnoses;
            set
            {
                if (finalDiagnoses != value)
                {
                    finalDiagnoses = value;
                    OnPropertyChanged(nameof(FinalDiagnoses));
                }
            }
        }

        #endregion

        #region ValidationErrorProperties

        /// <summary>
        /// Gets the dictionary of validation error messages for form fields.
        /// </summary>
        public Dictionary<string, string> ValidationErrors { get; private set; }


        /// <summary>
        /// Gets the validation message for the Appointment ID field.
        /// </summary>
        public string AppointmentIdValidationMessage =>
            ValidationErrors.ContainsKey(nameof(AppointmentId)) ? ValidationErrors[nameof(AppointmentId)] : string.Empty;


        /// <summary>
        /// Gets the validation message for the Systolic Blood Pressure field.
        /// </summary>
        public string BloodPressureSysValidationMessage =>
            ValidationErrors.ContainsKey(nameof(BloodPressureSystolic)) ? ValidationErrors[nameof(BloodPressureSystolic)] : string.Empty;

        /// <summary>
        /// Gets the validation message for the Diastolic Blood Pressure field.
        /// </summary>
        public string BloodPressureDiasValidationMessage =>
            ValidationErrors.ContainsKey(nameof(BloodPressureDiastolic)) ? ValidationErrors[nameof(BloodPressureDiastolic)] : string.Empty;

        /// <summary>
        /// Gets the validation message for the Weight field.
        /// </summary>
        public string WeightValidationMessage =>
            ValidationErrors.ContainsKey(nameof(Weight)) ? ValidationErrors[nameof(Weight)] : string.Empty;

        /// <summary>
        /// Gets the validation message for the Height field.
        /// </summary>
        public string HeightValidationMessage =>
            ValidationErrors.ContainsKey(nameof(Height)) ? ValidationErrors[nameof(Height)] : string.Empty;

        /// <summary>
        /// Gets the validation message for the Pulse Rate field.
        /// </summary>
        public string PulseValidationMessage =>
            ValidationErrors.ContainsKey(nameof(PulseRate)) ? ValidationErrors[nameof(PulseRate)] : string.Empty;

        /// <summary>
        /// Gets the validation message for the Body Temperature field.
        /// </summary>
        public string BodyTempValidationMessage =>
            ValidationErrors.ContainsKey(nameof(BodyTemp)) ? ValidationErrors[nameof(BodyTemp)] : string.Empty;

        /// <summary>
        /// Gets the validation message for the Symptoms field.
        /// </summary>
        public string SymptomsValidationMessage =>
            ValidationErrors.ContainsKey(nameof(Symptoms)) ? ValidationErrors[nameof(Symptoms)] : string.Empty;
        
        /// /// <summary>
        /// Gets the validation message for the Initial Diagnosis field.
        /// </summary>
        public string InitialDiagValidationMessage =>
            ValidationErrors.ContainsKey(nameof(InitialDiagnoses)) ? ValidationErrors[nameof(InitialDiagnoses)] : string.Empty;


        private bool IsValidNumeric(string numericFieldText) =>
            numericFieldText?.All(char.IsDigit) == true && decimal.Parse(numericFieldText) == 0;

        /// <summary>
        /// Determines if the data entered by the user is valid.
        /// </summary>
        public bool IsValid { get; private set; }

        private const string CANNOT_BE_ZERO = "This field cannot be 0";
        private const string REQUIRED_FIELD = "This field is required";

        /// <summary>
        /// Validates the fields and updates the <see cref="ValidationErrors"/> dictionary with any validation errors.
        /// </summary>
        public void ValidateFields()
        {
            ValidationErrors.Clear();
            IsValid = true;

            if (BloodPressureSystolic == 0)
            {
                ValidationErrors[nameof(BloodPressureSystolic)] = CANNOT_BE_ZERO;
                IsValid = false;
            }

            if (BloodPressureDiastolic == 0)
            {
                ValidationErrors[nameof(BloodPressureDiastolic)] = CANNOT_BE_ZERO;
                IsValid = false;
            }

            if (Weight == 0)
            {
                ValidationErrors[nameof(Weight)] = CANNOT_BE_ZERO;
                IsValid = false;
            }

            if (Height == 0)
            {
                ValidationErrors[nameof(Height)] = CANNOT_BE_ZERO;
                IsValid = false;
            }

            if (PulseRate == 0)
            {
                ValidationErrors[nameof(PulseRate)] = CANNOT_BE_ZERO;
                IsValid = false;
            }

            if (BodyTemp == 0)
            {
                ValidationErrors[nameof(BodyTemp)] = CANNOT_BE_ZERO;
                IsValid = false;
            }

            if (string.IsNullOrWhiteSpace(Symptoms))
            {
                ValidationErrors[nameof(Symptoms)] = REQUIRED_FIELD;
                IsValid = false;
            }

            if (string.IsNullOrWhiteSpace(InitialDiagnoses))
            {
                ValidationErrors[nameof(InitialDiagnoses)] = REQUIRED_FIELD;
                IsValid = false;
            }
        }

        #endregion
    }
}
