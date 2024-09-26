using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHDAL.Models
{
    public class FileLocationModel
    {
        public int flId { get; set; }
        public string FileName { get; set; }
        public string PhysicalPath { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Description { get; set; }
    }
}
