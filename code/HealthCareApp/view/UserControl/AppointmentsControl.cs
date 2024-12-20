﻿using HealthCareApp.model;
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

        this.appointmentsControlViewModel = new AppointmentsControlViewModel();

        // Set up the data grid view
        this.setUpOpenApptDataGridView();
        this.setupClosedApptDataGridView();
        this.setupTestResultDataGridView();

        // Set up the advanced search control
        this.apptAdvancedSearchControl.SearchBtnClick += this.refreshAppointmentsList;
        this.apptAdvancedSearchControl.ClearBtnClick += this.refreshAppointmentsList;

        this.apptAdvancedSearchControl.SetDateTimeSearch();
        this.apptAdvancedSearchControl.SetDatePickerStyle();

        this.bindVisitFields();
    }

    #endregion

    #region Buttons

    private void createAppointmentBtn_Click(object sender, EventArgs e)
    {
        var createAppointmentPage = new ManageAppointmentPage(null);
        createAppointmentPage.FormClosed += this.refreshAppointmentsList;
        createAppointmentPage.ShowDialog();
    }

    private void editAppointmentBtn_Click(object sender, EventArgs e)
    {
        if (this.appointmentsDataGridView.SelectedRows.Count > 0)
        {
            var selectedAppointment = (Appointment)this.appointmentsDataGridView.SelectedRows[0].DataBoundItem;
            var editAppointmentPage = new ManageAppointmentPage(selectedAppointment);
            editAppointmentPage.FormClosed += this.refreshAppointmentsList;
            editAppointmentPage.ShowDialog();
        }
    }

    private void editVisitButton_Click(object sender, EventArgs e)
    {
        var createVisitPage = new ManageVisitDetailsPage(this.appointmentsControlViewModel.SelectedAppointment.AppointmentId);
        createVisitPage.FormClosed += this.populateVisitFields;
        createVisitPage.ShowDialog();
    }

    private void enterTestResultButton_Click(object sender, EventArgs e)
    {
        if (this.testResultDataGrid.SelectedRows.Count > 0)
        {
            var selectedLabTestResult = (LabTestResult)this.testResultDataGrid.SelectedRows[0].DataBoundItem;
            var manageLabTestResultPage = new ManageLabTestResultsPage(selectedLabTestResult);
            manageLabTestResultPage.FormClosed += this.populateVisitFields;
            manageLabTestResultPage.ShowDialog();
        }
    }

    #endregion

    #region Methods

    private void setupTestResultDataGridView()
    {
        this.testResultDataGrid.DataSource = this.appointmentsControlViewModel.LabTestResults;

        this.testResultDataGrid.Columns["ResultId"].Visible = false;
        this.testResultDataGrid.Columns["VisitId"].Visible = false;
        this.testResultDataGrid.Columns["TestCode"].Visible = false;

        this.testResultDataGrid.Columns["TestName"].DisplayIndex = 0;
    }

    private void refreshAppointmentsList(object sender, EventArgs e)
    {
        if (e is SearchEventArgs searchArgs)
        {
            this.appointmentsControlViewModel.PopulateAppointments(searchArgs);
        }
        else
        {
            this.appointmentsControlViewModel.PopulateAppointments();
        }

        this.appointmentsDataGridView.DataSource = this.appointmentsControlViewModel.OpenAppointments;
        this.closedApptDataGrid.DataSource = this.appointmentsControlViewModel.ClosedAppointments;
    }

    private void populateVisitFields(object? sender, FormClosedEventArgs e)
    {
        this.appointmentsControlViewModel.tryToGetVisit();
        this.refreshVisitInfo(this.appointmentsControlViewModel.SelectedAppointment);
    }

    private void AppointmentsDataGridView_SelectionChanged(object? sender, EventArgs e)
    {

        if (this.appointmentsDataGridView.SelectedRows.Count > 0)
        {
            this.closedApptDataGrid.ClearSelection();
            if (this.appointmentsDataGridView.SelectedRows[0].DataBoundItem is Appointment selectedAppointment)
            {
                this.refreshVisitInfo(selectedAppointment);

                this.editAppointmentBtn.Enabled = true;
            }
        }
        else
        {
            this.appointmentsControlViewModel.SelectedAppointment = null;
            this.editAppointmentBtn.Enabled = false;
        }
    }

    private void refreshVisitInfo(Appointment selectedAppointment)
    {
        this.appointmentsControlViewModel.SelectedAppointment = selectedAppointment;
        this.appointmentsControlViewModel.PopulateVisitFields();

        this.bloodPressureDiasTxtField.Text = this.appointmentsControlViewModel.BloodPressureDiastolic.ToString();

        this.testResultDataGrid.DataSource = this.appointmentsControlViewModel.LabTestResults;
        this.appointmentsControlViewModel.populateTestResults();
    }

    private void closedApptDataGrid_SelectionChanged(object sender, EventArgs e)
    {
        if (this.closedApptDataGrid.SelectedRows.Count > 0)
        {
            this.appointmentsDataGridView.ClearSelection();
            if (this.closedApptDataGrid.SelectedRows[0].DataBoundItem is Appointment selectedAppointment)
            {
                this.refreshVisitInfo(selectedAppointment);

            }
        }
    }

    private void setUpOpenApptDataGridView()
    {
        this.appointmentsDataGridView.DataSource = this.appointmentsControlViewModel.OpenAppointments;
        this.appointmentsDataGridView.SelectionChanged += this.AppointmentsDataGridView_SelectionChanged;

        // Hide the columns that are not needed
        this.appointmentsDataGridView.Columns["AppointmentId"].Visible = false;
        this.appointmentsDataGridView.Columns["PatientId"].Visible = false;
        this.appointmentsDataGridView.Columns["DoctorId"].Visible = false;
        this.appointmentsDataGridView.Columns["Reason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        // Rename main columns
        this.appointmentsDataGridView.Columns["PatientName"].HeaderText = "Patient Name";
        this.appointmentsDataGridView.Columns["DoctorName"].HeaderText = "Doctor Name";
        this.appointmentsDataGridView.Columns["AppointmentDate"].HeaderText = "Date of Appointment";

        this.appointmentsDataGridView.ClearSelection();
    }

    private void setupClosedApptDataGridView()
    {
        this.closedApptDataGrid.DataSource = this.appointmentsControlViewModel.ClosedAppointments;
        this.closedApptDataGrid.SelectionChanged += this.closedApptDataGrid_SelectionChanged;

        // Hide the columns that are not needed
        this.closedApptDataGrid.Columns["AppointmentId"].Visible = false;
        this.closedApptDataGrid.Columns["PatientId"].Visible = false;
        this.closedApptDataGrid.Columns["DoctorId"].Visible = false;
        this.closedApptDataGrid.Columns["Reason"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        // Rename main columns
        this.closedApptDataGrid.Columns["PatientName"].HeaderText = "Patient Name";
        this.closedApptDataGrid.Columns["DoctorName"].HeaderText = "Doctor Name";
        this.closedApptDataGrid.Columns["AppointmentDate"].HeaderText = "Date of Appointment";

        this.closedApptDataGrid.ClearSelection();
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
}