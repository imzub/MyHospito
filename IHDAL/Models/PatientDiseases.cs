using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.Models
{
    public class patientDiseases
    {
        public int pdId { get; set; }
        public string pdDesc { get; set; }
        public int patientVisitId { get; set; }
        public int patientId { get; set; }
        public int dsId { get; set; }
    }
}
