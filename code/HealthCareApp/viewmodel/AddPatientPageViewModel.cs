using System.ComponentModel;
using System.Diagnostics;
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;

namespace HealthCareApp.viewmodel
{
    public class AddPatientPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
		public Array StatesArray => Enum.GetValues(typeof(State));
        public Array GenderArray => Enum.GetValues(typeof(Gender));


		protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void RegisterPatient()
        {
            Patient newPatient = new Patient(FirstName, LastName, DateOfBirth, Gender.ToString(), 
				Address1, Address2, City, State.ToString(), ZipCode, PhoneNumber, Ssn, true);
            PatientDal.RegisterPatient(newPatient);
            Debug.WriteLine(FirstName + " " + LastName + " " + DateOfBirth.ToShortDateString() + " " + Gender);
        }

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

		private Gender gender;
		public Gender Gender
		{
			get => gender;
			set
			{
				if (gender != value)
				{
					gender = value;
					OnPropertyChanged(nameof(Gender));
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

		private State state;
		public State State
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

		private string status;
		public string Status
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
	}
}
