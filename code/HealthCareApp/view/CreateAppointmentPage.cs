// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view
{
	/// <summary>
	/// Represents the interface for adding a new appointment in the healthcare application.
	/// </summary>
	public partial class CreateAppointmentPage : Form
	{
		//private CreateAppointmentPageViewModel createAppointmentViewModel;

		/// <summary>
		/// Initializes a new instance of the <see cref="CreateAppointmentPage"/> class.
		/// </summary>
		public CreateAppointmentPage()
		{
			InitializeComponent();
			//this.createAppointmentViewModel = new CreateAppointmentPageViewModel();
			this.patientsDataGridView.DataSource = createAppointmentViewModel.Patients;
			this.doctorsDataGridView.DataSource = createAppointmentViewModel.Doctors;
			this.createAppointmentViewModel.ErrorOccured += ErrorOccured;
		}

		#region Events

		private void createAppointmentButton_Click(object? sender, EventArgs e)
		{
			this.createAppointmentViewModel.ValidateFields();

			if (this.createAppointmentViewModel.CreateAppointment())
			{
				OnActionButtonPressed();
				this.Hide();
				this.Dispose();
			}
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			this.Hide();
			this.Dispose();
		}

		private void ErrorOccured(object? sender, string e)
		{
			MessageBox.Show(e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void OnActionButtonPressed()
		{
			MessageBox.Show($"Appointment Created Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		#endregion

		#region Bindings

		private void BindControls()
		{
			// Data Bindings
			this.datePicker.DataBindings.Add(
				"Value", createAppointmentViewModel, nameof(createAppointmentViewModel.Date), true, DataSourceUpdateMode.OnPropertyChanged);

			this.timePicker.DataBindings.Add(
				"Value", createAppointmentViewModel, nameof(createAppointmentViewModel.Time), true, DataSourceUpdateMode.OnPropertyChanged);

			this.reasonTextBox.DataBindings.Add(
				"Text", createAppointmentViewModel, nameof(createAppointmentViewModel.Reason), true, DataSourceUpdateMode.OnPropertyChanged);

			this.createAppointmentButton.DataBindings.Add(
				"Enabled", createAppointmentViewModel, nameof(createAppointmentViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void BindValidationMessages()
		{
			this.patientErrorLabelErrorLabel.DataBindings.Add(
				"Text", createAppointmentViewModel, nameof(createAppointmentViewModel.PatientValidationMessage));

			this.doctorErrorLabel.DataBindings.Add(
				"Text", createAppointmentViewModel, nameof(createAppointmentViewModel.DoctorValidationMessage));

			this.reasonErrorLabel.DataBindings.Add(
				"Text", createAppointmentViewModel, nameof(createAppointmentViewModel.ReasonValidationMessage));

			this.dateErrorLabel.DataBindings.Add(
				"Text", createAppointmentViewModel, nameof(createAppointmentViewModel.DateValidationMessage));

			this.timeErrorLabel.DataBindings.Add(
				"Text", createAppointmentViewModel, nameof(createAppointmentViewModel.TimeValidationMessage));
		}

		#endregion
	}
}
