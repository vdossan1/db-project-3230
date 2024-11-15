// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.model
{
	/// <summary>
	/// Represents a laboratory test with details such as test code, name, normal range values, and unit of measurement.
	/// </summary>
	public class LabTest
	{
		#region Properties

		/// <summary>
		/// Gets or sets the unique code identifying the laboratory test.
		/// </summary>
		public int TestCode { get; set; }

		/// <summary>
		/// Gets or sets the name of the laboratory test.
		/// </summary>
		public string TestName { get; set; }

		/// <summary>
		/// Gets or sets the upper limit of the normal range for the test result.
		/// </summary>
		public decimal HighValue { get; set; }

		/// <summary>
		/// Gets or sets the lower limit of the normal range for the test result.
		/// </summary>
		public decimal LowValue { get; set; }

		/// <summary>
		/// Gets or sets the unit of measurement for the test result.
		/// </summary>
		public string Unit { get; set; }

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="LabTest"/> class with the specified test code, test name, normal range values, and unit.
		/// </summary>
		public LabTest(int testCode, string testName, decimal highValue, decimal lowValue, string unit)
		{
			this.TestCode = testCode;
			this.TestName = testName;
			this.HighValue = highValue;
			this.LowValue = lowValue;
			this.Unit = unit;
		}

		#endregion
	}

}
