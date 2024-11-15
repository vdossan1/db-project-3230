using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.viewmodel.UserControlVM;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view;

/// <summary>
///     Represents a user control for managing appointments, allowing users to create, edit, and search for appointments.
/// </summary>
public partial class VisitsControl : UserControl
{
    #region Data members

    private VisitsControlViewModel visitsControlViewModel;
    private readonly string nurseFullName;
    private readonly string username;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="VisitsControl" /> class and sets up the data grid and event handlers.
    /// </summary>
    public VisitsControl(string nurseFullName, string userName)
    {
        this.InitializeComponent();
        this.nurseFullName = nurseFullName;
        this.username = userName;
        this.SetUpPage();
	}

    #endregion

    #region Methods

    private void editVisitBtn_Click(object sender, EventArgs e)
    {
        if (this.visitsDataGridView.SelectedRows.Count > 0)
        {
            var selectedVisit = (Visit)this.visitsDataGridView.SelectedRows[0].DataBoundItem;
            var editVisitPage = new ManageVisitDetailsPage(this.nurseFullName, this.username, selectedVisit);
            editVisitPage.FormClosed += this.RefreshPatientList;
            editVisitPage.ShowDialog();
        }
    }

    public void RefreshVisitsList(object? sender, FormClosedEventArgs e)
    {
        this.visitsControlViewModel.PopulateVisits();
        this.visitsDataGridView.DataSource = this.visitsControlViewModel.Visits;
        this.visitsDataGridView.ClearSelection();
    }

    private void createVisitBtn_Click(object sender, EventArgs e)
    {
        var createVisitPage = new ManageVisitDetailsPage(this.nurseFullName, this.username);
        createVisitPage.FormClosed += this.RefreshVisitsList;
        createVisitPage.ShowDialog();
    }

    private void RefreshPatientList(object sender, EventArgs e)
    {
        if (e is SearchEventArgs searchArgs)
        {
            this.visitsControlViewModel.PopulateVisits(searchArgs);
        }
        else
        {
            this.visitsControlViewModel.PopulateVisits();
        }

        this.visitsDataGridView.DataSource = this.visitsControlViewModel.Visits;
        this.visitsDataGridView.ClearSelection();
    }

    private void VisitsDataGridView_SelectionChanged(object? sender, EventArgs e)
    {
	    if (this.visitsDataGridView.SelectedRows.Count > 0)
	    {
            var selectedVisit = (Visit)this.visitsDataGridView.SelectedRows[0].DataBoundItem;
			this.visitsControlViewModel.SelectedVisit = selectedVisit;
            this.visitsControlViewModel.PopulateTestResults();
            this.labTestResultsDataGridView.DataSource = this.visitsControlViewModel.LabTestResults;
		}
	    else
	    {
			this.visitsControlViewModel.SelectedVisit = null;
			this.labTestResultsDataGridView.DataSource = null;
		}
    }

	private void SetUpPage()
    {
		// Set up the data grid view
		this.visitsControlViewModel = new VisitsControlViewModel();
	    this.visitsDataGridView.DataSource = this.visitsControlViewModel.Visits;
		this.visitsDataGridView.SelectionChanged += this.VisitsDataGridView_SelectionChanged;

		// Set up the advanced search control
		this.visitAdvancedSearchControl.SearchBtnClick += this.RefreshPatientList;
	    this.visitAdvancedSearchControl.ClearBtnClick += this.RefreshPatientList;

		// Set up the event handlers
		this.createVisitBtn.DataBindings.Add(
		    "Enabled", this.visitsControlViewModel, nameof(this.visitsControlViewModel.IsValid), true,
		    DataSourceUpdateMode.OnPropertyChanged);

	    this.createVisitLabel.DataBindings.Add(
		    "Visible", this.visitsControlViewModel, nameof(this.visitsControlViewModel.ShowLabel), true,
		    DataSourceUpdateMode.OnPropertyChanged);
	}

    #endregion
}