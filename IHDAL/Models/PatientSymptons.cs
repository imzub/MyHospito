using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.Models
{
    public class patientSymptons
    {
        public int psId { get; set; }
        public string psDesc { get; set; }
        public int patientVisitId { get; set; }
        public int patientId { get; set; }
        public int smId { get; set; }
    }
}
