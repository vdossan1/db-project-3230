using HealthCareApp.utils;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.model
{
    /// <summary>
    /// Represents a specific result of a laboratory test, including information about the test performed, result, normality, and date of performance.
    /// </summary>
    public class LabTestResult
    {
        #region Properties

        /// <summary>
        /// Gets or sets the unique identifier for the test result.
        /// </summary>
        public int ResultId { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier for the visit associated with this result.
        /// </summary>
        public int? VisitId { get; set; }

        /// <summary>
        /// Gets or sets the code identifying the laboratory test associated with this result.
        /// </summary>
        public int TestCode { get; set; }

        /// <summary>
        /// Gets or sets the result of the laboratory test as a string.
        /// </summary>
        public string? TestResult { get; set; }

        /// <summary>
        /// Gets or sets the normality status of the test result, indicating if the result is within or outside the normal range.
        /// </summary>
        public string? ResultNormality { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the test was performed.
        /// </summary>
        public DateTime? DatePerformed { get; set; }

        /// <summary>
        ///     Gets or sets the status of the LabTestResult (active or inactive).
        /// </summary>
        public bool Status { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="LabTestResult"/> class with the specified result details.
        /// </summary>
        public LabTestResult(int? visitId, int testCode, string? testResult, string? resultNormality,
            DateTime? datePerformed, bool status)
        {
            this.VisitId = visitId;
            this.TestCode = testCode;
            this.TestResult = testResult;
            this.ResultNormality = resultNormality;
            this.DatePerformed = datePerformed;
            this.Status = status;
        }

        #endregion
    }
}