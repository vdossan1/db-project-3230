using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HealthCareApp.DAL;
using HealthCareApp.model;
using HealthCareApp.utils;

namespace HealthCareApp.viewmodel
{
    public class AddPatientPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        private string ssn;
        public string Ssn
        {
            get => ssn;
            set
            {
                if (ssn != value)
                {
                    ssn = value;
                    OnPropertyChanged(nameof(ssn));
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

        private States selectedState;

        public States SelectedState
        {
            get => selectedState;
            set
            {
                if (selectedState != value)
                {
                    selectedState = value;
                    OnPropertyChanged(nameof(selectedState));
                }
            }
        }

        public Array StatesArray => Enum.GetValues(typeof(States));

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public void registerPatient()
        {
            // TODO finish adding all properties and implement Register Patient in the DAL
            /*Patient newPatient = new Patient(
                );
            PatientDal.RegisterPatient(newPatient);*/
            Debug.WriteLine(FirstName + LastName + " " +SelectedState);
        }
    }
}
