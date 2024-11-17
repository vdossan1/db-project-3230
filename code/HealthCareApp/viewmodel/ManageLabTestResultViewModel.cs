using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Diagnostics;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel
{
    /// <summary>
    ///     ViewModel for managing lab test result information in the application.
    ///     Responsible for updating lab test results,
    ///     and populating fields with lab test result data.
    /// </summary>
    public class ManageLabTestResultViewModel
    {
        #region Data members

        private string testResult;

        private string resultNormality;

        private DateTime? datePerformed;

        private bool status;

        #endregion

        #region Properties

        /// <summary>
        ///     Gets an array of all possible states as defined in the <see cref="Normality" /> enumeration.
        /// </summary>
        public string[] NormalityArray => Enum.GetNames(typeof(Normality));

        public LabTestResult? SelectedLabTestResult { get; set; }

        public LabTest? SelectedLabTest { get; set; }

        /// <summary>
        ///     Gets or sets the test result of the lab test result.
        ///     Raises the <see cref="PropertyChanged" /> event when changed.
        /// </summary>
        /// 
        public string TestResult
        {
            get => this.testResult;
            set
            {
                if (this.testResult != value)
                {
                    this.testResult = value;
                    this.OnPropertyChanged(nameof(this.TestResult));
                }
            }
        }

        /// <summary>
        ///     Gets or sets the normality of the lab test result.
        ///     Raises the <see cref="PropertyChanged" /> event when changed.
        /// </summary>
        /// 
        public string ResultNormality
        {
            get => this.resultNormality;
            set
            {
                if (this.resultNormality != value)
                {
                    this.resultNormality = value;
                    this.OnPropertyChanged(nameof(this.ResultNormality));
                }
            }
        }

        /// <summary>
        ///     Gets or sets the normality of the lab test result.
        ///     Raises the <see cref="PropertyChanged" /> event when changed.
        /// </summary>
        /// 
        public DateTime? DatePerformed
        {
            get => this.datePerformed;
            set
            {
                if (this.datePerformed != value)
                {
                    this.datePerformed = value;
                    this.OnPropertyChanged(nameof(this.DatePerformed));
                }
            }
        }

        /// <summary>
        ///     Gets or sets the status of the lab test result.
        ///     Raises the <see cref="PropertyChanged" /> event when changed.
        /// </summary>
        /// 
        public bool Status
        {
            get => this.status;
            set
            {
                if (this.status != value)
                {
                    this.status = value;
                    this.OnPropertyChanged(nameof(this.Status));
                }
            }
        }

        /// <summary>
        ///     Gets the validation message for the Test Result field.
        /// </summary>
        public string TestResultValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.TestResult))
            ? this.ValidationErrors[nameof(this.TestResult)]
            : string.Empty;

        /// <summary>
        ///     Gets the validation message for the Result Normality field.
        /// </summary>
        public string ResultNormalityValidationMessage =>
            this.ValidationErrors.ContainsKey(nameof(this.ResultNormality))
                ? this.ValidationErrors[nameof(this.ResultNormality)]
                : string.Empty;

        /// <summary>
        ///     Gets the validation message for the Date Performed field.
        /// </summary>
        public string DatePerformedValidationMessage => this.ValidationErrors.ContainsKey(nameof(this.DatePerformed))
            ? this.ValidationErrors[nameof(this.DatePerformed)]
            : string.Empty;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="ManageLabTestResultViewModel" /> class.
        /// </summary>
        public ManageLabTestResultViewModel(LabTestResult? selectedLabTestResult = null)
        {
            this.SelectedLabTestResult = selectedLabTestResult;
            this.SelectedLabTest = LabTestDal.GetLabTestByTestCode(this.SelectedLabTestResult.TestCode);
            this.ValidationErrors = new Dictionary<string, string>();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Populates the ViewModel's fields with the data from the specified appointment.
        /// </summary>
        /// <param name="appointment">The appointment object whose data will be used to populate the fields.</param>
        public void PopulateFields()
        {
            this.TestResult = this.SelectedLabTestResult.TestResult;
            this.ResultNormality = this.SelectedLabTestResult.ResultNormality;
            this.DatePerformed = this.SelectedLabTestResult.DatePerformed;
            this.Status = this.SelectedLabTestResult.Status;
        }

        /// <summary>
        ///     Handles the updating of lab test result information in the application.
        /// </summary>
        public bool ManageLabTestResult()
        {
            var result = false;
            try
            {
                if (this.IsValid)
                {
                    this.UpdateLabTestResult();
                    result = true;
                    Debug.WriteLine(
                        $"Lab Test Result Updated: {this.TestResult} {this.ResultNormality} {this.DatePerformed.ToString()} {this.Status}");
                }
            }
            catch (MySqlException sqlException)
            {
                Debug.WriteLine(sqlException);
                this.OnErrorOccured($"{sqlException.Message}");
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                this.OnErrorOccured($"Exception \n {e.Message}");
            }

            return result;
        }

        private void UpdateLabTestResult()
        {
            var trimmedDatePerformed = this.DatePerformed.Value.Date;
            var newLabTestResult = new LabTestResult(this.SelectedLabTestResult.VisitId,
                this.SelectedLabTestResult.TestCode, this.TestResult,
                this.ResultNormality, trimmedDatePerformed, this.Status);

            newLabTestResult.ResultId = this.SelectedLabTestResult.ResultId;
            LabTestResultDal.EditLabTestResult(newLabTestResult);
        }

        #endregion

        #region Constants

        private const string INVALID_FIELD_INPUT = "Required field";
        private const string INVALID_DATE = "Invalid AppointmentDate";
        private const string INVALID_COMBO_BOX_SELECTION = "Please select valid option";

        #endregion

        #region Events

        /// <summary>
        ///     Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Occurs when an error message needs to be displayed.
        /// </summary>
        public EventHandler<string> ErrorOccured;

        protected virtual void OnErrorOccured(string message)
        {
            this.ErrorOccured?.Invoke(this, message);
        }

        /// <summary>
        ///     Raises the <see cref="PropertyChanged" /> event for a property.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            this.ValidateFields();
        }

        #endregion

        #region FieldValidation

        /// <summary>
        ///     Determines if the data enter by the user is valid
        /// </summary>
        public bool IsValid { get; private set; }

        /// <summary>
        ///     Gets the dictionary of validation error messages for form fields.
        /// </summary>
        public Dictionary<string, string> ValidationErrors { get; }

        /// <summary>
        ///     Validates the fields and updates the <see cref="ValidationErrors" /> dictionary with any validation errors.
        /// </summary>
        public void ValidateFields()
        {
            this.ValidationErrors.Clear();
            this.IsValid = true;

            if (string.IsNullOrWhiteSpace(this.TestResult))
            {
                this.ValidationErrors[nameof(this.TestResult)] = INVALID_FIELD_INPUT;
                this.IsValid = false;
            }

            if (string.IsNullOrWhiteSpace(this.ResultNormality))
            {
                this.ValidationErrors[nameof(this.ResultNormality)] = INVALID_COMBO_BOX_SELECTION;
                this.IsValid = false;
            }

            if (this.DatePerformed >= DateTime.Now)
            {
                this.ValidationErrors[nameof(this.DatePerformed)] = INVALID_DATE;
                this.IsValid = false;
            }
        }

        #endregion
    }
}