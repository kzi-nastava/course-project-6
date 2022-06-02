using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patients.Models
{
    public class MedicalRecord
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public List<string> allergies { get; set; }
    }
}
