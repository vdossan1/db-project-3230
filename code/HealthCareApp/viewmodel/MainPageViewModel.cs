using System.Collections.ObjectModel;
using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel
{S
	public class MainPageViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<Patient> _patients;
		public ObservableCollection<Patient> Patients
		{
			get => _patients;
			set
			{
				_patients = value;
				OnPropertyChanged(nameof(Patients));
			}
		}

		public MainPageViewModel()
		{
			Patients = new ObservableCollection<Patient>();
			//RefreshPatientsCommand = new RelayCommand(RefreshPatientList);
			PopulatePatients();
		}

		public void PopulatePatients()
		{
			var patients = PatientDal.GetAllPatients();
			Patients.Clear();
			foreach (var patient in patients)
			{
				Patients.Add(patient);
			}
		}

		private void RefreshPatientList(object obj)
		{
			PopulatePatients();
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
