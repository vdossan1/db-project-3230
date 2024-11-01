﻿using HealthCareApp.model;
using HealthCareApp.View;
using HealthCareApp.viewmodel;

// Author: Vitor dos Santos & Jacob Evans
// Version: Fall 2024
namespace HealthCareApp.view
{
	/// <summary>
	/// Represents the interface for editing patient information in the healthcare application.
	/// </summary>
	public partial class EditPatientPage : Form
    {
        private List<Control> requiredFields;
        private List<Control> numericFields;

        public event EventHandler PatientUpdated;

        private ManagePatientPageViewModel managePatientViewModel;
        
        public Patient PatientToEdit { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="EditPatientPage"/> class.
		/// </summary>
		/// <param name="mainPage">The <see cref="MainPage"/> instance that contains the data and logic for the main page.</param>
		public EditPatientPage()
        {
            InitializeComponent();
            this.InitializeRequiredFields();
            this.InitializeNumericFields();

            this.managePatientViewModel = new ManagePatientPageViewModel();

            this.BindControls();
        }

        private void InitializeRequiredFields()
        {
            this.requiredFields = new List<Control>{
                this.firstNameTextBox,
                this.lastNameTextBox,
                this.dateOfBirthPicker,
                this.genderCmbBox,
                this.addressOneTxtBox,
                this.cityTxtBox,
                this.stateCmbBox,
                this.zipCodeTxtBox,
                this.phoneNumberTxtBox,
                this.ssnTxtBox,
            };
        }

        private void InitializeNumericFields()
        {
            this.numericFields = new List<Control>
            {
                this.zipCodeTxtBox,
                this.phoneNumberTxtBox,
                this.ssnTxtBox,
            };
        }

        public void PopulateFields()
        {
            managePatientViewModel.PopulateFields(PatientToEdit);
        }

        private void OnPatientUpdated()
        {
            PatientUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void BindControls()
        {
            this.stateCmbBox.DataSource = managePatientViewModel.StatesArray;
            this.genderCmbBox.DataSource = managePatientViewModel.SexArray;

            // Data Bindings
            this.firstNameTextBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.FirstName), true, DataSourceUpdateMode.OnPropertyChanged);

            this.lastNameTextBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.LastName), true, DataSourceUpdateMode.OnPropertyChanged);

            this.dateOfBirthPicker.DataBindings.Add(
                "Value", managePatientViewModel, nameof(managePatientViewModel.DateOfBirth), true, DataSourceUpdateMode.OnPropertyChanged);

            this.genderCmbBox.DataBindings.Add(
                "SelectedItem", managePatientViewModel, nameof(managePatientViewModel.Sex), true, DataSourceUpdateMode.OnPropertyChanged);

            this.addressOneTxtBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.Address1), true, DataSourceUpdateMode.OnPropertyChanged);

            this.addressTwoTxtBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.Address2), true, DataSourceUpdateMode.OnPropertyChanged);

            this.cityTxtBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.City), true, DataSourceUpdateMode.OnPropertyChanged);

            this.stateCmbBox.DataBindings.Add(
                "SelectedItem", managePatientViewModel, nameof(managePatientViewModel.State), true, DataSourceUpdateMode.OnPropertyChanged);

            this.zipCodeTxtBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.ZipCode), true, DataSourceUpdateMode.OnPropertyChanged);

            this.phoneNumberTxtBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.PhoneNumber), true, DataSourceUpdateMode.OnPropertyChanged);

            this.ssnTxtBox.DataBindings.Add(
                "Text", managePatientViewModel, nameof(managePatientViewModel.Ssn), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void editPatientBtn_Click(object sender, EventArgs e)
        {
            bool requirements = true;

            requirements = checkRequiredFields(requirements);
            requirements = checkNumericFields(requirements);

            if (requirements)
            {
                this.managePatientViewModel.EditPatient();
                this.OnPatientUpdated();
                this.Hide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool checkRequiredFields(bool requirements)
        {
            foreach (Control requiredField in this.requiredFields)
            {
                if (requiredField is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(requiredField.Text))
                    {
                        requirements = false;
                        requiredField.BackColor = Color.Red;
                    }
                    else
                    {
                        requiredField.ResetBackColor();
                    }
                }

                if (requiredField is ComboBox)
                {
                    var comboBox = requiredField as ComboBox;
                    if (comboBox.SelectedItem == null)
                    {
                        requirements = false;
                        requiredField.BackColor = Color.Red;
                    }
                    else
                    {
                        requiredField.ResetBackColor();
                    }
                }

                if (requiredField is DateTimePicker)
                {
                    var dateTimePicker = requiredField as DateTimePicker;
                    if (dateTimePicker.Value >= DateTime.Today)
                    {
                        requirements = false;
                        requiredField.BackColor = Color.Red;
                    }
                    else
                    {
                        requiredField.ResetBackColor();
                    }
                }


            }

            return requirements;
        }

        private bool checkNumericFields(bool requirements)
        {
            foreach (Control numericField in this.numericFields)
            {
                if (numericField == this.phoneNumberTxtBox)
                {
                    if (this.phoneNumberTxtBox.Text.All(char.IsDigit) == false)
                    {
                        requirements = false;
                        this.phoneNumNOLabel.Visible = true;
                    }
                    else if (this.phoneNumberTxtBox.Text.Length != 10)
                    {
                        requirements = false;
                        this.phoneNumberTxtBox.BackColor = Color.Red;
                    }
                    else
                    {
                        this.phoneNumNOLabel.Visible = false;
                    }
                }

                if (numericField == this.zipCodeTxtBox)
                {
                    if (this.zipCodeTxtBox.Text.All(char.IsDigit) == false)
                    {
                        requirements = false;
                        this.zipCodeNOLabel.Visible = true;
                    }
                    else if (this.zipCodeTxtBox.Text.Length != 5)
                    {
                        requirements = false;
                        this.zipCodeTxtBox.BackColor = Color.Red;
                    }
                    else
                    {
                        this.zipCodeNOLabel.Visible = false;
                    }

                }

                if (numericField == this.ssnTxtBox)
                {
                    if (this.ssnTxtBox.Text.All(char.IsDigit) == false)
                    {
                        requirements = false;
                        this.ssnNOLabel.Visible = true;
                    }
                    else if (this.ssnTxtBox.Text.Length != 9)
                    {
                        requirements = false;
                        this.ssnTxtBox.BackColor = Color.Red;
                    }
                    else
                    {
                        this.ssnNOLabel.Visible = false;
                    }
                }
            }

            return requirements;
        }
    }
}
