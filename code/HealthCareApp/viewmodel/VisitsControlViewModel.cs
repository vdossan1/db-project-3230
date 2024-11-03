using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareApp.DAL;
using HealthCareApp.model;

namespace HealthCareApp.viewmodel
{
    public class VisitsControlViewModel
    {
        public List<Visit> Visits { get; private set; }

        public VisitsControlViewModel()
        {
            this.Visits = new List<Visit>();
            this.PopulateVisits();
        }

        public void PopulateVisits()
        {
            Visits = VisitDal.GetAllVisits();
        }
    }
}
