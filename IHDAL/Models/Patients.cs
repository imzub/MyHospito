using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.Models
{
    public class Patient
    {
        public int patientId { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public int doctorId { get; set; }
        public byte[] image { get; set; }
        public string imagePath { get; set; }
    }
}
