using HealthCareApp.DAL;
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

    private readonly VisitsControlViewModel visitsControlViewModel;
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
        this.visitsControlViewModel = new VisitsControlViewModel();

        this.visitsDataGridView.DataSource = this.visitsControlViewModel.Visits;

        this.visitAdvancedSearchControl.SearchBtnClick += this.RefreshPatientList;
        this.visitAdvancedSearchControl.ClearBtnClick += this.RefreshPatientList;

        this.createVisitBtn.DataBindings.Add(
            "Enabled", this.visitsControlViewModel, nameof(this.visitsControlViewModel.IsValid), true,
            DataSourceUpdateMode.OnPropertyChanged);

        this.createVisitLabel.DataBindings.Add(
            "Visible", this.visitsControlViewModel, nameof(this.visitsControlViewModel.ShowLabel), true,
            DataSourceUpdateMode.OnPropertyChanged);
    }

    #endregion

    #region Methods

    private void editVisitBtn_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Feature not implemented yet", "TODO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



    #endregion
}