using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HealthCareApp.utils;

namespace HealthCareApp.viewmodel
{
    public class AddPatientPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void registerPatient(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
