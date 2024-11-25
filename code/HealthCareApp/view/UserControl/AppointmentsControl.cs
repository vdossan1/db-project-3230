using HealthCareApp.model;
using HealthCareApp.viewmodel.UserControlVM;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents a user control for managing appointments, allowing users to create, edit, and search for appointments.
/// </summary>
public partial class AppointmentsControl : UserControl
{
    #region Data members

    private AppointmentsControlViewModel appointmentsControlViewModel;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="AppointmentsControl" /> class and sets up the data grid and event
    ///     handlers.
    /// </summary>
    public AppointmentsControl()
    {
        this.InitializeComponent();
        this.SetUpPage();

        this.bindVisitFields();
    }

    private void SetUpPage()
    {
        // Set up the data grid view
        this.appointmentsControlViewModel = new AppointmentsControlViewModel();

        this.setUpOpenApptDataGridView();
        this.setupClosedApptDataGridView();

        // Set up the advanced search control
        this.apptAdvancedSearchControl.SearchBtnClick += this.RefreshAppointmentsList;
        this.apptAdvancedSearchControl.ClearBtnClick += this.RefreshAppointmentsList;

        this.apptAdvancedSearchControl.SetDateTimeSearch();
        this.apptAdvancedSearchControl.SetDatePickerStyle();
    }

    private void setupClosedApptDataGridView()
    {
        this.closedApptDataGrid.DataSource = this.appointmentsControlViewModel.ClosedAppointments;
        this.closedApptDataGrid.SelectionChanged += this.closedApptDataGrid_SelectionChanged;

        // Hide the columns that are not needed
        this.closedApptDataGrid.Columns["AppointmentId"].Visible = false;
        this.closedApptDataGrid.Columns["PatientId"].Visible = false;
        this.closedApptDataGrid.Columns["DoctorId"].Visible = false;
        this.closedApptDataGrid.Columns["PatientName"].Width = 150;
        this.closedApptDataGrid.Columns["DoctorName"].Width = 150;
        this.closedApptDataGrid.Columns["AppointmentDate"].Width = 200;
        this.closedApptDataGrid.Columns["Reason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        // Rename main columns
        this.closedApptDataGrid.Columns["PatientName"].HeaderText = "Patient Name";
        this.closedApptDataGrid.Columns["DoctorName"].HeaderText = "Doctor Name";
        this.closedApptDataGrid.Columns["AppointmentDate"].HeaderText = "Date of Appointment";

        this.closedApptDataGrid.ClearSelection();
    }

    private void setUpOpenApptDataGridView()
    {
        this.appointmentsDataGridView.DataSource = this.appointmentsControlViewModel.Appointments;
        this.appointmentsDataGridView.SelectionChanged += this.AppointmentsDataGridView_SelectionChanged;

        // Hide the columns that are not needed
        this.appointmentsDataGridView.Columns["AppointmentId"].Visible = false;
        this.appointmentsDataGridView.Columns["PatientId"].Visible = false;
        this.appointmentsDataGridView.Columns["DoctorId"].Visible = false;
        this.appointmentsDataGridView.Columns["PatientName"].Width = 150;
        this.appointmentsDataGridView.Columns["DoctorName"].Width = 150;
        this.appointmentsDataGridView.Columns["AppointmentDate"].Width = 200;
        this.appointmentsDataGridView.Columns["Reason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        // Rename main columns
        this.appointmentsDataGridView.Columns["PatientName"].HeaderText = "Patient Name";
        this.appointmentsDataGridView.Columns["DoctorName"].HeaderText = "Doctor Name";
        this.appointmentsDataGridView.Columns["AppointmentDate"].HeaderText = "Date of Appointment";

        this.appointmentsDataGridView.ClearSelection();
    }

    private void bindVisitFields()
    {
        this.editAppointmentBtn.DataBindings.Add("Enabled", this.appointmentsControlViewModel, 
            nameof(this.appointmentsControlViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);

        this.bloodPressureSysTxtField.DataBindings.Add(
            "Text", this.appointmentsControlViewModel,
            nameof(this.appointmentsControlViewModel.BloodPressureSystolic), true, DataSourceUpdateMode.OnPropertyChanged);

        this.bloodPressureDiasTxtField.DataBindings.Add(
            "Text", this.appointmentsControlViewModel,
            nameof(this.appointmentsControlViewModel.BloodPressureDiastolic), true, DataSourceUpdateMode.OnPropertyChanged);

        this.weightTxtField.DataBindings.Add(
            "Text", this.appointmentsControlViewModel, nameof(this.appointmentsControlViewModel.Weight), true, DataSourceUpdateMode.OnPropertyChanged);

        this.heightTxtField.DataBindings.Add(
            "Text", this.appointmentsControlViewModel, nameof(this.appointmentsControlViewModel.Height), true, DataSourceUpdateMode.OnPropertyChanged);

        this.pulseTxtField.DataBindings.Add(
            "Text", this.appointmentsControlViewModel, nameof(this.appointmentsControlViewModel.PulseRate), true, DataSourceUpdateMode.OnPropertyChanged);

        this.bodyTempTxtField.DataBindings.Add(
            "Text", this.appointmentsControlViewModel, nameof(this.appointmentsControlViewModel.BodyTemp), true, DataSourceUpdateMode.OnPropertyChanged);

        this.symptomsTxtBox.DataBindings.Add(
            "Text", this.appointmentsControlViewModel, nameof(this.appointmentsControlViewModel.Symptoms), true, DataSourceUpdateMode.OnPropertyChanged);

        this.initDiagnosesTxtBox.DataBindings.Add(
            "Text", this.appointmentsControlViewModel, nameof(this.appointmentsControlViewModel.InitialDiagnoses), true, DataSourceUpdateMode.OnPropertyChanged);

        this.finalDiagnosesTxtBox.DataBindings.Add(
            "Text", this.appointmentsControlViewModel, nameof(this.appointmentsControlViewModel.FinalDiagnoses), true, DataSourceUpdateMode.OnPropertyChanged);
    }

    #endregion

    #region Methods

    private void createAppointmentBtn_Click(object sender, EventArgs e)
    {
        var createAppointmentPage = new ManageAppointmentPage(null);
        createAppointmentPage.FormClosed += this.RefreshAppointmentsList;
        createAppointmentPage.ShowDialog();
    }

    private void editAppointmentBtn_Click(object sender, EventArgs e)
    {
        if (this.appointmentsDataGridView.SelectedRows.Count > 0)
        {
            var selectedAppointment = (Appointment)this.appointmentsDataGridView.SelectedRows[0].DataBoundItem;
            var editAppointmentPage = new ManageAppointmentPage(selectedAppointment);
            editAppointmentPage.FormClosed += this.RefreshAppointmentsList;
            editAppointmentPage.ShowDialog();
        }
    }

    private void RefreshAppointmentsList(object sender, EventArgs e)
    {
        if (e is SearchEventArgs searchArgs)
        {
            this.appointmentsControlViewModel.PopulateAppointments(searchArgs);
        }
        else
        {
            this.appointmentsControlViewModel.PopulateAppointments();
        }

        this.appointmentsDataGridView.DataSource = this.appointmentsControlViewModel.Appointments;
        this.closedApptDataGrid.DataSource = this.appointmentsControlViewModel.ClosedAppointments;
    }

    private void AppointmentsDataGridView_SelectionChanged(object? sender, EventArgs e)
    {
        
        if (this.appointmentsDataGridView.SelectedRows.Count > 0)
        {
            this.closedApptDataGrid.ClearSelection();
            if (this.appointmentsDataGridView.SelectedRows[0].DataBoundItem is Appointment selectedAppointment)
            {
                this.appointmentsControlViewModel.SelectedAppointment = selectedAppointment;
                this.appointmentsControlViewModel.PopulateVisitFields();
                this.selectedTestListBox.DataSource = this.appointmentsControlViewModel.SelectedTests;
                this.bloodPressureDiasTxtField.Text = this.appointmentsControlViewModel.BloodPressureDiastolic.ToString();
                this.selectedTestListBox.SelectedItem = null;
                this.editAppointmentBtn.Enabled = true;
            }
            else
            {
                this.appointmentsControlViewModel.SelectedAppointment = null;
                this.editAppointmentBtn.Enabled = false;
            }
        }
        else
        {
            this.appointmentsControlViewModel.SelectedAppointment = null;
            this.editAppointmentBtn.Enabled = false;
        }
    }

    private void closedApptDataGrid_SelectionChanged(object sender, EventArgs e)
    {
        if (this.closedApptDataGrid.SelectedRows.Count > 0)
        {
            this.appointmentsDataGridView.ClearSelection();
            if (this.closedApptDataGrid.SelectedRows[0].DataBoundItem is Appointment selectedAppointment)
            {
                this.appointmentsControlViewModel.SelectedAppointment = selectedAppointment;
                this.appointmentsControlViewModel.PopulateVisitFields();
                this.selectedTestListBox.DataSource = this.appointmentsControlViewModel.SelectedTests;
                this.bloodPressureDiasTxtField.Text = this.appointmentsControlViewModel.BloodPressureDiastolic.ToString();
                this.selectedTestListBox.SelectedItem = null;
            }
        }
    }

    

    #endregion

    private void editVisitButton_Click(object sender, EventArgs e)
    {

    }
}