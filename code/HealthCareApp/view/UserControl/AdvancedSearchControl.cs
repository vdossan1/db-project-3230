// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024

namespace HealthCareApp.view;

/// <summary>
///     Represents a user control for advanced search functionality, allowing input for first name, last name, and date of
///     birth,
///     and providing events for search and clear actions.
/// </summary>
public partial class AdvancedSearchControl : UserControl
{
	private const string TIME_FORMAT = "yyyy-MM-dd HH:mm";

	#region Constructors

	/// <summary>
	///     Initializes a new instance of the <see cref="AdvancedSearchControl" /> class and sets the date of birth picker
	///     constraints.
	/// </summary>
	public AdvancedSearchControl()
    {
        this.InitializeComponent();

        this.datePicker.MinDate = DateTime.Parse("1924-01-01");
        this.datePicker.MaxDate = DateTime.Today;
    }

    #endregion

    #region Methods

    /// <summary>
    ///     Occurs when the search button is clicked, providing the search criteria through <see cref="SearchEventArgs" />.
    /// </summary>
    public event EventHandler<SearchEventArgs> SearchBtnClick;

    /// <summary>
    ///     Occurs when the clear button is clicked, signaling the request to clear the search fields.
    /// </summary>
    public event EventHandler ClearBtnClick;

    public void SetDatePickerStyle()
    {
        this.datePicker.Format = DateTimePickerFormat.Custom;
		this.datePicker.CustomFormat = TIME_FORMAT;
		this.datePicker.MaxDate = DateTime.Parse("2124-01-01");
	}

    private void advanSearchButton_Click(object sender, EventArgs e)
    {
        var firstName = this.firstNameTxtBox.Text;
        var lastName = this.lastNameTxtBox.Text;
        var dateTime = this.datePicker.Value;
        var trimmedDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0, 0, 0);

		var searchArgs = new SearchEventArgs(firstName, lastName, trimmedDate);

        this.SearchBtnClick?.Invoke(this, searchArgs);
    }

    private void clearAdvSrcButton_Click(object sender, EventArgs e)
    {
	    this.firstNameTxtBox.ResetText();
	    this.lastNameTxtBox.ResetText();
	    this.datePicker.ResetText();

	    this.ClearBtnClick?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    ///     Provides data for the <see cref="SearchBtnClick" /> event, containing search criteria such as first name,
    ///     last name, and date of birth.
    /// </summary>
    public class SearchEventArgs : EventArgs
    {
        #region Properties

        /// <summary>
        ///     Gets the first name entered in the search.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        ///     Gets the last name entered in the search.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        ///     Gets the date of birth entered in the search.
        /// </summary>
        public DateTime DateOfBirth { get; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SearchEventArgs" /> class with the specified search criteria.
        /// </summary>
        public SearchEventArgs(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
        }

        #endregion
    }

    #endregion
}