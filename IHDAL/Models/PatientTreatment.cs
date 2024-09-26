using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.Models
{
    public class PatientTreatment
    {
        public int ptId { get; set; }
        public string ptDesc { get; set; }
        public int patientVisitId { get; set; }
        public int patientId { get; set; }
        public int tId { get; set; }
        public string prescriptionItem { get; set; }
    }
}
