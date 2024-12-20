﻿// Author: Vitor dos Santos & Jacob Evans
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
	private bool isDateOfBirthSearch = true;

	#region Constructors

	/// <summary>
	///     Initializes a new instance of the <see cref="AdvancedSearchControl" /> class and sets the date of birth picker
	///     constraints.
	/// </summary>
	public AdvancedSearchControl()
    {
        this.InitializeComponent();

        this.dateOfBirthLabel.Text = "Date of Birth";

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

    /// <summary>
    /// Configures the search functionality to handle advanced date of birth searches.
    /// </summary>
    public void SetDateOfBirthSearch()
    {
        this.advancedSearchButton.Click += this.advancedSearchDateOfBirthButton_Click;
    }

    /// <summary>
    /// Configures the search functionality to handle advanced date and time searches.
    /// </summary>
    public void SetDateTimeSearch()
    {
        this.advancedSearchButton.Click += this.advancedSearchDateTimeButton_Click;
        this.isDateOfBirthSearch = false;
        this.dateOfBirthLabel.Text = "Date and Time";
	}

    /// <summary>
    /// Configures the style of the date picker control with a custom format, maximum date, and appearance.
    /// </summary>
    public void SetDatePickerStyle()
    {
        this.datePicker.Format = DateTimePickerFormat.Custom;
        this.datePicker.CustomFormat = TIME_FORMAT;
        this.datePicker.MaxDate = DateTime.Parse("2124-01-01");
    }

    private void advancedSearchDateOfBirthButton_Click(object sender, EventArgs e)
    {
        var firstName = this.firstNameTxtBox.Text;
        var lastName = this.lastNameTxtBox.Text;
        var dateOfBirth = this.datePicker.Value.Date;

        var searchArgs = new SearchEventArgs(firstName, lastName, dateOfBirth);

        this.SearchBtnClick?.Invoke(this, searchArgs);
    }

    private void advancedSearchDateTimeButton_Click(object sender, EventArgs e)
    {
        var firstName = this.firstNameTxtBox.Text;
        var lastName = this.lastNameTxtBox.Text;
        var dateTime = this.datePicker.Value;
        var trimmedDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, 0,
            0, 0);

        var searchArgs = new SearchEventArgs(firstName, lastName, trimmedDate);

        this.SearchBtnClick?.Invoke(this, searchArgs);
    }

    private void clearAdvSrcButton_Click(object sender, EventArgs e)
    {
        this.firstNameTxtBox.ResetText();
        this.lastNameTxtBox.ResetText();

        if (this.isDateOfBirthSearch)
        {
	        this.datePicker.ResetText();
		}
		else
        {
	        var resetDate = DateTime.Today.Date;
	        this.datePicker.Value = resetDate;
        }

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