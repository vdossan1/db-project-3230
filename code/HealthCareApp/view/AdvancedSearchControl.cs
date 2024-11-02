namespace HealthCareApp.view
{
    public partial class AdvancedSearchControl : UserControl
    {
        public event EventHandler<SearchEventArgs> SearchBtnClick;
        public event EventHandler ClearBtnClick;

        public AdvancedSearchControl()
        {
            InitializeComponent();

            this.dateOfBirthPicker.MinDate = DateTime.Parse("1924-01-01");
            this.dateOfBirthPicker.MaxDate = DateTime.Today;
        }

        private void advanSearchButton_Click(object sender, EventArgs e)
        {
            var firstName = this.firstNameTxtBox.Text;
            var lastName = this.lastNameTxtBox.Text;
            var dateOfBirth = this.dateOfBirthPicker.Value.Date;

            var searchArgs = new SearchEventArgs(firstName, lastName, dateOfBirth);

            SearchBtnClick?.Invoke(this, searchArgs);
        }

        private void clearAdvSrcButton_Click(object sender, EventArgs e)
        {
            this.firstNameTxtBox.ResetText();
            this.lastNameTxtBox.ResetText();
            this.dateOfBirthPicker.ResetText();

            ClearBtnClick?.Invoke(this, EventArgs.Empty);
        }

        public class SearchEventArgs : EventArgs
        {
            public string FirstName { get; }
            public string LastName { get; }
            public DateTime DateOfBirth { get; }

            public SearchEventArgs(string firstName, string lastName, DateTime dateOfBirth)
            {
                FirstName = firstName;
                LastName = lastName;
                DateOfBirth = dateOfBirth;
            }
        }
    }
}
