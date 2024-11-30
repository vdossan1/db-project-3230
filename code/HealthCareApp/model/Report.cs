using HealthCareApp.DAL;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.model
{
	public class Report
	{
		#region Properties

		public int VisitId { get; set; }
		public DateTime VisitDate { get; set; }
		public int PatientId { get; set; }
		public string PatientName { get; set; }
		public string NurseName { get; set; }
		public string DoctorName { get; set; }

		public List<string> LabTests { get; set; }
		public List<LabTestResult> LabTestResults { get; set; }

		#endregion

		#region Constructors

		public Report(int visitId, DateTime visitDate, int patientId, int nurseId, int doctorId)
		{
			this.VisitId = visitId;
			this.VisitDate = visitDate;
			this.PatientId = patientId;

			LabTests = new List<string>();
			LabTestResults = new List<LabTestResult>();
		}

		#endregion
	}
}
