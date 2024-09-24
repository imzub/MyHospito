using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDAL.Models
{    
    public class DoctorModel
    {
        public int doctorId { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public byte[] drImage { get; set; }
        public string drImagePath { get; set; }
    }
}
