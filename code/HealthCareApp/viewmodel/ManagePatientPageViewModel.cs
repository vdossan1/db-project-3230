using System.ComponentModel;
using System.Diagnostics;
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;

namespace HealthCareApp.viewmodel
{
    public class ManagePatientPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
		public Array StatesArray => Enum.GetValues(typeof(State));
        public Array SexArray => Enum.GetValues(typeof(Sex));

		public void EditPatient()
		{
			Patient patientToEdit = new Patient(FirstName, LastName, DateOfBirth, Sex,
				Address1, Address2, City, State, ZipCode, PhoneNumber, Ssn, true);

			PatientDal.EditPatient(patientToEdit);
			Debug.WriteLine(FirstName + " " + LastName + " " + DateOfBirth.ToShortDateString() + " " + Sex);
		}

		public void RegisterPatient()
        {
            Patient newPatient = new Patient(FirstName, LastName, DateOfBirth, Sex, 
				Address1, Address2, City, State, ZipCode, PhoneNumber, Ssn, true);

            PatientDal.RegisterPatient(newPatient);
            Debug.WriteLine(FirstName + " " + LastName + " " + DateOfBirth.ToShortDateString() + " " + Sex);
        }

        public void PopulateFields(Patient patient)
        {
            FirstName = patient.FirstName;
            LastName = patient.LastName;
            DateOfBirth = patient.DateOfBirth;
            Sex = patient.Sex;
            Address1 = patient.Address1;
            Address2 = patient.Address2;
            City = patient.City;
            State = patient.State;
            ZipCode = patient.ZipCode;
            PhoneNumber = patient.PhoneNumber;
            Ssn = patient.Ssn;
            Status = patient.Status;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Properties

        private string firstName;
		public string FirstName 
		{
			get => firstName;
			set
			{
				if (firstName != value)
				{
					firstName = value;
					OnPropertyChanged(nameof(FirstName));
				}
			}
		}

		private string lastName;
		public string LastName
		{
			get => lastName;
			set
			{
				if (lastName != value)
				{
					lastName = value;
					OnPropertyChanged(nameof(LastName));
				}
			}
		}

		private DateTime dateOfBirth;
		public DateTime DateOfBirth
		{
			get => dateOfBirth;
			set
			{
				if (dateOfBirth != value)
				{
					dateOfBirth = value;
					OnPropertyChanged(nameof(DateOfBirth));
				}
			}
		}

		private string sex;
		public string Sex
		{
			get => sex;
			set
			{
				if (sex != value)
				{
					sex = value;
					OnPropertyChanged(nameof(Sex));
				}
			}
		}

		private string address1;
		public string Address1
		{
			get => address1;
			set
			{
				if (address1 != value)
				{
					address1 = value;
					OnPropertyChanged(nameof(address1));
				}
			}
		}

		private string? address2;
		public string? Address2
		{
			get => address2;
			set
			{
				if (address2 != value)
				{
					address2 = value;
					OnPropertyChanged(nameof(address2));
				}
			}
		}

		private string city;
		public string City
		{
			get => city;
			set
			{
				if (city != value)
				{
					city = value;
					OnPropertyChanged(nameof(City));
				}
			}
		}

		private string state;
		public string State
		{
			get => state;
			set
			{
				if (state != value)
				{
					state = value;
					OnPropertyChanged(nameof(state));
				}
			}
		}

		private string zipCode;
		public string ZipCode
		{
			get => zipCode;
			set
			{
				if (zipCode != value)
				{
					zipCode = value;
					OnPropertyChanged(nameof(ZipCode));
				}
			}
		}

		private string phoneNumber;
		public string PhoneNumber
		{
			get => phoneNumber;
			set
			{
				if (phoneNumber != value)
				{
					phoneNumber = value;
					OnPropertyChanged(nameof(PhoneNumber));
				}
			}
		}

		private string ssn;
		public string Ssn
		{
			get => ssn;
			set
			{
				if (ssn != value)
				{
					ssn = value;
					OnPropertyChanged(nameof(Ssn));
				}
			}
		}

		private bool status;
		public bool Status
		{
			get => status;
			set
			{
				if (status != value)
				{
					status = value;
					OnPropertyChanged(nameof(Status));
				}
			}
		}
        #endregion
    }
}
