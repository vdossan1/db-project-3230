// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using HealthCareApp.viewmodel;

namespace HealthCareApp.view
{
	/// <summary>
	/// Represents the interface for adding a new appointment in the healthcare application.
	/// </summary>
	public partial class ManageAppointmentPage : Form
	{
		private ManageAppointmentViewModel manageAppointmentViewModel;
		private AppointmentAction appointmentAction;

		private const string CREATE_ACTION = "Create";
		private const string EDIT_ACTION = "Update";

		/// <summary>
		/// Initializes a new instance of the <see cref="ManageAppointmentPage"/> class.
		/// </summary>
		public ManageAppointmentPage(Appointment? selectedAppointment)
		{
			InitializeComponent();
			this.manageAppointmentViewModel = new ManageAppointmentViewModel();
			this.manageAppointmentViewModel.ErrorOccured += ErrorOccured;
			this.SetPageAction(selectedAppointment);

			this.BindControls();
			this.BindValidationMessages();

			this.patientsDataGridView.DataSource = manageAppointmentViewModel.Patients;
			this.doctorsDataGridView.DataSource = manageAppointmentViewModel.Doctors;
			this.patientsDataGridView.Columns["PatientId"].Visible = false;
			this.doctorsDataGridView.Columns["DoctorId"].Visible = false;
		}

		private void SetPageAction(Appointment? selectedAppointment)
		{
			if (selectedAppointment != null)
			{
				this.manageAppointmentViewModel.PopulateFields(selectedAppointment);
				this.Text = EDIT_ACTION + " Appointment";
				this.actionButton.Text = EDIT_ACTION;
				this.appointmentAction = AppointmentAction.EDIT;
			}
			else
			{
				this.Text = CREATE_ACTION + " Appointment";
				this.actionButton.Text = CREATE_ACTION;
				this.appointmentAction = AppointmentAction.CREATE;
			}
		}

		private void OnActionButtonPressed()
		{
			var text = this.GetActionString();
			MessageBox.Show($"Patient {text} Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private string GetActionString()
		{
			var actionString = "";
			switch (this.appointmentAction)
			{
				case AppointmentAction.CREATE:
					actionString = CREATE_ACTION + "d";
					break;
				case AppointmentAction.EDIT:
					actionString = EDIT_ACTION + "d";
					break;
			}
			return actionString;
		}

		#region Events

		private void createAppointmentButton_Click(object? sender, EventArgs e)
		{
			this.manageAppointmentViewModel.ValidateFields();

			if (this.manageAppointmentViewModel.ManageAppointment(this.appointmentAction))
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

		#endregion

		#region Bindings

		private void BindControls()
		{
			// Select Patient Row
			foreach (DataGridViewRow row in this.patientsDataGridView.Rows)
			{
				var patient = row.DataBoundItem as Patient;
				if (patient != null && patient.Ssn == manageAppointmentViewModel.Patient.Ssn)
				{
					row.Selected = true;
					this.patientsDataGridView.CurrentCell = row.Cells[0];
					break;
				}
			}

			// Select Doctor Row
			foreach (DataGridViewRow row in this.doctorsDataGridView.Rows)
			{
				var doctor = row.DataBoundItem as Doctor;
				if (doctor != null && doctor.Ssn == manageAppointmentViewModel.Doctor.Ssn)
				{
					row.Selected = true;
					this.doctorsDataGridView.CurrentCell = row.Cells[0];
					break;
				}
			}

			// Data Bindings
			this.reasonTextBox.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.Reason), true, DataSourceUpdateMode.OnPropertyChanged);

			this.datePicker.DataBindings.Add(
				"Value", manageAppointmentViewModel, nameof(manageAppointmentViewModel.Date), true, DataSourceUpdateMode.OnPropertyChanged);

			this.timePicker.DataBindings.Add(
				"Value", manageAppointmentViewModel, nameof(manageAppointmentViewModel.Time), true, DataSourceUpdateMode.OnPropertyChanged);

			this.actionButton.DataBindings.Add(
				"Enabled", manageAppointmentViewModel, nameof(manageAppointmentViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void BindValidationMessages()
		{
			//this.patientErrorLabel.DataBindings.Add(
			//	"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.PatientValidationMessage));

			//this.doctorErrorLabel.DataBindings.Add(
			//	"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.DoctorValidationMessage));

			this.reasonErrorLabel.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.ReasonValidationMessage));

			this.dateErrorLabel.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.DateValidationMessage));

			this.timeErrorLabel.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.TimeValidationMessage));
		}

		#endregion
	}
}
