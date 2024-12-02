using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;
using HealthCareApp.viewmodel;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents the interface for adding a new appointment in the healthcare application.
/// </summary>
public partial class ManageAppointmentPage : Form
{
	#region Data members

	private const string CREATE_ACTION = "Create";
	private const string EDIT_ACTION = "Update";
	private const string TIME_FORMAT = "yyyy-MM-dd HH:mm";

	private readonly ManageAppointmentViewModel manageAppointmentViewModel;
	private AppointmentAction appointmentAction;

	#endregion

	#region Constructors

	/// <summary>
	///     Initializes a new instance of the <see cref="ManageAppointmentPage" /> class.
	/// </summary>
	public ManageAppointmentPage(Appointment? selectedAppointment = null)
	{
		this.InitializeComponent();

		this.manageAppointmentViewModel = selectedAppointment == null
			? new ManageAppointmentViewModel()
			: new ManageAppointmentViewModel(selectedAppointment);
		this.manageAppointmentViewModel.ErrorOccured += this.ErrorOccured;

		this.SetPageAction(selectedAppointment);

		this.BindControls();
		this.BindValidationMessages();

		this.patientsDataGridView.DataSource = this.manageAppointmentViewModel.Patients;
		this.doctorsDataGridView.DataSource = this.manageAppointmentViewModel.Doctors;
		this.patientsDataGridView.Columns["PatientId"].Visible = false;
		this.doctorsDataGridView.Columns["DoctorId"].Visible = false;

		this.datePicker.Format = DateTimePickerFormat.Custom;
		this.datePicker.CustomFormat = TIME_FORMAT;
		this.datePicker.MaxDate = DateTime.Parse("2124-01-01");
		this.datePicker.MinDate = DateTime.Today;

		this.advancedSearchControlPatient.SearchBtnClick += this.RefreshPatientsDataGrid;
		this.advancedSearchControlPatient.ClearBtnClick += this.RefreshPatientsDataGrid;
		this.advancedSearchControlDoctor.SearchBtnClick += this.RefreshDoctorsDataGrid;
		this.advancedSearchControlDoctor.ClearBtnClick += this.RefreshDoctorsDataGrid;
	}

	#endregion

	#region Methods

	private void SetPageAction(Appointment? selectedAppointment)
	{
		if (selectedAppointment != null)
		{
			this.manageAppointmentViewModel.PopulateFields(selectedAppointment);
			this.selectPatientAndDoctor();
			Text = EDIT_ACTION + " Appointment";
			this.actionButton.Text = EDIT_ACTION;
			this.appointmentAction = AppointmentAction.EDIT;
			this.patientsDataGridView.Enabled = false;
			this.advancedSearchControlPatient.Enabled = false;
		}
		else
		{
			Text = CREATE_ACTION + " Appointment";
			this.actionButton.Text = CREATE_ACTION;
			this.appointmentAction = AppointmentAction.CREATE;
		}
	}

	private void OnActionButtonPressed()
	{
		MessageBox.Show($"{Text} complete", "Confirmation", MessageBoxButtons.OK,
			MessageBoxIcon.Information);
	}

	private void RefreshPatientsDataGrid(object sender, EventArgs e)
	{
		if (e is SearchEventArgs searchArgs)
		{
			this.manageAppointmentViewModel.PopulatePatientsDataGrid(searchArgs);
		}
		else
		{
			this.manageAppointmentViewModel.PopulatePatientsDataGrid();
		}

		this.patientsDataGridView.DataSource = this.manageAppointmentViewModel.Patients;
	}

	private void RefreshDoctorsDataGrid(object sender, EventArgs e)
	{
		if (e is SearchEventArgs searchArgs)
		{
			this.manageAppointmentViewModel.PopulateDoctorsDataGrid(searchArgs);
		}
		else
		{
			this.manageAppointmentViewModel.PopulateDoctorsDataGrid();
		}

		this.doctorsDataGridView.DataSource = this.manageAppointmentViewModel.Doctors;
	}

	private void selectPatientAndDoctor()
	{
		var patient = PatientDal.GetPatientById(this.manageAppointmentViewModel.Patient.PatientId);
		var doctor = DoctorDal.GetDoctorById(this.manageAppointmentViewModel.Doctor.DoctorId);

		var patientSearch = new SearchEventArgs(patient.FirstName, patient.LastName, patient.DateOfBirth);
		var doctorSearch = new SearchEventArgs(doctor.FirstName, doctor.LastName, doctor.DateOfBirth);

		this.RefreshPatientsDataGrid(this, patientSearch);
		this.RefreshDoctorsDataGrid(this, doctorSearch);
	}

	#endregion

	#region Events

	private void createAppointmentButton_Click(object? sender, EventArgs e)
	{
		this.manageAppointmentViewModel.ValidateFields();

		if (this.manageAppointmentViewModel.ManageAppointment(this.appointmentAction))
		{
			this.OnActionButtonPressed();
			Hide();
			Dispose();
		}
	}

	private void cancelBtn_Click(object sender, EventArgs e)
	{
		Hide();
		Dispose();
	}

	private void patientsDataGridView_SelectionChanged(object sender, EventArgs e)
	{
		if (this.patientsDataGridView.CurrentRow?.DataBoundItem is Patient selectedPatient)
		{
			this.manageAppointmentViewModel.Patient = selectedPatient;
		}
	}

	private void doctorsDataGridView_SelectionChanged(object sender, EventArgs e)
	{
		if (this.doctorsDataGridView.CurrentRow?.DataBoundItem is Doctor selectedDoctor)
		{
			this.manageAppointmentViewModel.Doctor = selectedDoctor;
		}
	}

	private void ErrorOccured(object? sender, string e)
	{
		if (e.Contains("appointment.doctor_appointment_unique"))
		{
			MessageBox.Show("Doctor is booked for this time.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		else
		{
			MessageBox.Show(e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	#endregion

	#region Bindings

	private void BindControls()
	{
		// Data Bindings
		this.reasonTextBox.DataBindings.Add(
			"Text", this.manageAppointmentViewModel, nameof(this.manageAppointmentViewModel.Reason), true,
			DataSourceUpdateMode.OnPropertyChanged);

		this.datePicker.DataBindings.Add(
			"Value", this.manageAppointmentViewModel, nameof(this.manageAppointmentViewModel.Date), true,
			DataSourceUpdateMode.OnPropertyChanged);

		this.actionButton.DataBindings.Add(
			"Enabled", this.manageAppointmentViewModel, nameof(this.manageAppointmentViewModel.IsValid), true,
			DataSourceUpdateMode.OnPropertyChanged);
	}

	private void BindValidationMessages()
	{
		this.patientErrorLabel.DataBindings.Add(
			"Text", this.manageAppointmentViewModel, nameof(this.manageAppointmentViewModel.PatientValidationMessage));

		this.doctorErrorLabel.DataBindings.Add(
			"Text", this.manageAppointmentViewModel, nameof(this.manageAppointmentViewModel.DoctorValidationMessage));

		this.reasonErrorLabel.DataBindings.Add(
			"Text", this.manageAppointmentViewModel, nameof(this.manageAppointmentViewModel.ReasonValidationMessage));

		this.dateErrorLabel.DataBindings.Add(
			"Text", this.manageAppointmentViewModel, nameof(this.manageAppointmentViewModel.DateValidationMessage));
	}

	#endregion
}