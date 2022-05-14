using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patients.Models
{
    public class Anamnesis
    {
        public string date { get; set; }
        public string doctor { get; set; }
        public string type { get; set; }
        public string notes { get; set; }
        public List<string> medication { get; set; }
    }
}
