using HealthCareApp.model;
using HealthCareApp.viewmodel.UserControlVM;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents a user control for managing patients, allowing users to create, edit, and search for patients.
/// </summary>
public partial class PatientsControl : UserControl
{
    #region Data members

    private PatientsControlViewModel patientsControlViewModel;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="PatientsControl" /> class and sets up the data grid and event
    ///     handlers.
    /// </summary>
    public PatientsControl()
    {
        this.InitializeComponent();
        this.SetupPage();

        this.patientsDataGridView.CellContentClick += changeStatus;
    }

    private void changeStatus(object? sender, DataGridViewCellEventArgs e)
    {
        var currentCel = this.patientsDataGridView.CurrentCell;

        if (currentCel != null)
        {
            var currentColumn = this.patientsDataGridView.Columns[currentCel.ColumnIndex];

            if (currentColumn.Name.Equals("Status"))
            {
                var newPatientStatus = !(bool)currentCel.Value;

                this.patientsControlViewModel.changePatientStatus(newPatientStatus);
            }
        }
    }

    #endregion

    #region Methods

    private void registerPatientBtn_Click(object sender, EventArgs e)
    {
        var addPatientPage = new ManagePatientPage();
        addPatientPage.FormClosed += this.RefreshPatientList;
        addPatientPage.ShowDialog();
    }

    private void editPatientBtn_Click(object sender, EventArgs e)
    {
        if (this.patientsDataGridView.SelectedRows.Count > 0)
        {
            var selectedPatient = (Patient)this.patientsDataGridView.SelectedRows[0].DataBoundItem;
            var editPatientPage = new ManagePatientPage(selectedPatient);
            editPatientPage.FormClosed += this.RefreshPatientList;
            editPatientPage.ShowDialog();
        }
    }

    private void RefreshPatientList(object sender, EventArgs e)
    {
        if (e is SearchEventArgs searchArgs)
        {
            this.patientsControlViewModel.PopulatePatients(searchArgs);
        }
        else
        {
            this.patientsControlViewModel.PopulatePatients();
        }

        this.patientsDataGridView.DataSource = this.patientsControlViewModel.Patients;
        this.patientsDataGridView.ClearSelection();
    }

    private void PatientsDataGridView_SelectionChanged(object? sender, EventArgs e)
    {
        if (this.patientsDataGridView.SelectedRows.Count > 0)
        {
            this.patientsControlViewModel.SelectedPatient =
                (Patient)this.patientsDataGridView.SelectedRows[0].DataBoundItem;
        }
        else
        {
            this.patientsControlViewModel.SelectedPatient = null;
        }
    }

    private void SetupPage()
    {
        // Set up the data grid view
        this.patientsControlViewModel = new PatientsControlViewModel();
        this.patientsDataGridView.DataSource = this.patientsControlViewModel.Patients;
        this.SetUpDataGridViewColumns();
        this.patientsDataGridView.ClearSelection();

        // Bindings and events
        this.editPatientBtn.DataBindings.Add("Enabled", this.patientsControlViewModel,
            nameof(this.patientsControlViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);

        this.patientsDataGridView.SelectionChanged += this.PatientsDataGridView_SelectionChanged;
        this.patientAdvancedSearchControl.SearchBtnClick += this.RefreshPatientList;
        this.patientAdvancedSearchControl.ClearBtnClick += this.RefreshPatientList;
    }

    private void SetUpDataGridViewColumns()
    {
		// Rename main columns
		this.patientsDataGridView.Columns["PatientId"].Visible = false;
		this.patientsDataGridView.Columns["Ssn"].Visible = false;

		this.patientsDataGridView.Columns["FirstName"].HeaderText = "First Name";
        this.patientsDataGridView.Columns["LastName"].HeaderText = "Last Name";
        this.patientsDataGridView.Columns["DateOfBirth"].HeaderText = "Date of Birth";
        this.patientsDataGridView.Columns["Address1"].HeaderText = "Address 1";
        this.patientsDataGridView.Columns["Address2"].HeaderText = "Address 2";
        this.patientsDataGridView.Columns["PhoneNumber"].HeaderText = "Phone Number";

		this.patientsDataGridView.Columns["FirstName"].DisplayIndex = 0;
		this.patientsDataGridView.Columns["LastName"].DisplayIndex = 1;
		this.patientsDataGridView.Columns["DateOfBirth"].DisplayIndex = 2;
		this.patientsDataGridView.Columns["Status"].DisplayIndex = 3;

		this.patientsDataGridView.Columns["FirstName"].ReadOnly = true;
        this.patientsDataGridView.Columns["LastName"].ReadOnly = true;
        this.patientsDataGridView.Columns["DateOfBirth"].ReadOnly = true;
    }

    #endregion
}