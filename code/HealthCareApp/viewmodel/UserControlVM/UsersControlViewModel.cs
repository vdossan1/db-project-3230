using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;
using static HealthCareApp.view.AdvancedSearchControl;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.viewmodel.UserControlVM;

public class UsersControlViewModel : INotifyPropertyChanged
{
    #region Properties

    /// <summary>
    ///     Gets the list of users.
    /// </summary>
    public List<User> Users { get; private set; }

    private User? selectedUser;

    public User? SelectedUser
    {
        get => this.selectedUser;
        set
        {
            if (this.selectedUser != value)
            {
                this.selectedUser = value;
                this.OnPropertyChanged(nameof(this.SelectedUser));

                this.IsValid = this.selectedUser != null;
                this.OnPropertyChanged(nameof(this.IsValid));
            }
        }
    }

    private bool isValid;

    public bool IsValid
    {
        get => this.isValid;
        private set
        {
            if (this.isValid != value)
            {
                this.isValid = value;
                this.OnPropertyChanged(nameof(this.IsValid));
            }
        }
    }

    /// <summary>
    ///     Raises the <see cref="PropertyChanged" /> event for a property.
    /// </summary>
    /// <param name="propertyName">The name of the property that changed.</param>
    protected void OnPropertyChanged(string propertyName)
    {
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    #endregion

    #region Constructors

    /// <summary>
    ///     Initializes a new instance of the <see cref="UsersControlViewModel" /> class.
    /// </summary>
    public UsersControlViewModel()
    {
        this.Users = new List<User>();
        this.PopulateUsers();
        this.IsValid = false;
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Occurs when a property value changes.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    ///     Populates the Users list with either all patients or filtered users based on the provided search criteria.
    /// </summary>
    /// <param name="eventArgs">
    ///     Optional. The <see cref="SearchEventArgs" /> containing the search criteria. If null, all
    ///     patients are retrieved.
    /// </param>
    public void PopulateUsers(SearchEventArgs? eventArgs = null)
    {
        if (eventArgs == null)
        {
            this.Users = NurseDal.GetAllNurses();
        }
        else
        {
            var firstName = eventArgs.FirstName;
            var lastName = eventArgs.LastName;
            var dateOfBirth = eventArgs.DateOfBirth;

            this.Users = NurseDal.GetAllNurseWithParams(firstName, lastName, dateOfBirth);
        }
    }

    #endregion
}