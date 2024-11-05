using HealthCareApp.DAL;
using HealthCareApp.viewmodel.UserControlVM;

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
    private readonly int nurseId;

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="VisitsControl" /> class and sets up the data grid and event handlers.
    /// </summary>
    public VisitsControl(string nurseUsername)
    {
        this.InitializeComponent();

        this.nurseId = NurseDal.GetIdFromUsername(nurseUsername);
        this.visitsControlViewModel = new VisitsControlViewModel();

        this.visitsDataGridView.DataSource = this.visitsControlViewModel.Visits;

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
        var createVisitPage = new ManageVisitDetailsPage(this.nurseId);
        createVisitPage.FormClosed += this.RefreshVisitsList;
        createVisitPage.ShowDialog();
    }

    #endregion
}