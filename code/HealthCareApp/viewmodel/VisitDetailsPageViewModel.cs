using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel
{
    public class VisitDetailsPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private List<int> apptIdList;

        public VisitDetailsPageViewModel()
        {
            this.apptIdList = new List<int>(AppointmentDal.GetAllAppointmentsIdsWithNoVisits());
            this.ValidationErrors = new Dictionary<string, string>();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            ValidateFields();
        }

        public void SaveVisitDetails()
        {
            Visit newVisit = new Visit(AppointmentId, NurseId, BloodPressureSystolic, BloodPressureDiastolic,
                BodyTemp, Weight, Height, PulseRate, Symptoms, InitialDiagnoses, FinalDiagnoses);
            VisitDal.CreateVisit(newVisit);
        }

        #region Properties

        public int[] ApptIdsArray => this.apptIdList.ToArray();

        private int appointmentId;

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

        public Dictionary<string, string> ValidationErrors { get; private set; }

        public string AppointmentIdValidationMessage =>
            ValidationErrors.ContainsKey(nameof(AppointmentId)) ? ValidationErrors[nameof(AppointmentId)] : string.Empty;

        public string BloodPressureSysValidationMessage =>
            ValidationErrors.ContainsKey(nameof(BloodPressureSystolic)) ? ValidationErrors[nameof(BloodPressureSystolic)] : string.Empty;

        public string BloodPressureDiasValidationMessage =>
            ValidationErrors.ContainsKey(nameof(BloodPressureDiastolic)) ? ValidationErrors[nameof(BloodPressureDiastolic)] : string.Empty;

        public string WeightValidationMessage =>
            ValidationErrors.ContainsKey(nameof(Weight)) ? ValidationErrors[nameof(Weight)] : string.Empty;

        public string HeightValidationMessage =>
            ValidationErrors.ContainsKey(nameof(Height)) ? ValidationErrors[nameof(Height)] : string.Empty;

        public string PulseValidationMessage =>
            ValidationErrors.ContainsKey(nameof(PulseRate)) ? ValidationErrors[nameof(PulseRate)] : string.Empty;

        public string BodyTempValidationMessage =>
            ValidationErrors.ContainsKey(nameof(BodyTemp)) ? ValidationErrors[nameof(BodyTemp)] : string.Empty;

        public string SymptomsValidationMessage =>
            ValidationErrors.ContainsKey(nameof(Symptoms)) ? ValidationErrors[nameof(Symptoms)] : string.Empty;

        public string InitialDiagValidationMessage =>
            ValidationErrors.ContainsKey(nameof(InitialDiagnoses)) ? ValidationErrors[nameof(InitialDiagnoses)] : string.Empty;

        private bool IsValidNumeric(string numericFieldText) =>
            numericFieldText?.All(char.IsDigit) == true && decimal.Parse(numericFieldText) == 0;

        public bool IsValid { get; private set; }

        private const string CANNOT_BE_ZERO = "This field cannot be 0";
        private const string REQUIRED_FIELD = "This field is required";

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
