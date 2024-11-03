using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HealthCareApp.DAL;
using HealthCareApp.model;
using MySql.Data.MySqlClient;

namespace HealthCareApp.viewmodel
{
    public class VisitDetailsPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private List<int> apptIdList;

        public VisitDetailsPageViewModel()
        {
            this.apptIdList = new List<int>(AppointmentDal.GetAllAppointmentsIds());
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SaveVisitDetails()
        {
            try
            {
                Visit newVisit = new Visit(AppointmentId, NurseId, BloodPressureSystolic, BloodPressureDiastolic,
                    BodyTemp, Weight, Height, PulseRate, Symptoms, InitialDiagnoses, FinalDiagnoses);
                VisitDal.CreateVisit(newVisit);
            }
            catch (MySqlException sqlException)
            {
                MessageBox.Show(sqlException.Message, "Sql Error", MessageBoxButtons.OK);
            }
        }

        #region Properties

        public int[] ApptIdsArray => this.apptIdList.ToArray();

        private int appointmentId;

        public int AppointmentId
        {
            get => appointmentId;
            set
            {
                if (appointmentId != value)
                {
                    appointmentId = value;
                    OnPropertyChanged(nameof(AppointmentId));
                }
            }
        }

        private int nurseId;

        public int NurseId
        {
            get => nurseId;
            set
            {
                if (nurseId != value)
                {
                    nurseId = value;
                    OnPropertyChanged(nameof(NurseId));
                }
            }
        }

        private int bloodPressureSystolic;

        public int BloodPressureSystolic
        {
            get => bloodPressureSystolic;
            set
            {
                if (bloodPressureSystolic != value)
                {
                    bloodPressureSystolic = value;
                    OnPropertyChanged(nameof(BloodPressureSystolic));
                }
            }
        }

        private int bloodPressureDiastolic;

        public int BloodPressureDiastolic
        {
            get => bloodPressureDiastolic;
            set
            {
                if (bloodPressureDiastolic != value)
                {
                    bloodPressureDiastolic = value;
                    OnPropertyChanged(nameof(BloodPressureDiastolic));
                }
            }
        }

        private decimal bodyTemp;

        public decimal BodyTemp
        {
            get => bodyTemp;
            set
            {
                if (bodyTemp != value)
                {
                    bodyTemp = value;
                    OnPropertyChanged(nameof(BodyTemp));
                }
            }
        }

        private decimal weight;

        public decimal Weight
        {
            get => weight;
            set
            {
                if (weight != value)
                {
                    weight = value;
                    OnPropertyChanged(nameof(Weight));
                }
            }
        }

        private decimal height;

        public decimal Height
        {
            get => height;
            set
            {
                if (height != value)
                {
                    height = value;
                    OnPropertyChanged(nameof(Height));
                }
            }
        }

        private int pulseRate;

        public int PulseRate
        {
            get => pulseRate;
            set
            {
                if (pulseRate != value)
                {
                    pulseRate = value;
                    OnPropertyChanged(nameof(PulseRate));
                }
            }
        }

        private string symptoms;

        public string Symptoms
        {
            get => symptoms;
            set
            {
                if (symptoms != value)
                {
                    symptoms = value;
                    OnPropertyChanged(nameof(Symptoms));
                }
            }
        }

        private string initialDiagnoses;

        public string InitialDiagnoses
        {
            get => initialDiagnoses;
            set
            {
                if (initialDiagnoses != value)
                {
                    initialDiagnoses = value;
                    OnPropertyChanged(nameof(InitialDiagnoses));
                }
            }
        }

        private string finalDiagnoses;

        public string FinalDiagnoses
        {
            get => finalDiagnoses;
            set
            {
                if (finalDiagnoses != value)
                {
                    finalDiagnoses = value;
                    OnPropertyChanged(nameof(FinalDiagnoses));
                }
            }
        }

        #endregion
    }
}
