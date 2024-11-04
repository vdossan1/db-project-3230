using System.ComponentModel;
using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel
{
    public class VisitsControlViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public List<Visit> Visits { get; private set; }

        public VisitsControlViewModel()
        {
            this.Visits = new List<Visit>();
            this.PopulateVisits();
            ManageAppointmentViewModel.AddAppointment += OnAppointmentAdded;
        }

        private void OnAppointmentAdded(object? sender, EventArgs e)
        {
            GetCountOfAppointmentsWithNoVisit();
        }

        public void PopulateVisits()
        {
            Visits = VisitDal.GetAllVisits();
        }

        public bool IsValid => this.GetCountOfAppointmentsWithNoVisit() > 0;

        public bool ShowLabel => !IsValid;

        public int GetCountOfAppointmentsWithNoVisit()
        {
            int count = AppointmentDal.GetAllAppointmentsIdsWithNoVisits().Count;
            OnPropertyChanged(nameof(IsValid));
            OnPropertyChanged(nameof(ShowLabel));

            return count;
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
