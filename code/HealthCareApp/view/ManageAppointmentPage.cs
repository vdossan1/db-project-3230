// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using HealthCareApp.viewmodel;
using static HealthCareApp.view.AdvancedSearchControl;

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
		private const string TIME_FORMAT = "yyyy-MM-dd HH:mm";

		/// <summary>
		/// Initializes a new instance of the <see cref="ManageAppointmentPage"/> class.
		/// </summary>
		public ManageAppointmentPage(Appointment? selectedAppointment)
		{
			InitializeComponent();
			this.manageAppointmentViewModel = new ManageAppointmentViewModel();
			this.manageAppointmentViewModel.SelectedAppointment = selectedAppointment;
			this.manageAppointmentViewModel.ErrorOccured += ErrorOccured;
			this.SetPageAction(selectedAppointment);

			this.BindControls();
			this.BindValidationMessages();

			this.patientsDataGridView.DataSource = manageAppointmentViewModel.Patients;
			this.doctorsDataGridView.DataSource = manageAppointmentViewModel.Doctors;
			this.patientsDataGridView.Columns["PatientId"].Visible = false;
			this.doctorsDataGridView.Columns["DoctorId"].Visible = false;
			
			this.datePicker.Format = DateTimePickerFormat.Custom;
			this.datePicker.CustomFormat = TIME_FORMAT;
			this.datePicker.MaxDate = DateTime.Parse("2124-01-01");
			this.datePicker.MinDate = DateTime.Today;
		}

		private void SetPageAction(Appointment? selectedAppointment)
		{
			if (selectedAppointment != null)
			{
				this.manageAppointmentViewModel.PopulateFields(selectedAppointment);
				this.RefreshDataGrids(this, EventArgs.Empty);
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
			MessageBox.Show($"Appointment {text} Successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

		private void RefreshDataGrids(object sender, EventArgs e)
		{
			if (e is SearchEventArgs searchArgs)
			{
				this.manageAppointmentViewModel.PopulateDataGrids(searchArgs);
			}
			else
			{
				this.manageAppointmentViewModel.PopulateDataGrids();
			}
			this.patientsDataGridView.DataSource = manageAppointmentViewModel.Patients;
			this.doctorsDataGridView.DataSource = manageAppointmentViewModel.Doctors;
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

		private void patientsDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (patientsDataGridView.CurrentRow?.DataBoundItem is Patient selectedPatient)
			{
				manageAppointmentViewModel.Patient = selectedPatient;
			}
		}

		private void doctorsDataGridView_SelectionChanged(object sender, EventArgs e)
		{
			if (doctorsDataGridView.CurrentRow?.DataBoundItem is Doctor selectedDoctor)
			{
				manageAppointmentViewModel.Doctor = selectedDoctor;
			}
		}

		private void ErrorOccured(object? sender, string e)
		{
			if (e.Contains("appointment.doctor_appointment_unique"))
			{
				MessageBox.Show("Doctor is booked for this time.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else 
				MessageBox.Show(e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion

		#region Bindings

		private void BindControls()
		{
			// Data Bindings
			this.reasonTextBox.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.Reason), true, DataSourceUpdateMode.OnPropertyChanged);

			this.datePicker.DataBindings.Add(
				"Value", manageAppointmentViewModel, nameof(manageAppointmentViewModel.Date), true, DataSourceUpdateMode.OnPropertyChanged);

			this.actionButton.DataBindings.Add(
				"Enabled", manageAppointmentViewModel, nameof(manageAppointmentViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void BindValidationMessages()
		{
			this.patientErrorLabel.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.PatientValidationMessage));

			this.doctorErrorLabel.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.DoctorValidationMessage));

			this.reasonErrorLabel.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.ReasonValidationMessage));

			this.dateErrorLabel.DataBindings.Add(
				"Text", manageAppointmentViewModel, nameof(manageAppointmentViewModel.DateValidationMessage));
		}

		#endregion
	}
}
