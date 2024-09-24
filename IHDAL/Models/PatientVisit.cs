using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.Models
{
    public class PatientVisit
    {
        public int patientVisitId { get; set; }
        public int patientId { get; set; }
        public string concerns { get; set; }
        public string symptoms { get; set; }
        public int doctorId { get; set; }
        public int? feesId { get; set; }
        public int? paidFees { get; set; }
        public string gender { get; set; }
    }
}
