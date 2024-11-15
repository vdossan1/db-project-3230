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
	    this.patientsDataGridView.Columns["PatientId"].Visible = false;
	    this.patientsDataGridView.ClearSelection();

		// Bindings and events
		this.editPatientBtn.DataBindings.Add("Enabled", this.patientsControlViewModel,
		    nameof(this.patientsControlViewModel.IsValid), true, DataSourceUpdateMode.OnPropertyChanged);

	    this.patientsDataGridView.SelectionChanged += this.PatientsDataGridView_SelectionChanged;
	    this.patientAdvancedSearchControl.SearchBtnClick += this.RefreshPatientList;
	    this.patientAdvancedSearchControl.ClearBtnClick += this.RefreshPatientList;
	}

	#endregion
}