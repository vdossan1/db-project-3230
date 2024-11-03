using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareApp.model
{
    public class Visit
    {
        public int VisitId { get; set; }

        public int AppointmentId { get; set; }

        public int NurseId { get; set; }

        public int BloodPressureSystolic { get; set; }

        public int BloodPressureDiastolic { get; set; }

        public decimal BodyTemp { get; set; }

        public decimal Weight { get; set; }

        public decimal Height { get; set; }

        public int PulseRate { get; set; }

        public string Symptoms { get; set; }

        public string InitialDiagnoses { get; set; }

        public string FinalDiagnoses { get; set; }

        public Visit(int appointmentId, int nurseId, int bloodPressureSystolic, int bloodPressureDiastolic,
            decimal bodyTemp, decimal weight, decimal height, int pulseRate, string symptoms, string initialDiagnoses, string finalDiagnoses)
        {
            AppointmentId = appointmentId;
            NurseId = nurseId;
            BloodPressureSystolic = bloodPressureSystolic;
            BloodPressureDiastolic = bloodPressureDiastolic;
            BodyTemp = bodyTemp;
            Weight = weight;
            Height = height;
            PulseRate = pulseRate;
            Symptoms = symptoms ?? throw new ArgumentNullException(nameof(symptoms));
            InitialDiagnoses = initialDiagnoses ?? throw new ArgumentNullException(nameof(initialDiagnoses));
            FinalDiagnoses = finalDiagnoses;
        }

        public Visit(int visitId, int appointmentId, int nurseId, int bloodPressureSystolic, int bloodPressureDiastolic,
            decimal bodyTemp, decimal weight, decimal height, int pulseRate, string symptoms, string initialDiagnoses, string finalDiagnoses)
        {
            VisitId = visitId;
            AppointmentId = appointmentId;
            NurseId = nurseId;
            BloodPressureSystolic = bloodPressureSystolic;
            BloodPressureDiastolic = bloodPressureDiastolic;
            BodyTemp = bodyTemp;
            Weight = weight;
            Height = height;
            PulseRate = pulseRate;
            Symptoms = symptoms ?? throw new ArgumentNullException(nameof(symptoms));
            InitialDiagnoses = initialDiagnoses ?? throw new ArgumentNullException(nameof(initialDiagnoses));
            FinalDiagnoses = finalDiagnoses;
        }
    }
}
